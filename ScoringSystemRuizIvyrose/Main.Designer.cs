namespace ScoringSystemRuizIvyrose
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LogoutTS = new System.Windows.Forms.ToolStripMenuItem();
            this.Add = new System.Windows.Forms.ToolStripMenuItem();
            this.addContestantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCriteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manage = new System.Windows.Forms.ToolStripMenuItem();
            this.scoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tallyScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoring = new System.Windows.Forms.ToolStripMenuItem();
            this.tallyOfScore = new System.Windows.Forms.ToolStripMenuItem();
            this.reset_to = new System.Windows.Forms.ToolStripMenuItem();
            this.submit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmPrivelege = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutTS,
            this.Add,
            this.manage,
            this.scoring,
            this.tallyOfScore,
            this.reset_to,
            this.submit});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // LogoutTS
            // 
            this.LogoutTS.Name = "LogoutTS";
            this.LogoutTS.Size = new System.Drawing.Size(58, 29);
            this.LogoutTS.Text = "Exit";
            this.LogoutTS.Click += new System.EventHandler(this.LogoutTS_Click);
            // 
            // Add
            // 
            this.Add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContestantToolStripMenuItem,
            this.addCriteriaToolStripMenuItem,
            this.addUserToolStripMenuItem});
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(68, 29);
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.monitoringTS_Click);
            // 
            // addContestantToolStripMenuItem
            // 
            this.addContestantToolStripMenuItem.Name = "addContestantToolStripMenuItem";
            this.addContestantToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.addContestantToolStripMenuItem.Text = "Add Contestant";
            this.addContestantToolStripMenuItem.Click += new System.EventHandler(this.addContestantToolStripMenuItem_Click);
            // 
            // addCriteriaToolStripMenuItem
            // 
            this.addCriteriaToolStripMenuItem.Name = "addCriteriaToolStripMenuItem";
            this.addCriteriaToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.addCriteriaToolStripMenuItem.Text = "Add Criteria";
            this.addCriteriaToolStripMenuItem.Click += new System.EventHandler(this.addCriteriaToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // manage
            // 
            this.manage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoringToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.tallyScoreToolStripMenuItem});
            this.manage.Name = "manage";
            this.manage.Size = new System.Drawing.Size(111, 29);
            this.manage.Text = "Manage";
            // 
            // scoringToolStripMenuItem
            // 
            this.scoringToolStripMenuItem.Name = "scoringToolStripMenuItem";
            this.scoringToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.scoringToolStripMenuItem.Text = "Update Judge User";
            this.scoringToolStripMenuItem.Click += new System.EventHandler(this.scoringToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(276, 30);
            this.deleteToolStripMenuItem1.Text = "Delete Contestant";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // tallyScoreToolStripMenuItem
            // 
            this.tallyScoreToolStripMenuItem.Name = "tallyScoreToolStripMenuItem";
            this.tallyScoreToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.tallyScoreToolStripMenuItem.Text = "Tally Score";
            this.tallyScoreToolStripMenuItem.Click += new System.EventHandler(this.tallyScoreToolStripMenuItem_Click);
            // 
            // scoring
            // 
            this.scoring.Name = "scoring";
            this.scoring.Size = new System.Drawing.Size(100, 29);
            this.scoring.Text = "Scoring";
            this.scoring.Click += new System.EventHandler(this.scoring_Click);
            // 
            // tallyOfScore
            // 
            this.tallyOfScore.Name = "tallyOfScore";
            this.tallyOfScore.Size = new System.Drawing.Size(157, 29);
            this.tallyOfScore.Text = "Tally of Score";
            this.tallyOfScore.Click += new System.EventHandler(this.tallyOfScoreToolStripMenuItem_Click);
            // 
            // reset_to
            // 
            this.reset_to.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_to.Name = "reset_to";
            this.reset_to.Size = new System.Drawing.Size(77, 29);
            this.reset_to.Text = "Reset";
            this.reset_to.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // submit
            // 
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(188, 29);
            this.submit.Text = "Submit All Score";
            this.submit.Click += new System.EventHandler(this.submitAllScoreToolStripMenuItem_Click);
            // 
            // tmPrivelege
            // 
            this.tmPrivelege.Enabled = true;
            this.tmPrivelege.Tick += new System.EventHandler(this.tmPrivelege_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 474);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Scoring System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LogoutTS;
        private System.Windows.Forms.ToolStripMenuItem Add;
        private System.Windows.Forms.ToolStripMenuItem addContestantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCriteriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manage;
        private System.Windows.Forms.ToolStripMenuItem scoringToolStripMenuItem;
        private System.Windows.Forms.Timer tmPrivelege;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scoring;
        private System.Windows.Forms.ToolStripMenuItem tallyScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallyOfScore;
        private System.Windows.Forms.ToolStripMenuItem reset_to;
        private System.Windows.Forms.ToolStripMenuItem submit;

    }
}