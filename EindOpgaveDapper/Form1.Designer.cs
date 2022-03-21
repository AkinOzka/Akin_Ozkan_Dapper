namespace EindOpgaveDapper
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelecteerCampus = new System.Windows.Forms.ComboBox();
            this.lblSelecteerDocent = new System.Windows.Forms.Label();
            this.cmbSelecteerDocent = new System.Windows.Forms.ComboBox();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblFamilienaam = new System.Windows.Forms.Label();
            this.lblWedde = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtFamilienaam = new System.Windows.Forms.TextBox();
            this.txtWedde = new System.Windows.Forms.TextBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lblDetailsEenDocent = new System.Windows.Forms.Label();
            this.lstDetailsEenDocent = new System.Windows.Forms.ListBox();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecteer een campus:";
            // 
            // cmbSelecteerCampus
            // 
            this.cmbSelecteerCampus.FormattingEnabled = true;
            this.cmbSelecteerCampus.Location = new System.Drawing.Point(47, 56);
            this.cmbSelecteerCampus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSelecteerCampus.Name = "cmbSelecteerCampus";
            this.cmbSelecteerCampus.Size = new System.Drawing.Size(140, 21);
            this.cmbSelecteerCampus.TabIndex = 1;
            this.cmbSelecteerCampus.SelectedIndexChanged += new System.EventHandler(this.cmbSelecteerCampus_SelectedIndexChanged);
            // 
            // lblSelecteerDocent
            // 
            this.lblSelecteerDocent.AutoSize = true;
            this.lblSelecteerDocent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecteerDocent.Location = new System.Drawing.Point(43, 98);
            this.lblSelecteerDocent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecteerDocent.Name = "lblSelecteerDocent";
            this.lblSelecteerDocent.Size = new System.Drawing.Size(129, 13);
            this.lblSelecteerDocent.TabIndex = 2;
            this.lblSelecteerDocent.Text = "Selecteer een docent";
            // 
            // cmbSelecteerDocent
            // 
            this.cmbSelecteerDocent.FormattingEnabled = true;
            this.cmbSelecteerDocent.Location = new System.Drawing.Point(47, 132);
            this.cmbSelecteerDocent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSelecteerDocent.Name = "cmbSelecteerDocent";
            this.cmbSelecteerDocent.Size = new System.Drawing.Size(140, 21);
            this.cmbSelecteerDocent.TabIndex = 3;
            this.cmbSelecteerDocent.SelectedIndexChanged += new System.EventHandler(this.cmbSelecteerDocent_SelectedIndexChanged);
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoornaam.Location = new System.Drawing.Point(47, 246);
            this.lblVoornaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(63, 13);
            this.lblVoornaam.TabIndex = 4;
            this.lblVoornaam.Text = "Voornaam";
            // 
            // lblFamilienaam
            // 
            this.lblFamilienaam.AutoSize = true;
            this.lblFamilienaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilienaam.Location = new System.Drawing.Point(47, 288);
            this.lblFamilienaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFamilienaam.Name = "lblFamilienaam";
            this.lblFamilienaam.Size = new System.Drawing.Size(76, 13);
            this.lblFamilienaam.TabIndex = 5;
            this.lblFamilienaam.Text = "Familienaam";
            // 
            // lblWedde
            // 
            this.lblWedde.AutoSize = true;
            this.lblWedde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWedde.Location = new System.Drawing.Point(47, 325);
            this.lblWedde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWedde.Name = "lblWedde";
            this.lblWedde.Size = new System.Drawing.Size(47, 13);
            this.lblWedde.TabIndex = 6;
            this.lblWedde.Text = "Wedde";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(153, 246);
            this.txtVoornaam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(116, 20);
            this.txtVoornaam.TabIndex = 7;
            // 
            // txtFamilienaam
            // 
            this.txtFamilienaam.Location = new System.Drawing.Point(153, 288);
            this.txtFamilienaam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFamilienaam.Name = "txtFamilienaam";
            this.txtFamilienaam.Size = new System.Drawing.Size(116, 20);
            this.txtFamilienaam.TabIndex = 8;
            // 
            // txtWedde
            // 
            this.txtWedde.Location = new System.Drawing.Point(153, 325);
            this.txtWedde.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtWedde.Name = "txtWedde";
            this.txtWedde.Size = new System.Drawing.Size(116, 20);
            this.txtWedde.TabIndex = 9;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.Location = new System.Drawing.Point(153, 374);
            this.btnToevoegen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(117, 23);
            this.btnToevoegen.TabIndex = 10;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // lblDetailsEenDocent
            // 
            this.lblDetailsEenDocent.AutoSize = true;
            this.lblDetailsEenDocent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsEenDocent.Location = new System.Drawing.Point(590, 38);
            this.lblDetailsEenDocent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailsEenDocent.Name = "lblDetailsEenDocent";
            this.lblDetailsEenDocent.Size = new System.Drawing.Size(181, 20);
            this.lblDetailsEenDocent.TabIndex = 11;
            this.lblDetailsEenDocent.Text = "Details Een docent :";
            // 
            // lstDetailsEenDocent
            // 
            this.lstDetailsEenDocent.FormattingEnabled = true;
            this.lstDetailsEenDocent.Location = new System.Drawing.Point(595, 82);
            this.lstDetailsEenDocent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstDetailsEenDocent.Name = "lstDetailsEenDocent";
            this.lstDetailsEenDocent.Size = new System.Drawing.Size(275, 95);
            this.lstDetailsEenDocent.TabIndex = 12;
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(595, 211);
            this.btnVerwijderen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(88, 23);
            this.btnVerwijderen.TabIndex = 13;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.lstDetailsEenDocent);
            this.Controls.Add(this.lblDetailsEenDocent);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtWedde);
            this.Controls.Add(this.txtFamilienaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.lblWedde);
            this.Controls.Add(this.lblFamilienaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.cmbSelecteerDocent);
            this.Controls.Add(this.lblSelecteerDocent);
            this.Controls.Add(this.cmbSelecteerCampus);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelecteerCampus;
        private System.Windows.Forms.Label lblSelecteerDocent;
        private System.Windows.Forms.ComboBox cmbSelecteerDocent;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblFamilienaam;
        private System.Windows.Forms.Label lblWedde;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtFamilienaam;
        private System.Windows.Forms.TextBox txtWedde;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label lblDetailsEenDocent;
        private System.Windows.Forms.ListBox lstDetailsEenDocent;
        private System.Windows.Forms.Button btnVerwijderen;
    }
}

