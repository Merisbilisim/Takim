using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGalatasaray_Click(object sender, EventArgs e)
        {
            lblTakım.Text = "Galatasaray";
            lblTakım.BackColor = Color.Red;
            lblTakım.ForeColor = Color.Yellow;
        }

        private void btnTrabzon_Click(object sender, EventArgs e)
        {
            lblTakım.Text = "Trabzonspor";
            lblTakım.BackColor = Color.Blue;
            lblTakım.ForeColor = Color.Red;
        }

        private void btnBeşiktaş_Click(object sender, EventArgs e)
        {
            lblTakım.Text = "Beşiktaş";
            lblTakım.BackColor = Color.Black;
            lblTakım.ForeColor = Color.White;
    

        }
    }
}
