using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Online_School.Services;
using Online_School.Model;

namespace View.View
{
    public class Home_View : Form
    {
        private Panel home;
        private CourseServices courseServices;

        public Home_View()
        {
            layoutForm();
            layouts();
            this.courseServices = new CourseServices("Default");
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

            Panel cartiP = new Panel();
            layoutCartiPanel(cartiP);
            this.home.Controls.Add(cartiP);

            Panel cursP = new Panel();
            layoutCursPanel(cursP);
            this.home.Controls.Add(cursP);

            Panel main = new Panel();
            layoutMain(main);
            this.home.Controls.Add(main);
        }

        public void layoutMain(Panel main)
        {
            main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            main.Location = new System.Drawing.Point(48, 157);
            main.Name = "main";
            main.Size = new System.Drawing.Size(814, 527);
            main.TabIndex = 4;
            main.Click += new EventHandler(main_Click);
        }
        public void main_Click(object sender, EventArgs e)
        {
            Panel cartiP = null;
            Panel cursP = null;
            Panel home = null;
            foreach (Control control in this.Controls)
                if (control.Name == "home")
                    home = control as Panel;
            foreach (Control control in home.Controls)
            {
                if (control.Name == "cartiP")
                    cartiP = control as Panel;
                if (control.Name == "cursP")
                    cursP = control as Panel;
            }

            cursP.Visible = false;
            cartiP.Visible = false;
        }
        public void home_Click(object sender, EventArgs e)
        {
            Panel cartiP = null;
            Panel cursP = null;
            Panel home = null;
            foreach (Control control in this.Controls)
                if (control.Name == "home")
                    home = control as Panel;
            foreach (Control control in home.Controls)
            {
                if (control.Name == "cartiP")
                    cartiP = control as Panel;
                if (control.Name == "cursP")
                    cursP = control as Panel;
            }

            cursP.Visible = false;
            cartiP.Visible = false;
        }
        public void layoutCartiPanel(Panel cartiP)
        {
            cartiP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            cartiP.Location = new System.Drawing.Point(509, 135);
            cartiP.Name = "cartiP";
            cartiP.Size = new System.Drawing.Size(196, 154);
            cartiP.TabIndex = 3;
            cartiP.Visible = false;
            cartiP.BringToFront();
            cartiP.BackColor = SystemColors.ControlLightLight;

            Label adaugare = new Label();
            Label stergere = new Label();
            Label afisare = new Label();
            layoutButtonsCarti(adaugare, stergere, afisare);
            cartiP.Controls.Add(adaugare);
            cartiP.Controls.Add(stergere);
            cartiP.Controls.Add(afisare);

        }
        public void layoutButtonsCarti(Label adaugare, Label stergere, Label afisare)
        {
            afisare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            afisare.Cursor = System.Windows.Forms.Cursors.Hand;
            afisare.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            afisare.ForeColor = System.Drawing.Color.Green;
            afisare.Location = new System.Drawing.Point(-1, 108);
            afisare.Name = "label9";
            afisare.Size = new System.Drawing.Size(196, 46);
            afisare.TabIndex = 1;
            afisare.Text = "*     Afisare";
            afisare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            afisare.Click += new EventHandler(afisareCarti_Click);


            stergere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            stergere.Cursor = System.Windows.Forms.Cursors.Hand;
            stergere.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            stergere.ForeColor = System.Drawing.Color.Green;
            stergere.Location = new System.Drawing.Point(-1, 53);
            stergere.Name = "label8";
            stergere.Size = new System.Drawing.Size(196, 46);
            stergere.TabIndex = 1;
            stergere.Text = "-      Stergere";
            stergere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            stergere.Click += new EventHandler(stergere_Click);


            adaugare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            adaugare.Cursor = System.Windows.Forms.Cursors.Hand;
            adaugare.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            adaugare.ForeColor = System.Drawing.Color.Green;
            adaugare.Location = new System.Drawing.Point(-1, -1);
            adaugare.Name = "label7";
            adaugare.Size = new System.Drawing.Size(196, 46);
            adaugare.TabIndex = 1;
            adaugare.Text = "+     Adaugare";
            adaugare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            adaugare.Click += new EventHandler(adaugare_Click);
        }
        public void layoutCursPanel(Panel cursP)
        {
            cursP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            cursP.Location = new System.Drawing.Point(657, 135);
            cursP.Name = "cursP";
            cursP.Size = new System.Drawing.Size(196, 154);
            cursP.TabIndex = 3;
            cursP.Visible = false;
            cursP.BackColor = SystemColors.ControlLightLight;
            cursP.BringToFront();

            Label inscriere= new Label();
            Label dezabonare= new Label();
            Label afisare= new Label();
            layoutButtonsCurs(inscriere, dezabonare, afisare);
            cursP.Controls.Add(inscriere);
            cursP.Controls.Add(dezabonare);
            cursP.Controls.Add(afisare);
        }
        public void layoutButtonsCurs(Label inscriere,Label dezabonare,Label afisare)
        {
            afisare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            afisare.Cursor = System.Windows.Forms.Cursors.Hand;
            afisare.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            afisare.ForeColor = System.Drawing.Color.Green;
            afisare.Location = new System.Drawing.Point(-1, 108);
            afisare.Name = "label10";
            afisare.Size = new System.Drawing.Size(196, 46);
            afisare.TabIndex = 1;
            afisare.Text = "*     Afisare";
            afisare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            afisare.Click += new EventHandler(afisareCurs_Click);

            dezabonare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dezabonare.Cursor = System.Windows.Forms.Cursors.Hand;
            dezabonare.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dezabonare.ForeColor = System.Drawing.Color.Green;
            dezabonare.Location = new System.Drawing.Point(-1, 53);
            dezabonare.Name = "label11";
            dezabonare.Size = new System.Drawing.Size(196, 46);
            dezabonare.TabIndex = 1;
            dezabonare.Text = "-      Dezabonare";
            dezabonare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            dezabonare.Click += new EventHandler(dezabonare_Click);


            inscriere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            inscriere.Cursor = System.Windows.Forms.Cursors.Hand;
            inscriere.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            inscriere.ForeColor = System.Drawing.Color.Green;
            inscriere.Location = new System.Drawing.Point(-1, -1);
            inscriere.Name = "label12";
            inscriere.Size = new System.Drawing.Size(196, 46);
            inscriere.TabIndex = 1;
            inscriere.Text = "+     Inscriere";
            inscriere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            inscriere.Click += new EventHandler(inscriere_Click);
        }
        public void layoutHome()
        {
            home.BackColor = System.Drawing.SystemColors.ControlLightLight;
            home.Location = new System.Drawing.Point(12, 12);
            home.Size = new System.Drawing.Size(926, 726);
            home.Name = "home";
            home.TabIndex = 0;
            home.Click += new EventHandler(home_Click);
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
            acasa.Name = "acasaL";
            acasa.Size = new System.Drawing.Size(99, 58);
            acasa.TabIndex = 1;
            acasa.Text = "Acasa";
            acasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            acasa.Click += new EventHandler(acasa_Click);
        }
        public void acasa_Click(object sender , EventArgs e)
        {
            Label acasaL= null;
            Label cartiL= null;
            Label cursL= null;
            Panel cartiP= null;
            Panel cursP= null;
            Panel home = null;
            foreach(Control control in this.Controls)
                if (control.Name == "home")
                    home = control as Panel;
            foreach(Control control in home.Controls)
            {
                if (control.Name == "acasaL")
                    acasaL = control as Label;
                if (control.Name == "cartiL")
                    cartiL = control as Label;
                if (control.Name == "cursL")
                    cursL = control as Label;
                if (control.Name == "cartiP")
                    cartiP = control as Panel;
                if (control.Name == "cursP")
                    cursP = control as Panel;
            }

            acasaL.BackColor = Color.PaleGreen;
            cartiL.BackColor = SystemColors.ControlLightLight; 
            cursL.BackColor = SystemColors.ControlLightLight;
            cursP.Visible = false;
            cartiP.Visible = false;
        }
        public void carti_Click(object sender, EventArgs e)
        {
            Label acasaL = null;
            Label cartiL = null;
            Label cursL = null;
            Panel cartiP = null;
            Panel cursP = null;
            Panel home = null;
            foreach (Control control in this.Controls)
                if (control.Name == "home")
                    home = control as Panel;
            foreach (Control control in home.Controls)
            {
                if (control.Name == "acasaL")
                    acasaL = control as Label;
                if (control.Name == "cartiL")
                    cartiL = control as Label;
                if (control.Name == "cursL")
                    cursL = control as Label;
                if (control.Name == "cartiP")
                    cartiP = control as Panel;
                if (control.Name == "cursP")
                    cursP = control as Panel;
            }

            cartiL.BackColor = Color.PaleGreen;
            acasaL.BackColor = SystemColors.ControlLightLight;
            cursL.BackColor = SystemColors.ControlLightLight;
            cursP.Visible = false;
            cartiP.Visible = true;
        }
        public void curs_Click(object sender, EventArgs e)
        {
            Label acasaL = null;
            Label cartiL = null;
            Label cursL = null;
            Panel cartiP = null;
            Panel cursP = null;
            Panel home = null;
            foreach (Control control in this.Controls)
                if (control.Name == "home")
                    home = control as Panel;
            foreach (Control control in home.Controls)
            {
                if (control.Name == "acasaL")
                    acasaL = control as Label;
                if (control.Name == "cartiL")
                    cartiL = control as Label;
                if (control.Name == "cursL")
                    cursL = control as Label;
                if (control.Name == "cartiP")
                    cartiP = control as Panel;
                if (control.Name == "cursP")
                    cursP = control as Panel;
            }

            cursL.BackColor = Color.PaleGreen;
            cartiL.BackColor = SystemColors.ControlLightLight;
            acasaL.BackColor = SystemColors.ControlLightLight;
            cursP.Visible = true;
            cartiP.Visible = false;
        }
        public void layoutCarti(Label carti)
        {
            carti.Cursor = System.Windows.Forms.Cursors.Hand;
            carti.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            carti.ForeColor = System.Drawing.Color.Green;
            carti.Location = new System.Drawing.Point(509, 52);
            carti.Name = "cartiL";
            carti.Size = new System.Drawing.Size(142, 58);
            carti.TabIndex = 1;
            carti.Text = "Carti";
            carti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            carti.Click += new EventHandler(carti_Click);
        }
        public void layoutCursuri(Label cursuri)
        {
            cursuri.Cursor = System.Windows.Forms.Cursors.Hand;
            cursuri.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cursuri.ForeColor = System.Drawing.Color.Green;
            cursuri.Location = new System.Drawing.Point(657, 52);
            cursuri.Name = "cursL";
            cursuri.Size = new System.Drawing.Size(122, 58);
            cursuri.TabIndex = 1;
            cursuri.Text = "Cursuri";
            cursuri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cursuri.Click += new EventHandler(curs_Click);
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
            inregistrare.Click += new EventHandler(inregistrare_Click);
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
            logare.Click += new EventHandler(logare_Click);
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
            exit.Click += new EventHandler(exit_Click);
        }
        public void exit_Click(object sender,EventArgs e)
        {
            Application.Exit();
        }
        public void inregistrare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inregistrare");
        }
        public void logare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logare");
        }
        public void adaugare_Click(object sender, EventArgs e)
        {

        }
        public void stergere_Click(object sender, EventArgs e)
        {

        }
        public void inscriere_Click(object sender, EventArgs e)
        {
            this.courseServices.create(new Course("TEST", "TEST"));
            MessageBox.Show("Adaugat cu succes!");
        }
        public void dezabonare_Click(object sender, EventArgs e)
        {
            this.courseServices.deleteByName("TEST");
            MessageBox.Show("Sters cu succes!");
        }

        public void afisareCurs_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach (Course curs in this.courseServices.lista())
                text += curs.ToString()+"\n";
            MessageBox.Show(text);
        }
        public void afisareCarti_Click(object sender, EventArgs e)
        {

        }

    }
}
