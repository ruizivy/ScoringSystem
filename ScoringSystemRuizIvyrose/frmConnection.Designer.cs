namespace ScoringSystemRuizIvyrose
{
    partial class frmConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnection));
            this.btnapply = new System.Windows.Forms.Button();
            this.btntest = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.txtport = new System.Windows.Forms.TextBox();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluid = new System.Windows.Forms.Label();
            this.lbldatabase = new System.Windows.Forms.Label();
            this.lblport = new System.Windows.Forms.Label();
            this.lblserver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnapply
            // 
            this.btnapply.BackColor = System.Drawing.Color.White;
            this.btnapply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnapply.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapply.ForeColor = System.Drawing.Color.Black;
            this.btnapply.Location = new System.Drawing.Point(324, 341);
            this.btnapply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(152, 59);
            this.btnapply.TabIndex = 71;
            this.btnapply.Text = "Apply";
            this.btnapply.UseVisualStyleBackColor = false;
            this.btnapply.Click += new System.EventHandler(this.btnapply_Click_1);
            // 
            // btntest
            // 
            this.btntest.BackColor = System.Drawing.Color.White;
            this.btntest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntest.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntest.ForeColor = System.Drawing.Color.Black;
            this.btntest.Location = new System.Drawing.Point(93, 341);
            this.btntest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(204, 59);
            this.btntest.TabIndex = 70;
            this.btntest.Text = "Test Connection";
            this.btntest.UseVisualStyleBackColor = false;
            this.btntest.Click += new System.EventHandler(this.btntest_Click_1);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Location = new System.Drawing.Point(131, 274);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(327, 33);
            this.txtpassword.TabIndex = 69;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtuid
            // 
            this.txtuid.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuid.ForeColor = System.Drawing.Color.Black;
            this.txtuid.Location = new System.Drawing.Point(131, 220);
            this.txtuid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(327, 33);
            this.txtuid.TabIndex = 68;
            // 
            // txtdatabase
            // 
            this.txtdatabase.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatabase.ForeColor = System.Drawing.Color.Black;
            this.txtdatabase.Location = new System.Drawing.Point(131, 158);
            this.txtdatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(327, 33);
            this.txtdatabase.TabIndex = 67;
            // 
            // txtport
            // 
            this.txtport.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtport.ForeColor = System.Drawing.Color.Black;
            this.txtport.Location = new System.Drawing.Point(131, 100);
            this.txtport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(327, 33);
            this.txtport.TabIndex = 66;
            // 
            // txtserver
            // 
            this.txtserver.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserver.ForeColor = System.Drawing.Color.Black;
            this.txtserver.Location = new System.Drawing.Point(131, 44);
            this.txtserver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(327, 33);
            this.txtserver.TabIndex = 65;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.Black;
            this.lblpass.Location = new System.Drawing.Point(14, 275);
            this.lblpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(101, 23);
            this.lblpass.TabIndex = 64;
            this.lblpass.Text = "Password:";
            // 
            // lbluid
            // 
            this.lbluid.AutoSize = true;
            this.lbluid.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluid.ForeColor = System.Drawing.Color.Black;
            this.lbluid.Location = new System.Drawing.Point(67, 228);
            this.lbluid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluid.Name = "lbluid";
            this.lbluid.Size = new System.Drawing.Size(46, 23);
            this.lbluid.TabIndex = 63;
            this.lbluid.Text = "UID:";
            // 
            // lbldatabase
            // 
            this.lbldatabase.AutoSize = true;
            this.lbldatabase.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatabase.ForeColor = System.Drawing.Color.Black;
            this.lbldatabase.Location = new System.Drawing.Point(17, 162);
            this.lbldatabase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatabase.Name = "lbldatabase";
            this.lbldatabase.Size = new System.Drawing.Size(106, 23);
            this.lbldatabase.TabIndex = 62;
            this.lbldatabase.Text = "Database:";
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblport.ForeColor = System.Drawing.Color.Black;
            this.lblport.Location = new System.Drawing.Point(71, 100);
            this.lblport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(50, 23);
            this.lblport.TabIndex = 61;
            this.lblport.Text = "Port:";
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserver.ForeColor = System.Drawing.Color.Black;
            this.lblserver.Location = new System.Drawing.Point(49, 47);
            this.lblserver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(72, 23);
            this.lblserver.TabIndex = 60;
            this.lblserver.Text = "Server:";
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(531, 445);
            this.Controls.Add(this.btnapply);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.txtdatabase);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluid);
            this.Controls.Add(this.lbldatabase);
            this.Controls.Add(this.lblport);
            this.Controls.Add(this.lblserver);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmConnection";
            this.Text = "Manage Connection";
            this.Load += new System.EventHandler(this.frmConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnapply;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluid;
        private System.Windows.Forms.Label lbldatabase;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.Label lblserver;
    }
}