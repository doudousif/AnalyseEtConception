namespace calenderdoudou
{
    partial class ModifierRendezVousForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbworkmodif = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.nameventmodif = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.endtimemodif = new System.Windows.Forms.DateTimePicker();
            this.starttimemodif = new System.Windows.Forms.DateTimePicker();
            this.dateTimemodif = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnenlever = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(226, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = " Employées ajouté a l\'évènement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(568, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(258, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Début ";
            // 
            // lbworkmodif
            // 
            this.lbworkmodif.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbworkmodif.ForeColor = System.Drawing.Color.Black;
            this.lbworkmodif.FormattingEnabled = true;
            this.lbworkmodif.ItemHeight = 20;
            this.lbworkmodif.Location = new System.Drawing.Point(276, 46);
            this.lbworkmodif.Name = "lbworkmodif";
            this.lbworkmodif.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbworkmodif.Size = new System.Drawing.Size(159, 184);
            this.lbworkmodif.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nom de Rendez-vous";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date";
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.Tomato;
            this.btnmodifier.Location = new System.Drawing.Point(727, 459);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnmodifier.Size = new System.Drawing.Size(187, 53);
            this.btnmodifier.TabIndex = 15;
            this.btnmodifier.Text = "Modifier Rendez-vous";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // nameventmodif
            // 
            this.nameventmodif.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameventmodif.Location = new System.Drawing.Point(175, 459);
            this.nameventmodif.Name = "nameventmodif";
            this.nameventmodif.Size = new System.Drawing.Size(539, 40);
            this.nameventmodif.TabIndex = 14;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(572, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(153, 184);
            this.listBox1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(104, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 25;
            // 
            // endtimemodif
            // 
            this.endtimemodif.CustomFormat = "HH:mm";
            this.endtimemodif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endtimemodif.Location = new System.Drawing.Point(637, 357);
            this.endtimemodif.Name = "endtimemodif";
            this.endtimemodif.Size = new System.Drawing.Size(70, 26);
            this.endtimemodif.TabIndex = 26;
            // 
            // starttimemodif
            // 
            this.starttimemodif.CustomFormat = "HH:mm";
            this.starttimemodif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.starttimemodif.Location = new System.Drawing.Point(323, 356);
            this.starttimemodif.Name = "starttimemodif";
            this.starttimemodif.Size = new System.Drawing.Size(70, 26);
            this.starttimemodif.TabIndex = 27;
            // 
            // dateTimemodif
            // 
            this.dateTimemodif.Location = new System.Drawing.Point(348, 289);
            this.dateTimemodif.Name = "dateTimemodif";
            this.dateTimemodif.Size = new System.Drawing.Size(294, 26);
            this.dateTimemodif.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(39, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nom de l\'évènement ";
            // 
            // btnenlever
            // 
            this.btnenlever.BackColor = System.Drawing.Color.Tomato;
            this.btnenlever.Location = new System.Drawing.Point(466, 147);
            this.btnenlever.Name = "btnenlever";
            this.btnenlever.Size = new System.Drawing.Size(75, 32);
            this.btnenlever.TabIndex = 30;
            this.btnenlever.Text = "enlever";
            this.btnenlever.UseVisualStyleBackColor = false;
            this.btnenlever.Click += new System.EventHandler(this.btnenlever_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.Tomato;
            this.btnajouter.Location = new System.Drawing.Point(466, 79);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(75, 32);
            this.btnajouter.TabIndex = 31;
            this.btnajouter.Text = "ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(555, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Liste de tout les employées";
            // 
            // ModifierRendezVousForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(934, 585);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.btnenlever);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimemodif);
            this.Controls.Add(this.starttimemodif);
            this.Controls.Add(this.endtimemodif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbworkmodif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.nameventmodif);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "ModifierRendezVousForm";
            this.Text = "ModifierRendezVousForm";
            this.Load += new System.EventHandler(this.ModifierRendezVousForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbworkmodif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.TextBox nameventmodif;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker endtimemodif;
        private System.Windows.Forms.DateTimePicker starttimemodif;
        private System.Windows.Forms.DateTimePicker dateTimemodif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnenlever;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Label label8;
    }
}