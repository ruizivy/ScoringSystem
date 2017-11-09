namespace ScoringSystemRuizIvyrose
{
    partial class frmAddCriteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCriteria));
            this.lblcriteria = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblwarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcriteria
            // 
            this.lblcriteria.AutoSize = true;
            this.lblcriteria.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcriteria.Location = new System.Drawing.Point(15, 22);
            this.lblcriteria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblcriteria.Name = "lblcriteria";
            this.lblcriteria.Size = new System.Drawing.Size(255, 25);
            this.lblcriteria.TabIndex = 0;
            this.lblcriteria.Text = "Enter number of criteria:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(213, 53);
            this.txtNum.Margin = new System.Windows.Forms.Padding(6);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(200, 41);
            this.txtNum.TabIndex = 1;
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyDown);
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarning.ForeColor = System.Drawing.Color.Red;
            this.lblwarning.Location = new System.Drawing.Point(14, 142);
            this.lblwarning.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(434, 25);
            this.lblwarning.TabIndex = 2;
            this.lblwarning.Text = "Note: The Existing Criteria will be deleted!!";
            // 
            // frmAddCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 198);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblcriteria);
            this.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmAddCriteria";
            this.Text = "AddCriteria";
            this.Load += new System.EventHandler(this.frmAddCriteria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcriteria;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblwarning;

    }
}