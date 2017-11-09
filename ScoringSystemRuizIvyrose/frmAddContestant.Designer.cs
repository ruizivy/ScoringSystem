namespace ScoringSystemRuizIvyrose
{
    partial class frmAddContestant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddContestant));
            this.lstContestant = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picCon = new System.Windows.Forms.PictureBox();
            this.grpContestant = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblremarks = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtConNum = new System.Windows.Forms.TextBox();
            this.lblconNum = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblnote = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCon)).BeginInit();
            this.grpContestant.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstContestant
            // 
            this.lstContestant.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstContestant.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContestant.FullRowSelect = true;
            this.lstContestant.GridLines = true;
            this.lstContestant.Location = new System.Drawing.Point(13, 330);
            this.lstContestant.Name = "lstContestant";
            this.lstContestant.Size = new System.Drawing.Size(851, 227);
            this.lstContestant.TabIndex = 41;
            this.lstContestant.UseCompatibleStateImageBehavior = false;
            this.lstContestant.View = System.Windows.Forms.View.Details;
            this.lstContestant.Click += new System.EventHandler(this.lstContestant_Click);
            this.lstContestant.DoubleClick += new System.EventHandler(this.lstContestant_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "C#";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fullname";
            this.columnHeader2.Width = 221;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Remarks";
            this.columnHeader3.Width = 211;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Photopath";
            this.columnHeader4.Width = 314;
            // 
            // picCon
            // 
            this.picCon.Location = new System.Drawing.Point(11, 21);
            this.picCon.Name = "picCon";
            this.picCon.Size = new System.Drawing.Size(240, 201);
            this.picCon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCon.TabIndex = 9;
            this.picCon.TabStop = false;
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
            this.grpContestant.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContestant.Location = new System.Drawing.Point(13, 9);
            this.grpContestant.Name = "grpContestant";
            this.grpContestant.Size = new System.Drawing.Size(851, 268);
            this.grpContestant.TabIndex = 39;
            this.grpContestant.TabStop = false;
            this.grpContestant.Text = "Contestant";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(443, 133);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(362, 85);
            this.txtRemarks.TabIndex = 16;
            // 
            // lblremarks
            // 
            this.lblremarks.AutoSize = true;
            this.lblremarks.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremarks.Location = new System.Drawing.Point(317, 133);
            this.lblremarks.Name = "lblremarks";
            this.lblremarks.Size = new System.Drawing.Size(120, 30);
            this.lblremarks.TabIndex = 15;
            this.lblremarks.Text = "Remarks:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(443, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(362, 37);
            this.txtName.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(307, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(130, 30);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Fullname:";
            // 
            // txtConNum
            // 
            this.txtConNum.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConNum.Location = new System.Drawing.Point(443, 31);
            this.txtConNum.Name = "txtConNum";
            this.txtConNum.Size = new System.Drawing.Size(362, 37);
            this.txtConNum.TabIndex = 12;
            this.txtConNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConNum_KeyPress_1);
            // 
            // lblconNum
            // 
            this.lblconNum.AutoSize = true;
            this.lblconNum.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconNum.Location = new System.Drawing.Point(274, 34);
            this.lblconNum.Name = "lblconNum";
            this.lblconNum.Size = new System.Drawing.Size(169, 30);
            this.lblconNum.TabIndex = 11;
            this.lblconNum.Text = "Contestant#:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Navy;
            this.btnSearch.Location = new System.Drawing.Point(17, 228);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(211, 27);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Click here to insert image";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnote.ForeColor = System.Drawing.Color.Red;
            this.lblnote.Location = new System.Drawing.Point(26, 560);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(269, 21);
            this.lblnote.TabIndex = 40;
            this.lblnote.Text = "Note : Double-click to edit details";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(234, 293);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(276, 21);
            this.lblWarning.TabIndex = 38;
            this.lblWarning.Text = "Please complete the requirement!!";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(690, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 49);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(30, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 40);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel Update";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddContestant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(887, 586);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lstContestant);
            this.Controls.Add(this.grpContestant);
            this.Controls.Add(this.lblnote);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmAddContestant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Contestant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddContestant_FormClosing_1);
            this.Load += new System.EventHandler(this.frmAddContestant_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picCon)).EndInit();
            this.grpContestant.ResumeLayout(false);
            this.grpContestant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstContestant;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox picCon;
        private System.Windows.Forms.GroupBox grpContestant;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblremarks;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtConNum;
        private System.Windows.Forms.Label lblconNum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblnote;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}