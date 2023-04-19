namespace calenderdoudou
{
    partial class rendezvous
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
            this.txdate = new System.Windows.Forms.TextBox();
            this.txevent = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWorkers = new System.Windows.Forms.ListBox();
            this.starttime = new System.Windows.Forms.DateTimePicker();
            this.endtime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txdate
            // 
            this.txdate.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txdate.Location = new System.Drawing.Point(80, 321);
            this.txdate.Name = "txdate";
            this.txdate.Size = new System.Drawing.Size(450, 40);
            this.txdate.TabIndex = 0;
            // 
            // txevent
            // 
            this.txevent.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txevent.Location = new System.Drawing.Point(79, 499);
            this.txevent.Name = "txevent";
            this.txevent.Size = new System.Drawing.Size(450, 40);
            this.txevent.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Tomato;
            this.btnsave.Location = new System.Drawing.Point(231, 560);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(143, 52);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Ajouter Rendez-vous";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(275, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(212, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom de Rendez-vous";
            // 
            // lbWorkers
            // 
            this.lbWorkers.FormattingEnabled = true;
            this.lbWorkers.ItemHeight = 20;
            this.lbWorkers.Location = new System.Drawing.Point(203, 88);
            this.lbWorkers.Name = "lbWorkers";
            this.lbWorkers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbWorkers.Size = new System.Drawing.Size(187, 184);
            this.lbWorkers.TabIndex = 5;
            // 
            // starttime
            // 
            this.starttime.CustomFormat = "HH:mm";
            this.starttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.starttime.Location = new System.Drawing.Point(196, 399);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(70, 26);
            this.starttime.TabIndex = 8;
            // 
            // endtime
            // 
            this.endtime.CustomFormat = "HH:mm  ";
            this.endtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endtime.Location = new System.Drawing.Point(426, 398);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(70, 26);
            this.endtime.TabIndex = 9;
            this.endtime.Value = new System.DateTime(2023, 4, 14, 22, 25, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(104, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Début ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(359, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(221, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Liste des employées";
            // 
            // rendezvous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(607, 658);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endtime);
            this.Controls.Add(this.starttime);
            this.Controls.Add(this.lbWorkers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txevent);
            this.Controls.Add(this.txdate);
            this.Name = "rendezvous";
            this.Text = "rendezvous";
            this.Load += new System.EventHandler(this.rendezvous_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txdate;
        private System.Windows.Forms.TextBox txevent;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbWorkers;
        private System.Windows.Forms.DateTimePicker starttime;
        private System.Windows.Forms.DateTimePicker endtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}