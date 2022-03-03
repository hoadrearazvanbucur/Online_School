using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace View.View
{
    public class Home_View : Form
    {
        private Panel home;

        public Home_View()
        {
            layoutForm();
            layouts();
        }

        public void layoutForm()
        {
            this.BackColor = Color.Green;
            this.Size = new Size(950, 750);
            this.StartPosition = FormStartPosition.Manual;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - 475;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - 375;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public void layouts()
        {
            this.home = new Panel();
            layoutHome();
            this.Controls.Add(home);

            Label logo = new Label();
            layoutLogo(logo);
            this.home.Controls.Add(logo);

            Panel bar = new Panel();
            layoutBar(bar);
            this.home.Controls.Add(bar);

            Label acasa = new Label();
            layoutAcasa(acasa);
            this.home.Controls.Add(acasa);

            Label carti = new Label();
            layoutCarti(carti);
            this.home.Controls.Add(carti);

            Label cursuri = new Label();
            layoutCursuri(cursuri);
            this.home.Controls.Add(cursuri);

            Label inregistrare = new Label();
            layoutInregistrare(inregistrare);
            this.home.Controls.Add(inregistrare);

            Label logare = new Label();
            layoutLogare(logare);
            this.home.Controls.Add(logare);

            Button exit = new Button();
            layoutExit(exit);
            this.home.Controls.Add(exit);


        }

        public void layoutHome()
        {
            home.BackColor = System.Drawing.SystemColors.ControlLightLight;
            home.Location = new System.Drawing.Point(12, 12);
            home.Size = new System.Drawing.Size(926, 726);
            home.TabIndex = 0;
        }
        public void layoutLogo(Label logo)
        {
            logo.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            logo.ForeColor = System.Drawing.Color.Green;
            logo.Location = new System.Drawing.Point(32, 38);
            logo.Name = "label1";
            logo.Size = new System.Drawing.Size(259, 64);
            logo.TabIndex = 1;
            logo.Text = "Scoala Online";
            logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        public void layoutBar(Panel bar)
        {
            bar.BackColor = System.Drawing.Color.Green;
            bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            bar.Location = new System.Drawing.Point(48, 119);
            bar.Size = new System.Drawing.Size(814, 6);
            bar.TabIndex = 0;
        }
        public void layoutAcasa(Label acasa)
        {
            acasa.BackColor = System.Drawing.Color.PaleGreen;
            acasa.Cursor = System.Windows.Forms.Cursors.Hand;
            acasa.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            acasa.ForeColor = System.Drawing.Color.Green;
            acasa.Location = new System.Drawing.Point(386, 52);
            acasa.Name = "label2";
            acasa.Size = new System.Drawing.Size(99, 58);
            acasa.TabIndex = 1;
            acasa.Text = "Acasa";
            acasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        public void layoutCarti(Label carti)
        {
            carti.Cursor = System.Windows.Forms.Cursors.Hand;
            carti.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            carti.ForeColor = System.Drawing.Color.Green;
            carti.Location = new System.Drawing.Point(509, 52);
            carti.Name = "label3";
            carti.Size = new System.Drawing.Size(142, 58);
            carti.TabIndex = 1;
            carti.Text = "Carti";
            carti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        public void layoutCursuri(Label cursuri)
        {
            cursuri.Cursor = System.Windows.Forms.Cursors.Hand;
            cursuri.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cursuri.ForeColor = System.Drawing.Color.Green;
            cursuri.Location = new System.Drawing.Point(657, 52);
            cursuri.Name = "label4";
            cursuri.Size = new System.Drawing.Size(122, 58);
            cursuri.TabIndex = 1;
            cursuri.Text = "Cursuri";
            cursuri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        public void layoutInregistrare(Label inregistrare)
        {
            inregistrare.BackColor = System.Drawing.Color.PaleGreen;
            inregistrare.Cursor = System.Windows.Forms.Cursors.Hand;
            inregistrare.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            inregistrare.ForeColor = System.Drawing.Color.Green;
            inregistrare.Location = new System.Drawing.Point(592, 10);
            inregistrare.Name = "label6";
            inregistrare.Size = new System.Drawing.Size(142, 26);
            inregistrare.TabIndex = 1;
            inregistrare.Text = "Inregistrare";
            inregistrare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        public void layoutLogare(Label logare)
        {
            logare.BackColor = System.Drawing.Color.PaleGreen;
            logare.Cursor = System.Windows.Forms.Cursors.Hand;
            logare.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            logare.ForeColor = System.Drawing.Color.Green;
            logare.Location = new System.Drawing.Point(740, 10);
            logare.Name = "label5";
            logare.Size = new System.Drawing.Size(97, 26);
            logare.TabIndex = 1;
            logare.Text = "Logare";
            logare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        public void layoutExit(Button exit)
        {
            exit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            exit.ForeColor = System.Drawing.Color.Red;
            exit.Location = new System.Drawing.Point(872, 10);
            exit.Name = "button1";
            exit.Size = new System.Drawing.Size(45, 37);
            exit.TabIndex = 2;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = true;
        }
        


    }
}
