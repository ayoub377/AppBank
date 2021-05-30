using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeviseLLibraries;
     
namespace AppBank
{
    public partial class Conversion : Form
    {
        public Conversion()
        {
            InitializeComponent();
        }

        private void Conversion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private double res()
        {
            double res=0;
            string ch = choix1.Text;
            string ch2 = choix2.Text;
            string val = usd.Text;
            double val_d = Convert.ToDouble(val);
            if(ch =="MAD")
            {
                if(ch2 == "USD")
                {
                    res = val_d / 9.65;
                }
                else if(ch2 == "EURO")
                {
                    res = val_d / 10.87;
                }
            }

            else if(ch == "USD")
            {
                if(ch2 == "MAD")
                {
                    res = val_d * 9.65;
                }
                else if(ch2 =="EURO")
                {
                    res = val_d *0.82;
                }
            }

            else if( ch == "EURO")
            {
                if(ch2 == "USD")
                {
                    res = val_d * 1.22;
                }

                else if(ch2 == "MAD")
                {
                    res = val_d * 10.87;
                }
            }

            else
            {
                res = 1;
            }
            return res;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
           string m= res().ToString();
            Mad.Text = m;
        }

        private void Mad_TextChanged(object sender, EventArgs e)
        {

        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
