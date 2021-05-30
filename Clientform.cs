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
    public partial class Clientform : Form
    {
        public Clientform()
        {
            InitializeComponent();
        }

        private client getclient()
        {
            string nom1 = nom.Text;
            string prenom1 = prenom.Text;
            string add = address.Text;
             client cl = new client(nom1, prenom1, add);
            return cl;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nom1 = nom.Text;
            string prenom1 = prenom.Text;
            string add = address.Text;
            string connectionstring;

            SqlConnection cnn;
            SqlCommand cmd;
            SqlDataReader rd;
            string sql, output = "";
            connectionstring = @"Data Source=AYOUBX1;Integrated Security=True";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            sql = "insert into dbo.client_info values(@nom,@prenom,@addresse)";
            try
            {
                cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@nom", nom1);
                cmd.Parameters.AddWithValue("@prenom", prenom1);
                cmd.Parameters.AddWithValue("@addresse", add);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ajout du client avec succees");
            }
            catch
            {
                MessageBox.Show("erreur client non ajouter");
            }

            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
