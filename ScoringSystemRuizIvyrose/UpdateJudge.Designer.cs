namespace ScoringSystemRuizIvyrose
{
    partial class frmUpdateJudge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateJudge));
            this.lstJudge = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbAllDetails = new System.Windows.Forms.GroupBox();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.grpJudgeDetails = new System.Windows.Forms.GroupBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.rdbjudge = new System.Windows.Forms.RadioButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbAllDetails.SuspendLayout();
            this.grpJudgeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstJudge
            // 
            this.lstJudge.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstJudge.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJudge.FullRowSelect = true;
            this.lstJudge.GridLines = true;
            this.lstJudge.Location = new System.Drawing.Point(13, 318);
            this.lstJudge.Margin = new System.Windows.Forms.Padding(4);
            this.lstJudge.Name = "lstJudge";
            this.lstJudge.Size = new System.Drawing.Size(898, 308);
            this.lstJudge.TabIndex = 6;
            this.lstJudge.UseCompatibleStateImageBehavior = false;
            this.lstJudge.View = System.Windows.Forms.View.Details;
            this.lstJudge.SelectedIndexChanged += new System.EventHandler(this.lstJudge_SelectedIndexChanged);
            this.lstJudge.Click += new System.EventHandler(this.lstJudge_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "JID";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.Width = 179;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Password";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "User Type";
            this.columnHeader4.Width = 142;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fullname";
            this.columnHeader5.Width = 192;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Details";
            this.columnHeader6.Width = 319;
            // 
            // grbAllDetails
            // 
            this.grbAllDetails.Controls.Add(this.rdbAdmin);
            this.grbAllDetails.Controls.Add(this.grpJudgeDetails);
            this.grbAllDetails.Controls.Add(this.rdbjudge);
            this.grbAllDetails.Controls.Add(this.txtPass);
            this.grbAllDetails.Controls.Add(this.lblPass);
            this.grbAllDetails.Controls.Add(this.txtUser);
            this.grbAllDetails.Controls.Add(this.lblUser);
            this.grbAllDetails.Location = new System.Drawing.Point(16, 4);
            this.grbAllDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grbAllDetails.Name = "grbAllDetails";
            this.grbAllDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grbAllDetails.Size = new System.Drawing.Size(899, 274);
            this.grbAllDetails.TabIndex = 8;
            this.grbAllDetails.TabStop = false;
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdmin.Location = new System.Drawing.Point(34, 163);
            this.rdbAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(98, 29);
            this.rdbAdmin.TabIndex = 14;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // grpJudgeDetails
            // 
            this.grpJudgeDetails.Controls.Add(this.txtAddr);
            this.grpJudgeDetails.Controls.Add(this.lblFname);
            this.grpJudgeDetails.Controls.Add(this.lblAddr);
            this.grpJudgeDetails.Controls.Add(this.txtFname);
            this.grpJudgeDetails.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpJudgeDetails.Location = new System.Drawing.Point(366, 28);
            this.grpJudgeDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpJudgeDetails.Name = "grpJudgeDetails";
            this.grpJudgeDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpJudgeDetails.Size = new System.Drawing.Size(513, 219);
            this.grpJudgeDetails.TabIndex = 13;
            this.grpJudgeDetails.TabStop = false;
            this.grpJudgeDetails.Text = "Judge Information";
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(22, 123);
            this.txtAddr.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(481, 76);
            this.txtAddr.TabIndex = 10;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(18, 34);
            this.lblFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(110, 24);
            this.lblFname.TabIndex = 7;
            this.lblFname.Text = "Fullname:";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr.Location = new System.Drawing.Point(18, 97);
            this.lblAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(82, 24);
            this.lblAddr.TabIndex = 9;
            this.lblAddr.Text = "Details:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(22, 60);
            this.txtFname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(481, 31);
            this.txtFname.TabIndex = 8;
            // 
            // rdbjudge
            // 
            this.rdbjudge.AutoSize = true;
            this.rdbjudge.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbjudge.Location = new System.Drawing.Point(34, 207);
            this.rdbjudge.Margin = new System.Windows.Forms.Padding(4);
            this.rdbjudge.Name = "rdbjudge";
            this.rdbjudge.Size = new System.Drawing.Size(94, 29);
            this.rdbjudge.TabIndex = 12;
            this.rdbjudge.TabStop = true;
            this.rdbjudge.Text = "Judge";
            this.rdbjudge.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(129, 103);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(201, 33);
            this.txtPass.TabIndex = 11;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(12, 104);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(109, 24);
            this.lblPass.TabIndex = 10;
            this.lblPass.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(129, 55);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(201, 33);
            this.txtUser.TabIndex = 9;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(4, 55);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(118, 24);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Username:";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(719, 260);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 50);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmUpdateJudge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 638);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbAllDetails);
            this.Controls.Add(this.lstJudge);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmUpdateJudge";
            this.Text = "Update Judge";
            this.Load += new System.EventHandler(this.frmUpdateJudge_Load);
            this.grbAllDetails.ResumeLayout(false);
            this.grbAllDetails.PerformLayout();
            this.grpJudgeDetails.ResumeLayout(false);
            this.grpJudgeDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstJudge;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox grbAllDetails;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.GroupBox grpJudgeDetails;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.RadioButton rdbjudge;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnSave;
    }
}