namespace calenderdoudou
{
    partial class UserControldays
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbdays = new System.Windows.Forms.Label();
            this.lbevent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.BackColor = System.Drawing.Color.Transparent;
            this.lbdays.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdays.ForeColor = System.Drawing.Color.Transparent;
            this.lbdays.Location = new System.Drawing.Point(14, 10);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(32, 26);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            // 
            // lbevent
            // 
            this.lbevent.AutoSize = true;
            this.lbevent.BackColor = System.Drawing.Color.IndianRed;
            this.lbevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbevent.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbevent.Location = new System.Drawing.Point(37, 63);
            this.lbevent.Name = "lbevent";
            this.lbevent.Size = new System.Drawing.Size(0, 29);
            this.lbevent.TabIndex = 1;
            this.lbevent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControldays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.lbevent);
            this.Controls.Add(this.lbdays);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UserControldays";
            this.Size = new System.Drawing.Size(136, 100);
            this.Click += new System.EventHandler(this.UserControldays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdays;
        private System.Windows.Forms.Label lbevent;
        private System.Windows.Forms.Timer timer1;
    }
}
