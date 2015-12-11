using Airline_Reservation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservation
{
    public partial class MainWindow : Form
    {
        #region fields
        private Logger log = new Logger();
        private string userId;
        private bool isAdmin;
        private static DataTable flightDataTable;
        private string source;
        private string destination;
        private List<Flights> flights = new List<Flights>();
        private Ticket currentTicket = new Ticket();
        private string _selectedTicketId;
        private Flights currentFlight = new Flights();
        private List<FlightFare> currentFlightFare = new List<FlightFare>();
        private BindingList<Passenger> currentPassengers = new BindingList<Passenger>();

        private List<Ticket> bookTicket = new List<Ticket>();
        private List<Passenger> bookedPassengers = new List<Passenger>();

        #endregion fields

        #region constructor
        public MainWindow(string usrId)
        {
            userId = usrId;
            InitializeComponent();
        }
        #endregion

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            log.GetMethodLog("MainWindow", "MainWindow_Load -Entered");
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = string.Empty;

            connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";
            sql = "select u.Name, ugl.grp_Id from users u "
                  + "left outer join User_Group_link ugl on ugl.usr_id = u.Usr_Id "
                  + "where u.Usr_Id ='" + userId + "'";

            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                string Name = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                lblGreeting.Text = string.Format("Hello {0}", Name);
                isAdmin = ds.Tables[0].Rows[0].ItemArray[1].ToString().ToUpper() == "ADMIN";
                adapter.Dispose();
                command.Dispose();
                connection.Close();

                if (isAdmin)
                {
                    btnAddFlight.Visible = true;
                    btnDeleteFlight.Visible = true;
                    btnUpdateFlight.Visible = true;
                    dgFlights.AllowUserToAddRows = true;
                    dgFlights.AllowUserToDeleteRows = true;
                }
            }
            catch (Exception ex)
            {
                log.GetMethodLog("MainWindow", "MainWindow_Load ,Exception : " + ex.Message);
            }


            this.tabControl1.Controls.Remove(this.tabBookTicket);
            this.tabControl1.Controls.Remove(this.tabBookedHistory);
            this.tabControl1.Controls.Remove(this.tabFlightsInfo);
            log.GetActionLog("Main Window ", "Loaded");
            log.GetMethodLog("MainWindow", "MainWindow_Load -Exit");
        }

        #region Book Ticket
        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "btnBookTicket_Click -Entered");  
            if (!tabControl1.TabPages.Contains(tabBookTicket))
            {
                tabControl1.TabPages.Add(tabBookTicket);
            }
            tabControl1.SelectedTab = tabBookTicket;
            txtBoxTicketNo.Text = String.Format("Ticket{0}",DateTime.Now.ToString());
            currentTicket.TicketId = txtBoxTicketNo.Text;

            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = string.Empty;

            connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";
            sql = "SELECT Flight_Id,Flight_Description,Arrival_time,Departure_time,FSource,FDestination FROM Flight_details";

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                flights = ds.Tables[0].AsEnumerable().Select(r => new Flights
                {
                    FlightId = r.Field<string>("Flight_Id"),
                    FlightDescription = r.Field<string>("Flight_Description"),
                    ArrivalTime = r.Field<DateTime>("Arrival_time"),
                    DepTime = r.Field<DateTime>("Departure_time"),
                    Source = r.Field<string>("FSource"),
                    Destination = r.Field<string>("FDestination")
                }).ToList();
                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                log.GetMethodLog("MainWindow", "btnBookTicket_Click ,Exception : " + ex.Message);
            }
            cmboxSource.DataSource = flights.Select(p => p.Source).ToList();
            dgPassenger.DataSource = currentPassengers;
      if (dgPassenger.Columns.Contains("TicketId"))
      {
        dgPassenger.Columns.Remove("TicketId");
      }
      log.GetActionLog("Book Ticket ", "Loaded");

            log.GetMethodLog("MainWindow", "btnBookTicket_Click -Exit"); 

        }


        private void comBoxDestination_SelectedValueChanged(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "comBoxDestination_SelectedValueChanged -Entered");
            destination = comBoxDestination.SelectedItem.ToString();
            currentFlight = flights.Where(x => x.Source == source && x.Destination == destination).FirstOrDefault();
            currentTicket.FlightId = currentFlight.FlightId;
            txtBoxFlightId.Text = currentTicket.FlightId;
            txtBoxArrivalTime.Text = currentFlight.ArrivalTime.ToString();
            txtBoxDepartureTime.Text = currentFlight.DepTime.ToString();

            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = string.Empty;

            connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";
            sql = "SELECT Flight_Id,cost,class FROM Flight_fare where flight_id ='" + currentTicket.FlightId + "'";

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                currentFlightFare = ds.Tables[0].AsEnumerable().Select(r => new FlightFare
                {
                    FlightId = r.Field<string>("Flight_Id"),
                    Cost = r.Field<decimal>("cost"),
                    FlightClass = r.Field<string>("class")
                }).ToList();
                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                log.GetMethodLog("MainWindow", "comBoxDestination_SelectedValueChanged ,Exception : " + ex.Message);
            }
            comBoxClass.DataSource = currentFlightFare.Where(x => x.FlightId == currentFlight.FlightId).Select(x => x.FlightClass).ToList();

            log.GetMethodLog("MainWindow", "comBoxDestination_SelectedValueChanged -Exit");
        }

        private void cmboxSource_SelectedValueChanged(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "cmboxSource_SelectedValueChanged -Entered");
            source = cmboxSource.SelectedItem.ToString();
            comBoxDestination.DataSource = flights.Where(x => x.Source == source).Select(x => x.Destination).ToList().Distinct().ToList();
            currentFlight.Source = source;
            log.GetMethodLog("MainWindow", "cmboxSource_SelectedValueChanged -Exit");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "btnRemove_Click -Entered");
            int selectedIndex = dgPassenger.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dgPassenger.Rows.RemoveAt(selectedIndex);
                dgPassenger.Refresh(); // if needed
            }
            log.GetMethodLog("MainWindow", "btnRemove_Click -Exit");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtBoxFare.Text = CalculateFare();
        }

        private string CalculateFare()
        {
            int TotalPassengers = currentPassengers.Count;
            decimal cost = currentFlightFare.Where(x => x.FlightClass == currentTicket.Fightclass).FirstOrDefault().Cost;
            return (TotalPassengers * cost).ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "btnOK_Click -Entered");
            if (currentPassengers.Count == 0)
            {
                MessageBox.Show("No passengers");
            }
            else
            {
                string connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";

                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_I_Ticket_Details", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Ticket_Id", SqlDbType.VarChar).Value = currentTicket.TicketId;
                        cmd.Parameters.Add("@Flight_Id", SqlDbType.VarChar).Value = currentTicket.FlightId;
                        cmd.Parameters.Add("@Booked_on", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd.Parameters.Add("@Booked_by", SqlDbType.VarChar).Value = userId;
                        cmd.Parameters.Add("@class", SqlDbType.VarChar).Value = currentTicket.Fightclass;
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                foreach (Passenger passenger in currentPassengers)
                {
                    using (SqlConnection con = new SqlConnection(connetionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_I_Passengers", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@Ticket_Id", SqlDbType.VarChar).Value = currentTicket.TicketId;
                            cmd.Parameters.Add("@Passenger_Name", SqlDbType.VarChar).Value = passenger.Name;
                            cmd.Parameters.Add("@age", SqlDbType.Int).Value = passenger.Age;
                            cmd.Parameters.Add("@sex", SqlDbType.VarChar).Value = passenger.Sex;
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Ticket booked successfully");
                log.GetActionLog("Book ticket", "Ticket booked successfully");

            }
            log.GetMethodLog("MainWindow", "btnOK_Click -Exit");
        }

        private void btnBookAnotherTicket_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "btnBookAnotherTicket_Click -Entered");
            currentPassengers = new BindingList<Passenger>();
            dgPassenger.DataSource = currentPassengers;
            dgPassenger.Columns.Remove("TicketId");
            dgPassengers.Update();
            dgPassengers.Refresh();
            txtBoxTicketNo.Text = String.Format("Ticket{0}", DateTime.Now.ToString());
            currentTicket.TicketId = txtBoxTicketNo.Text;
            log.GetMethodLog("MainWindow", "btnBookAnotherTicket_Click -Exit");
        }

        private void comBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTicket.Fightclass = comBoxClass.SelectedItem.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtBoxFare.Text = CalculateFare();
        }
        #endregion

        #region Flights Info
        private void btnflights_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "btnflights_Click -Entered"); 
            if (!tabControl1.TabPages.Contains(tabFlightsInfo))
            {
                tabControl1.TabPages.Add(tabFlightsInfo);
            }
            tabControl1.SelectedTab = tabFlightsInfo;

            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = string.Empty;

            connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";
            sql = "SELECT Flight_Id,Flight_Description,Arrival_time,Departure_time,FSource,FDestination FROM Flight_details";

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                flights = ds.Tables[0].AsEnumerable().Select(r => new Flights
                {
                    FlightId = r.Field<string>("Flight_Id"),
                    FlightDescription = r.Field<string>("Flight_Description"),
                    ArrivalTime = r.Field<DateTime>("Arrival_time"),
                    DepTime = r.Field<DateTime>("Departure_time"),
                    Source = r.Field<string>("FSource"),
                    Destination = r.Field<string>("FDestination")
                }).ToList();
                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                log.GetMethodLog("MainWindow", "btnflights_Click ,Exception : " + ex.Message);
            }           
            //this.tabControl1.Controls.Add(this.tabFlightsInfo);
            dgFlights.DataSource = flights;

            log.GetActionLog("Flights Information ", "Loaded");
            log.GetMethodLog("MainWindow", "btnflights_Click -Exit"); 
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "btnAddFlight_Click -Entered"); 
            if (dgFlights.SelectedRows.Count == 0)
            {
                dgFlights.DataSource = null;
                Flights newFlight = new Flights();
                flights.Add(newFlight);
                dgFlights.DataSource = flights;
                dgFlights.Update();
                dgFlights.Refresh();
            }
            else 
            {
                DataGridViewRow row = dgFlights.SelectedRows[0];

                string connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";

                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_I_Flight_Details", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Flight_Id", SqlDbType.VarChar).Value = row.Cells[0].Value.ToString();
                        cmd.Parameters.Add("@Flight_Description", SqlDbType.VarChar).Value = row.Cells[1].Value.ToString();
                        cmd.Parameters.Add("@Arrival_time", SqlDbType.DateTime).Value = row.Cells[4].Value.ToString();
                        cmd.Parameters.Add("@Departure_time", SqlDbType.DateTime).Value = row.Cells[5].Value.ToString();
                        cmd.Parameters.Add("@FSource", SqlDbType.VarChar).Value = row.Cells[2].Value.ToString();
                        cmd.Parameters.Add("@FDestination", SqlDbType.VarChar).Value = row.Cells[3].Value.ToString();
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                log.GetActionLog("Flight Information ", "new record inserted");
                MessageBox.Show(string.Format("Flight : {0} Added", row.Cells[0].Value.ToString()));
            }
            log.GetMethodLog("MainWindow", "btnAddFlight_Click -Exit"); 
        }

        private void btnUpdateFlight_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "btnUpdateFlight_Click -Entered"); 
            if (dgFlights.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dgFlights.SelectedRows[0];

                string connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";

                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_U_Flight_Details", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Flight_Id", SqlDbType.VarChar).Value = row.Cells[0].Value.ToString();
                        cmd.Parameters.Add("@Flight_Description", SqlDbType.VarChar).Value = row.Cells[1].Value.ToString();
                        cmd.Parameters.Add("@Arrival_time", SqlDbType.DateTime).Value = row.Cells[4].Value.ToString();
                        cmd.Parameters.Add("@Departure_time", SqlDbType.DateTime).Value = row.Cells[5].Value.ToString();
                        cmd.Parameters.Add("@FSource", SqlDbType.VarChar).Value = row.Cells[2].Value.ToString();
                        cmd.Parameters.Add("@FDestination", SqlDbType.VarChar).Value = row.Cells[3].Value.ToString();
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                log.GetActionLog("Flight Information ", "Record updtaed");
                MessageBox.Show(string.Format("Flight : {0} Updated",row.Cells[0].Value.ToString()));
            }
            log.GetMethodLog("MainWindow", "btnUpdateFlight_Click -Exit"); 
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "btnDeleteFlight_Click -Entered"); 
            if (dgFlights.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dgFlights.SelectedRows[0];
                string flightId = row.Cells[0].Value.ToString();
                string connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";

                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_D_Flight_Details", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Flight_Id", SqlDbType.VarChar).Value = flightId;
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                Flights deletedFlight = flights.Where(x=> x.FlightId == flightId).FirstOrDefault();

                flights.Remove(deletedFlight);
                dgFlights.DataSource = null;
                dgFlights.DataSource = flights;
                dgFlights.Update();
                dgFlights.Refresh();               
            }
            log.GetActionLog("Flight Information ", "Record deleted");
            log.GetMethodLog("MainWindow", "btnDeleteFlight_Click -Exit"); 
        }

        #region Passenger
        private void btnPassengers_Click(object sender, EventArgs e)
        {
            if (dgFlights.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dgFlights.SelectedRows[0];
                PassengersWin frm = new PassengersWin(row.Cells[0].Value.ToString());
                frm.Show();
            }
        }
        #endregion

        #region Flight fare
        private void button2_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "button2_Click -Entered"); 
            if (dgFlights.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dgFlights.SelectedRows[0];
                FlightFareWindow frm = new FlightFareWindow(row.Cells[0].Value.ToString(),isAdmin);
                frm.Show();
            }
            log.GetMethodLog("MainWindow", "button2_Click -Exit"); 
        }
        #endregion

        #region Crew
        private void button1_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "button1_Click -Entered"); 
            if (dgFlights.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dgFlights.SelectedRows[0];
                FlightCrewWindow frm = new FlightCrewWindow(row.Cells[0].Value.ToString(),isAdmin);
                frm.Show();
            }
            log.GetMethodLog("MainWindow", "button1_Click -Exit"); 
        }
        #endregion

        #endregion

        #region Booked History
        private void btnBookedHistory_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "btnBookedHistory_Click -Entered"); 
            if (!tabControl1.TabPages.Contains(tabBookedHistory))
            {
                tabControl1.TabPages.Add(tabBookedHistory);
            }
            tabControl1.SelectedTab = tabBookedHistory;
            
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = string.Empty;

            connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";
            sql = "SELECT Flight_Id,Ticket_id,Bokked_on,class FROM Ticket_details where booked_by ='"+userId+"'";

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                bookTicket = ds.Tables[0].AsEnumerable().Select(r => new Ticket
                {
                    FlightId = r.Field<string>("Flight_Id"),
                    TicketId = r.Field<string>("Ticket_id"),
                    BookedOn = r.Field<DateTime>("Bokked_on"),
                    Fightclass = r.Field<string>("class")
                }).ToList();
                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                log.GetMethodLog("MainWindow", "btnBookedHistory_Click ,Exception : " + ex.Message);
            }
            dgTickets.DataSource = bookTicket;
            dgTickets.Columns.Remove("BookedBy");
            log.GetActionLog("Booked History", "Loaded");
            log.GetMethodLog("MainWindow", "btnBookedHistory_Click -Exit"); 
        }

        private void btnUnBookTicket_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "btnUnBookTicket_Click -Entered"); 
            if (dgTickets.SelectedRows.Count != 0)
            {
                for (int i = 0; i < dgTickets.SelectedRows.Count; i++)
                {
                    DataGridViewRow row = dgTickets.SelectedRows[i];
                    string ticketId = row.Cells[1].Value.ToString();

                    string connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";

                    using (SqlConnection con = new SqlConnection(connetionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_D_Ticket", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@Ticket_Id", SqlDbType.VarChar).Value = ticketId;
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    Ticket deletedTicket = bookTicket.Where(x => x.TicketId == ticketId).FirstOrDefault();

                    bookTicket.Remove(deletedTicket);
                }
                dgTickets.DataSource = null;
                dgTickets.DataSource = bookTicket;
                dgTickets.Columns.Remove("BookedBy");
                dgTickets.Update();
                dgTickets.Refresh();
                log.GetActionLog("Booked History", "Unbooked Ticked");
                log.GetMethodLog("MainWindow", "btnUnBookTicket_Click -Exit"); 
            }
        }

        private void btnUnbookPassener_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("MainWindow", "btnUnbookPassener_Click -Entered"); 
            if (dgPassengers.SelectedRows.Count != 0)
            {
                for (int i = 0; i < dgPassengers.SelectedRows.Count ; i++)
                {
                    DataGridViewRow row = dgPassengers.SelectedRows[i];
                    string Name = row.Cells[0].Value.ToString();
                    int age = Convert.ToInt32(row.Cells[2].Value);

                    string connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";

                    using (SqlConnection con = new SqlConnection(connetionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_D_Passenger", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@Ticket_Id", SqlDbType.VarChar).Value = _selectedTicketId;
                            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
                            cmd.Parameters.Add("@age", SqlDbType.Int).Value = age;
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    Passenger deletedPassenger = bookedPassengers.Where(x => x.Name == Name && x.Age == age).FirstOrDefault();

                    bookedPassengers.Remove(deletedPassenger);
                }
                log.GetActionLog("Booked History", "Unbooked Ticked");
                dgPassengers.DataSource = null;
                dgPassengers.DataSource = bookedPassengers;
                dgPassengers.Columns.Remove("TicketId");
                dgPassengers.Update();
                dgPassengers.Refresh();
                log.GetMethodLog("MainWindow", "btnUnbookPassener_Click -Exit"); 
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            log.GetMethodLog("MainWindow", "dataGridView1_RowHeaderMouseClick -Entered");
            if (e.RowIndex > -1)
            {
                _selectedTicketId = dgTickets.Rows[e.RowIndex].Cells[1].Value.ToString();
                string connetionString = null;
                SqlConnection connection;
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                string sql = string.Empty;

                connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";
                sql = "SELECT Passenger_Name,age,sex FROM Passengers where Ticket_id ='" + _selectedTicketId + "'";

                connection = new SqlConnection(connetionString);

                try
                {
                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    bookedPassengers = ds.Tables[0].AsEnumerable().Select(r => new Passenger
                    {
                        Name = r.Field<string>("Passenger_Name"),
                        Age = r.Field<int>("age"),
                        Sex = r.Field<string>("sex")
                    }).ToList();
                    adapter.Dispose();
                    command.Dispose();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    log.GetMethodLog("MainWindow", "dataGridView1_RowHeaderMouseClick ,Exception : " + ex.Message);
                }
                dgPassengers.DataSource = bookedPassengers;
                dgPassengers.Columns.Remove("TicketId");
            }
            log.GetMethodLog("MainWindow", "dataGridView1_RowHeaderMouseClick -Exit");

        }
        #endregion
    }
}
