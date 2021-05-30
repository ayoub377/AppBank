using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

    namespace AppBank
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void connexion_Click(object sender, EventArgs e)
        {
            
            string connectionstring;
            SqlConnection cnn;
            SqlCommand cmd;
            SqlDataReader rd;
            string sql, output = "";
            connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            sql = "select Id,login from AppBank.dbo.clients";
            
            cmd = new SqlCommand(sql, cnn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                output = rd.GetValue(0) + " " + rd.GetValue(1);
               
            }

          

            cnn.Close();


        }

       
        private void log_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
