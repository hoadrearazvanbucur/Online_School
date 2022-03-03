using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View.Mockup
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.panel3.Visible = false;
            this.panel5.Visible = false;
            this.panel3.Location = new Point(509, 115);
            this.panel5.Location = new Point(657, 115);
            panel3.BringToFront();
            panel5.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label3.BackColor = SystemColors.ControlLightLight;
            label2.BackColor = Color.PaleGreen;
            label4.BackColor = SystemColors.ControlLightLight;
            panel3.Visible = false;
            panel5.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label2.BackColor = SystemColors.ControlLightLight;
            label3.BackColor = Color.PaleGreen;
            label4.BackColor = SystemColors.ControlLightLight;
            panel3.Visible = true;
            panel5.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label2.BackColor = SystemColors.ControlLightLight;
            label4.BackColor = Color.PaleGreen;
            label3.BackColor = SystemColors.ControlLightLight;
            panel3.Visible = false;
            panel5.Visible = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel5.Visible = false;
        }
    }
}
