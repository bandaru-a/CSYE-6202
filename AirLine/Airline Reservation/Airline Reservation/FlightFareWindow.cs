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
    public partial class FlightFareWindow : Form
    {
        string _flightId;
        bool _isAdmin;
        private Logger log = new Logger();
        public FlightFareWindow(string flightId , bool isAdmin)
        {
            _flightId = flightId;
            _isAdmin = isAdmin;
            InitializeComponent();
            log.GetActionLog("FlightFare Window", "Opened");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("FlightFareWindow", "button1_Click -Entered");
            DataGridViewRow row = dgFare.SelectedRows[0];

            string connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";

            using (SqlConnection con = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_U_Flight_Fare", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Flight_Id", SqlDbType.VarChar).Value = _flightId;
                    cmd.Parameters.Add("@Class", SqlDbType.VarChar).Value = row.Cells[0].Value.ToString();
                    cmd.Parameters.Add("@cost", SqlDbType.Money).Value = row.Cells[1].Value.ToString();
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                log.GetActionLog("FlightFare Window", "Fare updated");
                MessageBox.Show(string.Format("Fare details, Class Id : {0} Updated", row.Cells[0].Value.ToString()));
            }
            log.GetMethodLog("FlightFareWindow", "button1_Click -Exit");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("FlightFareWindow", "btnAdd_Click -Entered");
            if (dgFare.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dgFare.SelectedRows[0];

                string connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";

                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_I_Flight_Fare", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Flight_Id", SqlDbType.VarChar).Value = _flightId;
                        cmd.Parameters.Add("@Class", SqlDbType.VarChar).Value = row.Cells[0].Value.ToString();
                        cmd.Parameters.Add("@cost", SqlDbType.Money).Value = row.Cells[1].Value.ToString();
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show(string.Format("Fare details, Class Id : {0} Inserted", row.Cells[0].Value.ToString()));
                log.GetActionLog("FlightFare Window", "Fare inserted");
            }         
            log.GetMethodLog("FlightFareWindow", "btnAdd_Click -Exit");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("FlightFareWindow", "btnDelete_Click -Entered");
            DataGridViewRow row = dgFare.SelectedRows[0];

            string connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";

            using (SqlConnection con = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_D_Flight_Fare", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Flight_Id", SqlDbType.VarChar).Value = _flightId;
                    cmd.Parameters.Add("@Class", SqlDbType.VarChar).Value = row.Cells[0].Value.ToString();
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            int selectedIndex = dgFare.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dgFare.Rows.RemoveAt(selectedIndex);
                dgFare.Refresh(); // if needed
            }
            log.GetActionLog("FlightFare Window", "Fare deleted");
            log.GetMethodLog("FlightFareWindow", "btnDelete_Click -Exit");
        }

        private void FlightFareWindow_Load(object sender, EventArgs e)
        {
            log.GetMethodLog("FlightFareWindow", "FlightFareWindow_Load -Entered");
            if (_isAdmin)
            {
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                dgFare.AllowUserToAddRows = true;
                dgFare.AllowUserToDeleteRows = true;
            }
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = string.Empty;

            connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";
            sql = "SELECT  class, Cost from Flight_Fare where Flight_Id ='" + _flightId + "'";

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                dgFare.DataSource = ds.Tables[0];
                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                log.GetMethodLog("FlightFareWindow", "FlightFareWindow_Load ,Exception : " + ex.Message);
            }
            log.GetActionLog("FlightFare Window", "Data loaded");
            log.GetMethodLog("FlightFareWindow", "FlightFareWindow_Load -Exit");
        }

    }
}
