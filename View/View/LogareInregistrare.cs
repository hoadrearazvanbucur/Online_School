using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Online_School.Services;
using Online_School.Exceptions;
using Online_School.Model;

namespace View.View
{
    public class LogareInregistrare : Panel
    {
        private EnrolementServices enrolementServices;
        private CourseServices courseServices;
        private BookServices bookServices;
        private StudentServices studentServices;
        private Student_id_cardServices student_id_cardServices;
        private Student student;
        private Home_View home_view;
        private Form form;

        public LogareInregistrare(int index, Form form, BookServices bookServices, CourseServices courseServices, EnrolementServices enrolementServices, StudentServices studentServices, Student_id_cardServices student_id_cardServices,Home_View home_view)
        {
            this.form = form;
            this.courseServices = courseServices;
            this.bookServices = bookServices;
            this.enrolementServices = enrolementServices;
            this.student_id_cardServices = student_id_cardServices;
            this.studentServices = studentServices;
            this.student = null;
            this.home_view = home_view;

            this.Click += new EventHandler(panel_Click);
            layoutPanel();
            if (index == 1)
                layout();
            else
                layoutInregistrare();

        }
        public void panel_Click(object sender, EventArgs e)
        {
            clearPanel();
        }
        public void clearPanel()
        {
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
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "main";
            this.Size = new System.Drawing.Size(814, 527);
            this.TabIndex = 4;
        }
        public void layout()
        {
            Label nameL = new Label();
            Label passwordL = new Label();
            TextBox nameTB = new TextBox();
            TextBox passwordTB = new TextBox();

            layoutLabelsLogare(nameL, passwordL);
            layoutTextBoxsLogare(nameTB, passwordTB);

            this.Controls.Add(nameL);
            this.Controls.Add(passwordL);
            this.Controls.Add(nameTB);
            this.Controls.Add(passwordTB);

            Button adaugare = new Button();
            layoutButtonLogare(adaugare);
            this.Controls.Add(adaugare);
        }
        public void layoutLabelsLogare(Label name, Label password)
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


            password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            password.Cursor = System.Windows.Forms.Cursors.Hand;
            password.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            password.ForeColor = System.Drawing.Color.Green;
            password.Location = new System.Drawing.Point(70, 140);
            password.Name = "departamentL";
            password.Size = new System.Drawing.Size(350, 140);
            password.TabIndex = 1;
            password.Text = "Introduceti parola";
            password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }
        public void layoutTextBoxsLogare(TextBox name, TextBox password)
        {
            name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            name.Cursor = System.Windows.Forms.Cursors.Hand;
            name.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            name.ForeColor = System.Drawing.Color.Green;
            name.Location = new System.Drawing.Point(450, 80);
            name.Name = "nameT";
            name.Size = new System.Drawing.Size(250, 50);
            name.TabIndex = 1;


            password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            password.Cursor = System.Windows.Forms.Cursors.Hand;
            password.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            password.ForeColor = System.Drawing.Color.Green;
            password.Location = new System.Drawing.Point(450, 190);
            password.Name = "passwordT";
            password.Size = new System.Drawing.Size(250, 140);
            password.TabIndex = 1;
        }
        public void layoutButtonLogare(Button logare)
        {
            logare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            logare.Cursor = System.Windows.Forms.Cursors.Hand;
            logare.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            logare.ForeColor = System.Drawing.Color.Green;
            logare.Location = new System.Drawing.Point(280, 350);
            logare.Name = "logare";
            logare.Text = "Logare";
            logare.Size = new System.Drawing.Size(250, 50);
            logare.TabIndex = 1;
            logare.Click += new EventHandler(logare_Click);
        }
        public void logare_Click(object sender, EventArgs e)
        {
            clearPanel();
            TextBox name = new TextBox();
            TextBox password = new TextBox();
            foreach (Control control in this.Controls)
                if (control.Name == "nameT")
                    name = control as TextBox;
                else
            if (control.Name == "passwordT")
                    password = control as TextBox;
            if (name.Text == "" || password.Text == "")
                MessageBox.Show("Nu lasa casete necompletate");
            else
            if (this.studentServices.exist(name.Text, password.Text))
            {
                this.Controls.Clear();
                Panel home = null;
                Label logareL = null;
                Label inregistrareL = null;
                foreach (Control control in this.form.Controls)
                    if (control.Name == "home")
                        home = control as Panel;
                foreach (Control control in home.Controls)
                    if (control.Name == "logare")
                        logareL = control as Label;
                    else
                        if (control.Name == "inregistrare")
                        inregistrareL = control as Label;
                logareL.Text = "Delogare";
                this.student = new Student(
                    this.studentServices.studentLogare(name.Text, password.Text).Id,
                    this.studentServices.studentLogare(name.Text, password.Text).Age,
                    this.studentServices.studentLogare(name.Text, password.Text).First_name,
                    this.studentServices.studentLogare(name.Text, password.Text).Last_name,
                    this.studentServices.studentLogare(name.Text, password.Text).Email
                    );
                inregistrareL.Text = this.Student.First_name;
                this.home_view.setGetStudent = this.student;
                MessageBox.Show("Logat cu succes!");
            }
            else
                MessageBox.Show("Acest cont nu exista!");
        }

        public void layoutInregistrare()
        {
            Label first_nameL = new Label();
            Label  last_nameL= new Label();
            Label  emailL= new Label();
            Label  ageL= new Label();
            TextBox first_nameTB = new TextBox();
            TextBox  last_nameTB= new TextBox();
            TextBox emailTB= new TextBox();
            TextBox  ageTB= new TextBox();

            layoutLabelsInregistrare(first_nameL, last_nameL,  emailL, ageL);
            layoutTextBoxsInregistrare( first_nameTB,  last_nameTB,  emailTB,  ageTB);

            this.Controls.Add(first_nameL);
            this.Controls.Add(last_nameL);
            this.Controls.Add(ageL);
            this.Controls.Add(emailL);
            this.Controls.Add(emailTB);
            this.Controls.Add(ageTB);
            this.Controls.Add(first_nameTB);
            this.Controls.Add(last_nameTB);

            Button adaugare = new Button();
            layoutButtonInregistrare(adaugare);
            this.Controls.Add(adaugare);
        }
        public void layoutLabelsInregistrare(Label first_name, Label last_name,Label email,Label age)
        {
            first_name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            first_name.Cursor = System.Windows.Forms.Cursors.Hand;
            first_name.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            first_name.ForeColor = System.Drawing.Color.Green;
            first_name.Location = new System.Drawing.Point(70, 30);
            first_name.Name = "";
            first_name.Size = new System.Drawing.Size(350, 50);
            first_name.TabIndex = 1;
            first_name.Text = "Introduceti numele";
            first_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            last_name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            last_name.Cursor = System.Windows.Forms.Cursors.Hand;
            last_name.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            last_name.ForeColor = System.Drawing.Color.Green;
            last_name.Location = new System.Drawing.Point(70, 100);
            last_name.Name = "";
            last_name.Size = new System.Drawing.Size(350, 50);
            last_name.TabIndex = 1;
            last_name.Text = "Introduceti prenumele";
            last_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            email.Cursor = System.Windows.Forms.Cursors.Hand;
            email.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            email.ForeColor = System.Drawing.Color.Green;
            email.Location = new System.Drawing.Point(70, 170);
            email.Name = "";
            email.Size = new System.Drawing.Size(350, 50);
            email.TabIndex = 1;
            email.Text = "Introduceti e-mail-ul";
            email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            age.BackColor = System.Drawing.SystemColors.ControlLightLight;
            age.Cursor = System.Windows.Forms.Cursors.Hand;
            age.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            age.ForeColor = System.Drawing.Color.Green;
            age.Location = new System.Drawing.Point(70, 240);
            age.Name = "";
            age.Size = new System.Drawing.Size(350, 50);
            age.TabIndex = 1;
            age.Text = "Introduceti varsta";
            age.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }
        public void layoutTextBoxsInregistrare(TextBox first_name, TextBox last_name, TextBox email, TextBox age)
        {
            first_name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            first_name.Cursor = System.Windows.Forms.Cursors.Hand;
            first_name.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            first_name.ForeColor = System.Drawing.Color.Green;
            first_name.Location = new System.Drawing.Point(450, 40);
            first_name.Name = "first_name";
            first_name.Size = new System.Drawing.Size(250, 50);
            first_name.TabIndex = 1;

            last_name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            last_name.Cursor = System.Windows.Forms.Cursors.Hand;
            last_name.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            last_name.ForeColor = System.Drawing.Color.Green;
            last_name.Location = new System.Drawing.Point(450,110);
            last_name.Name = "last_name";
            last_name.Size = new System.Drawing.Size(250, 50);
            last_name.TabIndex = 1;

            email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            email.Cursor = System.Windows.Forms.Cursors.Hand;
            email.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            email.ForeColor = System.Drawing.Color.Green;
            email.Location = new System.Drawing.Point(450, 180);
            email.Name = "email";
            email.Size = new System.Drawing.Size(250, 50);
            email.TabIndex = 1;

            age.BackColor = System.Drawing.SystemColors.ControlLightLight;
            age.Cursor = System.Windows.Forms.Cursors.Hand;
            age.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            age.ForeColor = System.Drawing.Color.Green;
            age.Location = new System.Drawing.Point(450,250 );
            age.Name = "age";
            age.Size = new System.Drawing.Size(250, 50);
            age.TabIndex = 1;
        }
        public void layoutButtonInregistrare(Button inregistrare)
        {
            inregistrare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            inregistrare.Cursor = System.Windows.Forms.Cursors.Hand;
            inregistrare.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            inregistrare.ForeColor = System.Drawing.Color.Green;
            inregistrare.Location = new System.Drawing.Point(280, 350);
            inregistrare.Name = "inregistrareButton";
            inregistrare.Text = "Inregistrare";
            inregistrare.Size = new System.Drawing.Size(250, 50);
            inregistrare.TabIndex = 1;
            inregistrare.Click += new EventHandler(inregistrare_Click);
        }
        public void inregistrare_Click(object sender, EventArgs e)
        {
            clearPanel();
            TextBox first_name = new TextBox();
            TextBox last_name = new TextBox();
            TextBox age = new TextBox();
            TextBox email = new TextBox();
            foreach (Control control in this.Controls)
                if (control.Name == "first_name")
                    first_name = control as TextBox;
                else
                if (control.Name == "last_name")
                    last_name = control as TextBox;
                else
                if (control.Name == "age")
                    age = control as TextBox;
                else
                if (control.Name == "email")
                    email = control as TextBox;

            if (first_name.Text == "" || last_name.Text == "" || age.Text == "" || email.Text == "")
                MessageBox.Show("Nu lasa casete necompletate");
            else
            if (!this.studentServices.exist(first_name.Text, last_name.Text, email.Text, int.Parse(age.Text)))
            {
                this.Controls.Clear();
                Panel home = null;
                Label logareL = null;
                Label inregistrareL = null;
                foreach (Control control in this.form.Controls)
                    if (control.Name == "home")
                        home = control as Panel;
                foreach (Control control in home.Controls)
                    if (control.Name == "logare")
                        logareL = control as Label;
                    else
                        if (control.Name == "inregistrare")
                        inregistrareL = control as Label;
                logareL.Text = "Delogare";
                this.student = new Student(int.Parse(age.Text),first_name.Text, last_name.Text, email.Text);
                this.studentServices.create(Student);
                inregistrareL.Text = this.Student.First_name;
                this.home_view.setGetStudent = this.student;


                MessageBox.Show("Inregistrat cu succes!");
            }
            else
                MessageBox.Show("Acest cont exista deja!");
        }
        public Student Student
        {
            get => this.student;
            set => this.student = value;
        }
    }
}