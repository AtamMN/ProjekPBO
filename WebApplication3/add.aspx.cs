using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

using System.Data;
using System.Configuration;
using Npgsql;


namespace WebApplication3
{
    public partial class add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void tambah(object sender, EventArgs e)
        {
            try
            {

                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksiku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.film (title, description, rating) VALUES (@title, @description, @rating)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@title", t.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@description", d.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@rating", r.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();

                    t.Text = "";
                    d.Text = "";
                    r.Text = "";
                    lblmsg.Text = "Data Has been Saved";

                }
            }
            catch (Exception ex) { }


        }
    }
}