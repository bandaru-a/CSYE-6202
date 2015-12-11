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
    public partial class PassengersWin : Form
    {
        private string _flightId;
        private List<Passenger> passengers = new List<Passenger>();
        private Logger log = new Logger();
        public PassengersWin(string flightId)
        {
            _flightId = flightId;
            InitializeComponent();
        }

        private void PassengersWin_Load(object sender, EventArgs e)
        {
            log.GetMethodLog("PassengersWin", "PassengersWin_Load -Entered");  
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = string.Empty;

            connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";
            sql = "select P.Ticket_id, P.Passenger_name, P.age, P.sex from Passengers P "+
                   "inner join Ticket_details T on P.Ticket_Id = T.Ticket_Id "+
                   "where T.Flight_Id = '"+_flightId+"'" ;

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                passengers = ds.Tables[0].AsEnumerable().Select(r => new Passenger
                {
                    TicketId = r.Field<string>("Ticket_id"),
                    Name = r.Field<string>("Passenger_name"),
                    Age = r.Field<int>("age"),
                    Sex = r.Field<string>("sex")
                }).ToList();
                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                log.GetMethodLog("PassengersWin", "PassengersWin_Load ,Exception : " + ex.Message);
            }
            
            dgPassengers.DataSource = passengers;
            log.GetActionLog("Passengers Window", "Loaded");
            log.GetMethodLog("PassengersWin", "PassengersWin_Load -Exit"); 
        }

       
    }
}
