using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Online_School.Exceptions;
using Online_School.Services;
using Online_School.Model;

namespace View.View
{
    public class MainCurs : Panel
    {
        private int index;
        private EnrolementServices enrolementServices;
        private CourseServices courseServices;
        private BookServices bookServices;
        private StudentServices studentServices;
        private Student_id_cardServices student_id_cardServices;
        private Form form;

        public MainCurs(int index,Form form,BookServices bookServices, CourseServices courseServices,EnrolementServices enrolementServices, StudentServices studentServices, Student_id_cardServices student_id_cardServices)
        {
            this.index = index;
            this.form = form;
            this.courseServices = courseServices;
            this.bookServices = bookServices;
            this.enrolementServices = enrolementServices;
            this.student_id_cardServices = student_id_cardServices;
            this.studentServices = studentServices;
            
            this.Click += new EventHandler(panel_Click);
            layoutPanel();
            layout();
        }
        public void panel_Click(object sender, EventArgs e)
        {
            clearPanel();
        }
        public void clearPanel()
        {
            Panel main = null;
            Panel home = null;
            Panel curs = null;
            Panel carti = null;
            foreach (Control control in this.form.Controls)
                if (control.Name == "home")
                    home = control as Panel;
            foreach (Control control in home.Controls)
                    if (control.Name == "cursP")
                    curs = control as Panel;
                else
                    if (control.Name == "cartiP")
                        carti = control as Panel;
            curs.Visible = false;
            carti.Visible = false;
        }
        public void layoutPanel()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Location = new System.Drawing.Point(0,0);
            this.Name = "main";
            this.Size = new System.Drawing.Size(814, 527);
            this.TabIndex = 4;
        }
        public void layout()
        {
            if (this.Index == 1)
                layoutInscriere();
            if (this.Index == 2)
                layoutDezabonare();
            if (this.Index == 3)
                layoutAfisare();
            layoutButtons();
        }
        public void layoutInscriere()
        {
            Label nameL = new Label();
            Label departamentL = new Label();
            TextBox nameTB = new TextBox();
            TextBox departamentTB = new TextBox();

            layoutLabelsInscriere(nameL, departamentL);
            layoutTextBoxsInscriere(nameTB, departamentTB);

            this.Controls.Add(nameL);
            this.Controls.Add(departamentL);
            this.Controls.Add(nameTB);
            this.Controls.Add(departamentTB);
        }
        public void layoutLabelsInscriere(Label name, Label departament)
        {
            name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            name.Cursor = System.Windows.Forms.Cursors.Hand;
            name.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            name.ForeColor = System.Drawing.Color.Green;
            name.Location = new System.Drawing.Point(70, 70);
            name.Name = "nameL";
            name.Size = new System.Drawing.Size(350, 50);
            name.TabIndex = 1;
            name.Text = "Introduceti numele";
            name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;


            departament.BackColor = System.Drawing.SystemColors.ControlLightLight;
            departament.Cursor = System.Windows.Forms.Cursors.Hand;
            departament.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            departament.ForeColor = System.Drawing.Color.Green;
            departament.Location = new System.Drawing.Point(70, 140);
            departament.Name = "departamentL";
            departament.Size = new System.Drawing.Size(350, 140);
            departament.TabIndex = 1;
            departament.Text = "Introduceti departamentul";
            departament.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }
        public void layoutTextBoxsInscriere(TextBox name, TextBox departament)
        {
            name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            name.Cursor = System.Windows.Forms.Cursors.Hand;
            name.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            name.ForeColor = System.Drawing.Color.Green;
            name.Location = new System.Drawing.Point(450, 80);
            name.Name = "nameT";
            name.Size = new System.Drawing.Size(250, 50);
            name.TabIndex = 1;


            departament.BackColor = System.Drawing.SystemColors.ControlLightLight;
            departament.Cursor = System.Windows.Forms.Cursors.Hand;
            departament.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            departament.ForeColor = System.Drawing.Color.Green;
            departament.Location = new System.Drawing.Point(450, 190);
            departament.Name = "departamentT";
            departament.Size = new System.Drawing.Size(250, 140);
            departament.TabIndex = 1;
        }
        public void layoutButtons()
        {
            Button adaugare = new Button();
            layoutButtonAdaugare(adaugare);
            this.Controls.Add(adaugare);
        }
        public void layoutButtonAdaugare(Button adaugare)
        {
            adaugare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            adaugare.Cursor = System.Windows.Forms.Cursors.Hand;
            adaugare.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            adaugare.ForeColor = System.Drawing.Color.Green;
            adaugare.Location = new System.Drawing.Point(280, 350);
            adaugare.Name = "adaugare";
            adaugare.Text = "Inscriere";
            adaugare.Size = new System.Drawing.Size(250, 50);
            adaugare.TabIndex = 1;
            adaugare.Click += new EventHandler(adaugare_Click);
        }
        public void adaugare_Click(object sender, EventArgs e)
        {
            clearPanel();
            try
            {
                TextBox name = new TextBox();
                TextBox departament = new TextBox();
                foreach (Control control in this.Controls)
                    if (control.Name == "nameT")
                        name = control as TextBox;
                    else
                if (control.Name == "departamentT")
                        departament = control as TextBox;
                if (name.Text == "" || departament.Text == "")
                    MessageBox.Show("Nu lasa casete necompletate");
                else
                {

                    //login terminat,  student initializat(atributa)


                    MessageBox.Show("Inscris cu succes!");
                }
            }catch(EnrolementException a)
            {
                MessageBox.Show(a.Message);
            }
        }
        public void layoutDezabonare()
        {

        }
        public void layoutAfisare()
        {

        }
        public int Index
        {
            get => this.index;
            set => this.index = value;
        }
    }
}