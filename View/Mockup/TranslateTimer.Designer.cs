namespace View.Mockup
{
    partial class TranslateTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblAcasa = new System.Windows.Forms.Label();
            this.LblCursuri = new System.Windows.Forms.Label();
            this.LblCarti = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblAcasa
            // 
            this.LblAcasa.BackColor = System.Drawing.Color.Transparent;
            this.LblAcasa.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAcasa.ForeColor = System.Drawing.Color.Green;
            this.LblAcasa.Location = new System.Drawing.Point(200, 56);
            this.LblAcasa.Name = "LblAcasa";
            this.LblAcasa.Size = new System.Drawing.Size(100, 50);
            this.LblAcasa.TabIndex = 0;
            this.LblAcasa.Text = "Acasa";
            this.LblAcasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAcasa.Click += new System.EventHandler(this.LblAcasa_Click);
            // 
            // LblCursuri
            // 
            this.LblCursuri.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCursuri.ForeColor = System.Drawing.Color.Green;
            this.LblCursuri.Location = new System.Drawing.Point(200, 156);
            this.LblCursuri.Name = "LblCursuri";
            this.LblCursuri.Size = new System.Drawing.Size(100, 50);
            this.LblCursuri.TabIndex = 0;
            this.LblCursuri.Text = "Cursuri";
            this.LblCursuri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCursuri.Click += new System.EventHandler(this.LblCursuri_Click);
            // 
            // LblCarti
            // 
            this.LblCarti.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCarti.ForeColor = System.Drawing.Color.Green;
            this.LblCarti.Location = new System.Drawing.Point(200, 106);
            this.LblCarti.Name = "LblCarti";
            this.LblCarti.Size = new System.Drawing.Size(100, 50);
            this.LblCarti.TabIndex = 0;
            this.LblCarti.Text = "Carti";
            this.LblCarti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCarti.Click += new System.EventHandler(this.LblCarti_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(29, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acasa1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.LblAcasa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(372, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 50);
            this.panel1.TabIndex = 1;
            // 
            // TranslateTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblCarti);
            this.Controls.Add(this.LblCursuri);
            this.Controls.Add(this.LblAcasa);
            this.Name = "TranslateTimer";
            this.Text = "TranslateTimer";
            this.Load += new System.EventHandler(this.TranslateTimer_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblAcasa;
        private System.Windows.Forms.Label LblCursuri;
        private System.Windows.Forms.Label LblCarti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}