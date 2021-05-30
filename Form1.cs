using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBank
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientform cl = new Clientform();
            cl.Show();
            
        }

        private void conversionEUmadToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void conversionUSmadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void gestionDeviseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conversion cv = new Conversion();
            cv.Show();

        }
    }
}
