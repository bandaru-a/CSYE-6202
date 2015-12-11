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
    public partial class LoginWindow : Form
    {
        private Logger log = new Logger();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Signin_btn_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("LoginWindow", "Signin_btn_Click - Entered");
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = string.Empty;
            errorLbl.Text = string.Empty;

            connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";
            sql = "select Usr_Id,pasword from users where usr_id = '" + userId_txtBox.Text + "'";

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                if (ds.Tables[0].Rows.Count == 0)
                {
                    errorLbl.Text = "User Doesn't exists";
                    log.GetActionLog("LoginWindow", errorLbl.Text + " : " + userId_txtBox.Text);
                }
                else if (ds.Tables[0].Rows[0].ItemArray[1].ToString() != password_txtbox.Text)
                {
                    errorLbl.Text = "Incorrect Password";
                    log.GetActionLog("LoginWindow", errorLbl.Text + " : " + password_txtbox.Text);
                }
                else 
                {
                    log.GetActionLog("LoginWindow", "user logged in successfully : " + userId_txtBox.Text);
                    MainWindow frm = new MainWindow(userId_txtBox.Text);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                log.GetMethodLog("LoginWindow", "Signin_btn_Click ,Exception : " + ex.Message);
            }
            log.GetMethodLog("LoginWindow", "Signin_btn_Click - Exist");
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            SignUp frm = new SignUp();
            frm.Show();
        }
               
    }
}
