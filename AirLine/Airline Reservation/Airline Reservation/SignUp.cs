using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airline_Reservation.Model;

namespace Airline_Reservation
{
    public partial class SignUp : Form
    {
        //private  static DataSet ds = new DataSet();
        private static IList<User> users;
        private Logger log = new Logger();
        public SignUp()
        {
            InitializeComponent();
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            IsSignUpButtonEnabled();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            log.GetMethodLog("SignUp","SignUp_Load-Entered");
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = string.Empty;

            connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";
            sql = "select Usr_Id,email_Id,contact_no from users";

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                users = ds.Tables[0].AsEnumerable().Select(r => new User
                {
                    UserId = r.Field<string>("Usr_Id"),
                    email_Id = r.Field<string>("email_Id"),
                    Contact_No = r.Field<string>("contact_no")
                }).ToList();
                adapter.Dispose();
                command.Dispose();
                connection.Close(); 
                log.GetActionLog("SignUp","Loaded");
            }
            catch (Exception ex)
            {
                log.GetMethodLog("SignUp", "SignUp_Load ,Exception : " + ex.Message);
            }
            log.GetMethodLog("SignUp","SignUp_Load-Exit");
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            IsSignUpButtonEnabled();
        }

        private void txtBoxAge_TextChanged(object sender, EventArgs e)
        {
            IsSignUpButtonEnabled();
        }

        private void txtBoxEmailId_TextChanged(object sender, EventArgs e)
        {
            if (!IsValid(txtBoxEmailId.Text))
            {
                lblEmailIdError.Text = "Invalid Email Id";
                log.GetActionLog("SignUp", "Invalid Email Id: " + txtBoxEmailId.Text);
            }
            else 
            {
                if (users.FirstOrDefault().email_Id == txtBoxEmailId.Text)
                {
                    lblEmailIdError.Text = "Email Id already exists";
                    log.GetActionLog("SignUp", "Email Id already Exits:" + txtBoxEmailId.Text);
                }
                else
                {
                    lblEmailIdError.Text = string.Empty;            
                }
            }
            IsSignUpButtonEnabled();
        }

        private void txtBoxContactNo_TextChanged(object sender, EventArgs e)
        {
            if (users.FirstOrDefault().Contact_No == txtBoxContactNo.Text)
            {
                lblContactError.Text = "Contact no already exists";
                log.GetActionLog("SignUp", lblContactError.Text + " : " + txtBoxContactNo.Text);
            }
            else
            {
                lblContactError.Text = string.Empty;           
            }
            IsSignUpButtonEnabled();
        }

        private void txtBoxUserId_TextChanged(object sender, EventArgs e)
        {
            if (users.FirstOrDefault().UserId == txtBoxUserId.Text)
            {
                lblUserIdError.Text = "User Id already exists";
                log.GetActionLog("SignUp", lblUserIdError.Text + " : " + txtBoxContactNo.Text);
            }
            else
            {
                lblUserIdError.Text = string.Empty;              
            }
            IsSignUpButtonEnabled();
        }

        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxConfirmPassword.Text != txtBoxPassword.Text)
            {
                lblPasswordError.Text = "Password doesn't match";
                log.GetActionLog("SignUp", lblPasswordError.Text + " : " + txtBoxPassword.Text);
            }
            else
            {
                lblPasswordError.Text = string.Empty;
            }
            IsSignUpButtonEnabled();
        }

        private bool IsValid(string emailaddress)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailaddress);
            return match.Success;           
        }

        private void IsSignUpButtonEnabled()
        {
            if (!string.IsNullOrEmpty(txtBoxConfirmPassword.Text) &&
               !string.IsNullOrEmpty(txtBoxContactNo.Text) &&
               !string.IsNullOrEmpty(txtBoxEmailId.Text) &&
               !string.IsNullOrEmpty(txtBoxName.Text) &&
               !string.IsNullOrEmpty(txtBoxAge.Text) &&
               !string.IsNullOrEmpty(txtBoxPassword.Text) &&
               !string.IsNullOrEmpty(txtBoxUserId.Text) &&
               string.IsNullOrEmpty(lblPasswordError.Text) &&
               string.IsNullOrEmpty(lblUserIdError.Text) &&
               string.IsNullOrEmpty(lblEmailIdError.Text))
            {
                lblError.Text = string.Empty;
                btnSignUp.Enabled = true;
            }           
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            log.GetMethodLog("SignUp", "btnSignUp_Click - Entered");
            string connetionString = "Data Source=localhost;Initial Catalog=Airline;Integrated Security=SSPI;";
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_I_Users", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Usr_Id", SqlDbType.VarChar).Value = txtBoxUserId.Text;
                    cmd.Parameters.Add("@pasword", SqlDbType.VarChar).Value = txtBoxPassword.Text;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtBoxName.Text;
                    cmd.Parameters.Add("@Age", SqlDbType.Int).Value = Convert.ToInt32(txtBoxAge.Text);
                    cmd.Parameters.Add("@sex", SqlDbType.VarChar).Value = txtBoxSex.Text;
                    cmd.Parameters.Add("@email_Id", SqlDbType.VarChar).Value = txtBoxEmailId.Text;
                    cmd.Parameters.Add("@Contact_No", SqlDbType.VarChar).Value = txtBoxContactNo.Text;
                    cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = txtBoxCity.Text;
                    cmd.Parameters.Add("@UState", SqlDbType.VarChar).Value = txtBoxsState.Text;
                    cmd.Parameters.Add("@grpId", SqlDbType.VarChar).Value = "user";
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            log.GetActionLog("SignUp", "User Successfully created");
            log.GetMethodLog("SignUp", "btnSignUp_Click - Exit");



      MessageBox.Show("User Created Successfully");
      Close();
    }

         
    }
}
