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
using Airline_Reservation.Model;

namespace Airline_Reservation
{
    public partial class FlightCrewWindow : Form
    {
        string _flightId;
        bool _isAdmin;
        private static IList<Crew> crew;
        private Logger log = new Logger();
        public FlightCrewWindow(string flightId, bool isAdmin)
        {
            _flightId = flightId;
            _isAdmin = isAdmin;
            InitializeComponent();
            log.GetActionLog("CrewWindow", "Opened");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("FlightCrewWindow", "button1_Click -Entered");
            if (dgCrew.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dgCrew.SelectedRows[0];

                string connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";

                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_U_Flight_Crew", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Flight_Id", SqlDbType.VarChar).Value = _flightId;
                        cmd.Parameters.Add("@Position_Id", SqlDbType.VarChar).Value = row.Cells[0].Value.ToString();
                        cmd.Parameters.Add("@Employee_Name", SqlDbType.VarChar).Value = row.Cells[1].Value.ToString();
                        cmd.Parameters.Add("@age", SqlDbType.Int).Value = row.Cells[3].Value.ToString();
                        cmd.Parameters.Add("@sex", SqlDbType.VarChar).Value = row.Cells[2].Value.ToString();
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                log.GetActionLog("Crew Window", "Crew details updated");
                MessageBox.Show(string.Format("Crew details, position Id : {0} Updated", row.Cells[0].Value.ToString()));
            }
            log.GetMethodLog("FlightCrewWindow", "button1_Click -Entered");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("FlightCrewWindow", "btnAdd_Click -Entered");
            if (dgCrew.SelectedRows.Count == 0)
            {
                dgCrew.DataSource = null;
                Crew newCrew = new Crew();
                crew.Add(newCrew);
                dgCrew.DataSource = crew;
                dgCrew.Update();
                dgCrew.Refresh();
            }
            else
            {
                DataGridViewRow row = dgCrew.SelectedRows[0];

                string connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";

                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_I_Flight_Crew", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Flight_Id", SqlDbType.VarChar).Value = _flightId;
                        cmd.Parameters.Add("@Employee_Name", SqlDbType.VarChar).Value = row.Cells[1].Value.ToString();
                        cmd.Parameters.Add("@Position_Id", SqlDbType.VarChar).Value = row.Cells[0].Value.ToString();
                        cmd.Parameters.Add("@age", SqlDbType.Int).Value = row.Cells[3].Value.ToString();
                        cmd.Parameters.Add("@sex", SqlDbType.VarChar).Value = row.Cells[2].Value.ToString();
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                log.GetActionLog("Crew Window", "Crew details instered");
                MessageBox.Show(string.Format("Crew details, position Id : {0} Insereted", row.Cells[0].Value.ToString()));
            }
            log.GetMethodLog("FlightCrewWindow", "btnAdd_Click -Exit");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("FlightCrewWindow", "btnDelete_Click -Entered");
            if (dgCrew.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dgCrew.SelectedRows[0];
                string positionId = row.Cells[0].Value.ToString();

                string connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";

                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_D_Flight_Crew", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Flight_Id", SqlDbType.VarChar).Value = _flightId;
                        cmd.Parameters.Add("@Position_Id", SqlDbType.VarChar).Value = positionId;
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                Crew deletedFlight = crew.Where(x => x.position == positionId).FirstOrDefault();

                crew.Remove(deletedFlight);
                dgCrew.DataSource = null;
                dgCrew.DataSource = crew;
                dgCrew.Update();
                dgCrew.Refresh();

                log.GetActionLog("Crew Window", "Crew details deleted");
            }
            log.GetMethodLog("FlightCrewWindow", "btnDelete_Click -Exit");
        }

        private void FlightCrewWindow_Load(object sender, EventArgs e)
        {
            log.GetMethodLog("FlightCrewWindow", "FlightCrewWindow_Load -Entered");
            if (_isAdmin)
            {
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                dgCrew.AllowUserToAddRows = true;
                dgCrew.AllowUserToDeleteRows = true;
            }
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = string.Empty;

            connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";
            sql = "SELECT Position_Id, Employee_Name, age, sex from Crew where Flight_Id ='" + _flightId + "'";

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                crew = ds.Tables[0].AsEnumerable().Select(r => new Crew
                {
                    position = r.Field<string>("Position_Id"),
                    Name = r.Field<string>("Employee_Name"),
                    Age = r.Field<int>("age"),
                    Sex = r.Field<string>("sex"),
                }).ToList();
                dgCrew.DataSource = crew;
                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                log.GetMethodLog("Crew Window", "FlightCrewWindow_Load ,Exception : " + ex.Message);
            }

            log.GetActionLog("Crew Window", "Data loaded");
            log.GetMethodLog("FlightCrewWindow", "FlightCrewWindow_Load -Exited");
        }   
    }
}
