namespace calenderdoudou
{
    partial class Employee
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
            this.label4 = new System.Windows.Forms.Label();
            this.ltemployee = new System.Windows.Forms.ListBox();
            this.lbfin5 = new System.Windows.Forms.Label();
            this.lbdebut4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbdate2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lirdv = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Liste des employee";
            // 
            // ltemployee
            // 
            this.ltemployee.ForeColor = System.Drawing.Color.Red;
            this.ltemployee.FormattingEnabled = true;
            this.ltemployee.ItemHeight = 20;
            this.ltemployee.Location = new System.Drawing.Point(200, 210);
            this.ltemployee.Name = "ltemployee";
            this.ltemployee.Size = new System.Drawing.Size(122, 164);
            this.ltemployee.TabIndex = 16;
            // 
            // lbfin5
            // 
            this.lbfin5.AutoSize = true;
            this.lbfin5.ForeColor = System.Drawing.Color.Red;
            this.lbfin5.Location = new System.Drawing.Point(606, 95);
            this.lbfin5.Name = "lbfin5";
            this.lbfin5.Size = new System.Drawing.Size(0, 20);
            this.lbfin5.TabIndex = 15;
            // 
            // lbdebut4
            // 
            this.lbdebut4.AutoSize = true;
            this.lbdebut4.ForeColor = System.Drawing.Color.Red;
            this.lbdebut4.Location = new System.Drawing.Point(606, 58);
            this.lbdebut4.Name = "lbdebut4";
            this.lbdebut4.Size = new System.Drawing.Size(0, 20);
            this.lbdebut4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Heuredefin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Heuredebut:";
            // 
            // lbdate2
            // 
            this.lbdate2.AutoSize = true;
            this.lbdate2.ForeColor = System.Drawing.Color.Red;
            this.lbdate2.Location = new System.Drawing.Point(607, 18);
            this.lbdate2.Name = "lbdate2";
            this.lbdate2.Size = new System.Drawing.Size(0, 20);
            this.lbdate2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date :";
            // 
            // lirdv
            // 
            this.lirdv.FormattingEnabled = true;
            this.lirdv.ItemHeight = 20;
            this.lirdv.Location = new System.Drawing.Point(23, 27);
            this.lirdv.Name = "lirdv";
            this.lirdv.Size = new System.Drawing.Size(140, 184);
            this.lirdv.TabIndex = 9;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ltemployee);
            this.Controls.Add(this.lbfin5);
            this.Controls.Add(this.lbdebut4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbdate2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lirdv);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ltemployee;
        private System.Windows.Forms.Label lbfin5;
        private System.Windows.Forms.Label lbdebut4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbdate2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lirdv;
    }
}