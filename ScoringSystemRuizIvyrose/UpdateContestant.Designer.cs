namespace ScoringSystemRuizIvyrose
{
    partial class frmUpdateContestant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateContestant));
            this.lstContestant = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblnote = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.grpContestant = new System.Windows.Forms.GroupBox();
            this.lblremarks = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtConNum = new System.Windows.Forms.TextBox();
            this.lblconNum = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.picCon = new System.Windows.Forms.PictureBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.grpContestant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCon)).BeginInit();
            this.SuspendLayout();
            // 
            // lstContestant
            // 
            this.lstContestant.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstContestant.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContestant.GridLines = true;
            this.lstContestant.Location = new System.Drawing.Point(33, 410);
            this.lstContestant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstContestant.Name = "lstContestant";
            this.lstContestant.Size = new System.Drawing.Size(839, 280);
            this.lstContestant.TabIndex = 46;
            this.lstContestant.UseCompatibleStateImageBehavior = false;
            this.lstContestant.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "C#";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fullname";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Remarks";
            this.columnHeader3.Width = 195;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Photopath";
            this.columnHeader4.Width = 306;
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnote.ForeColor = System.Drawing.Color.Red;
            this.lblnote.Location = new System.Drawing.Point(50, 695);
            this.lblnote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(225, 17);
            this.lblnote.TabIndex = 45;
            this.lblnote.Text = "Note : Double-click to edit details";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(727, 353);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 49);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(506, 151);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(318, 104);
            this.txtRemarks.TabIndex = 16;
            // 
            // grpContestant
            // 
            this.grpContestant.Controls.Add(this.txtRemarks);
            this.grpContestant.Controls.Add(this.lblremarks);
            this.grpContestant.Controls.Add(this.txtName);
            this.grpContestant.Controls.Add(this.lblName);
            this.grpContestant.Controls.Add(this.txtConNum);
            this.grpContestant.Controls.Add(this.lblconNum);
            this.grpContestant.Controls.Add(this.btnSearch);
            this.grpContestant.Controls.Add(this.picCon);
            this.grpContestant.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContestant.Location = new System.Drawing.Point(33, 14);
            this.grpContestant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpContestant.Name = "grpContestant";
            this.grpContestant.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpContestant.Size = new System.Drawing.Size(840, 331);
            this.grpContestant.TabIndex = 44;
            this.grpContestant.TabStop = false;
            this.grpContestant.Text = "Contestant";
            // 
            // lblremarks
            // 
            this.lblremarks.AutoSize = true;
            this.lblremarks.Location = new System.Drawing.Point(368, 155);
            this.lblremarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblremarks.Name = "lblremarks";
            this.lblremarks.Size = new System.Drawing.Size(94, 23);
            this.lblremarks.TabIndex = 15;
            this.lblremarks.Text = "Remarks:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(506, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(318, 31);
            this.txtName.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(368, 92);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 23);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Fullname:";
            // 
            // txtConNum
            // 
            this.txtConNum.Location = new System.Drawing.Point(506, 25);
            this.txtConNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConNum.Name = "txtConNum";
            this.txtConNum.Size = new System.Drawing.Size(318, 31);
            this.txtConNum.TabIndex = 12;
            // 
            // lblconNum
            // 
            this.lblconNum.AutoSize = true;
            this.lblconNum.Location = new System.Drawing.Point(337, 28);
            this.lblconNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconNum.Name = "lblconNum";
            this.lblconNum.Size = new System.Drawing.Size(127, 23);
            this.lblconNum.TabIndex = 11;
            this.lblconNum.Text = "Contestant#:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Navy;
            this.btnSearch.Location = new System.Drawing.Point(29, 289);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(264, 34);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Click here to insert image";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // picCon
            // 
            this.picCon.Location = new System.Drawing.Point(16, 35);
            this.picCon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCon.Name = "picCon";
            this.picCon.Size = new System.Drawing.Size(300, 248);
            this.picCon.TabIndex = 9;
            this.picCon.TabStop = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(309, 365);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(278, 21);
            this.lblWarning.TabIndex = 43;
            this.lblWarning.Text = "Please complete the requirement!!";
            // 
            // frmUpdateContestant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 732);
            this.Controls.Add(this.lstContestant);
            this.Controls.Add(this.lblnote);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpContestant);
            this.Controls.Add(this.lblWarning);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmUpdateContestant";
            this.Text = "UpdateContestant";
            this.Load += new System.EventHandler(this.frmUpdateContestant_Load);
            this.grpContestant.ResumeLayout(false);
            this.grpContestant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstContestant;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblnote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.GroupBox grpContestant;
        private System.Windows.Forms.Label lblremarks;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtConNum;
        private System.Windows.Forms.Label lblconNum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picCon;
        private System.Windows.Forms.Label lblWarning;
    }
}