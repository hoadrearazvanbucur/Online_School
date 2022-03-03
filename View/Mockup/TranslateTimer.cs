using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View.Mockup
{
    public partial class TranslateTimer : Form
    {
        public TranslateTimer()
        {
            InitializeComponent();
            //label1.BackColor = Color.Transparent;
            //label2.BackColor = Color.Transparent;
            //label1.Parent = label2;
            //start();

            Control control = label1.Parent;

            control.BackColor = Color.PaleGreen;
        }

        public void start()
        {
            LblCarti.Parent = LblAcasa;
            LblCursuri.Parent = LblAcasa;
            LblAcasa.BringToFront();
            LblCarti.Location = LblAcasa.Location;
            LblCursuri.Location = LblAcasa.Location;
        }

        private void LblAcasa_Click(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            timer1.Interval = 10;
            timer1.Start();
            timer1.Tick += new EventHandler(timer_Tick);

        }

        public void timer_Tick(object sender, EventArgs e)
        {
            //200, 106
            //200, 156
            if(LblCarti.Height != 106)
                LblCarti.Location = new Point(200, LblCarti.Height++);
            if (LblCursuri.Height != 156)
                LblCursuri.Location = new Point(200, LblCursuri.Height++);
        }

        private void LblCarti_Click(object sender, EventArgs e)
        {

        }

        private void LblCursuri_Click(object sender, EventArgs e)
        {

        }

        private void TranslateTimer_Load(object sender, EventArgs e)
        {

        }

    
    }
}
