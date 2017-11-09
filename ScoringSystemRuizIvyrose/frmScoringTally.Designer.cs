namespace ScoringSystemRuizIvyrose
{
    partial class frmSoringTally
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoringTally));
            this.lstScores = new System.Windows.Forms.ListView();
            this.lblJudge = new System.Windows.Forms.Label();
            this.cmbJudge = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbByJudge = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbViewTop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstScores
            // 
            this.lstScores.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstScores.FullRowSelect = true;
            this.lstScores.GridLines = true;
            this.lstScores.Location = new System.Drawing.Point(22, 99);
            this.lstScores.Margin = new System.Windows.Forms.Padding(4);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(1151, 391);
            this.lstScores.TabIndex = 0;
            this.lstScores.UseCompatibleStateImageBehavior = false;
            this.lstScores.View = System.Windows.Forms.View.Details;
            // 
            // lblJudge
            // 
            this.lblJudge.AutoSize = true;
            this.lblJudge.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudge.Location = new System.Drawing.Point(87, 58);
            this.lblJudge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJudge.Name = "lblJudge";
            this.lblJudge.Size = new System.Drawing.Size(93, 30);
            this.lblJudge.TabIndex = 1;
            this.lblJudge.Text = "Judge:";
            // 
            // cmbJudge
            // 
            this.cmbJudge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJudge.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJudge.FormattingEnabled = true;
            this.cmbJudge.Location = new System.Drawing.Point(173, 53);
            this.cmbJudge.Margin = new System.Windows.Forms.Padding(4);
            this.cmbJudge.Name = "cmbJudge";
            this.cmbJudge.Size = new System.Drawing.Size(208, 38);
            this.cmbJudge.TabIndex = 2;
            this.cmbJudge.SelectedIndexChanged += new System.EventHandler(this.cmbJudge_SelectedIndexChanged);
            this.cmbJudge.SelectedValueChanged += new System.EventHandler(this.cmbJudge_SelectedValueChanged);
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(799, 508);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(261, 43);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAll.Location = new System.Drawing.Point(243, 17);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(124, 34);
            this.rdbAll.TabIndex = 4;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "Over All";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // rdbByJudge
            // 
            this.rdbByJudge.AutoSize = true;
            this.rdbByJudge.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbByJudge.Location = new System.Drawing.Point(93, 17);
            this.rdbByJudge.Name = "rdbByJudge";
            this.rdbByJudge.Size = new System.Drawing.Size(139, 34);
            this.rdbByJudge.TabIndex = 5;
            this.rdbByJudge.TabStop = true;
            this.rdbByJudge.Text = "By Judge";
            this.rdbByJudge.UseVisualStyleBackColor = true;
            this.rdbByJudge.CheckedChanged += new System.EventHandler(this.rdbByJudge_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "View Top:";
            // 
            // cmbViewTop
            // 
            this.cmbViewTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViewTop.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViewTop.FormattingEnabled = true;
            this.cmbViewTop.Location = new System.Drawing.Point(729, 37);
            this.cmbViewTop.Name = "cmbViewTop";
            this.cmbViewTop.Size = new System.Drawing.Size(145, 38);
            this.cmbViewTop.TabIndex = 7;
            // 
            // frmSoringTally
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1195, 563);
            this.Controls.Add(this.cmbViewTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbByJudge);
            this.Controls.Add(this.rdbAll);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cmbJudge);
            this.Controls.Add(this.lblJudge);
            this.Controls.Add(this.lstScores);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "frmSoringTally";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoring Tally";
            this.Load += new System.EventHandler(this.frmScoringTally_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstScores;
        private System.Windows.Forms.Label lblJudge;
        private System.Windows.Forms.ComboBox cmbJudge;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbByJudge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbViewTop;
    }
}