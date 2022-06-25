using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data;
using System.Configuration;
using Npgsql;

namespace WebApplication3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertion_Click(object sender, EventArgs e)
        {
            try
            {
                /* Insertion After Validations*/
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksiku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Insert into employee values(@ID,@Fname,@Lname,@Email)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", Convert.ToInt32(txtEmpID.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@Fname", txtEmpFname.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Lname", txtEmpLname.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Email", txtEmpEmail.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    txtEmpEmail.Text = "";
                    txtEmpFname.Text = "";
                    txtEmpID.Text = "";
                    txtEmpLname.Text = "";
                    lblmsg.Text = "Data Has been Saved";
                }
            }
            catch (Exception ex) { }
        }

       

        protected void btnUpdation_Click(object sender, EventArgs e)
        {
            try /* Updation After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksiku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update employee set firstname=@Fname,lastname=@Lname,emailid=@Email where id=@ID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", Convert.ToInt32(txtEmpID.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@Fname", txtEmpFname.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Lname", txtEmpLname.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Email", txtEmpEmail.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    txtEmpEmail.Text = "";
                    txtEmpFname.Text = "";
                    txtEmpID.Text = "";
                    txtEmpLname.Text = "";
                    lblmsg.Text = "Data Has been Updated";

                }
            }
            catch (Exception ex) { }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try /* Deletion After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksiku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Delete from employee where id=@ID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", Convert.ToInt32(txtEmployeeID.Text)));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    txtEmployeeID.Text = "";
                    lblmessage.Text = "Data Has been Deleted";
                }
            }
            catch (Exception ex) { }
        }
    }
}