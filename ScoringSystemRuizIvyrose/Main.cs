using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDBUtilities;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ScoringSystemRuizIvyrose
{
    public partial class frmMain : Form
    {
        MyUtilities db = new MyUtilities();
        List<Contestant> contestants = new List<Contestant>();
        public static bool IsAdmin = false;
        public static bool IsLogin = false;
        public static bool HasInputScore = false;
        public frmMain()
        {
            InitializeComponent();
            PopulateContestant();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addContestantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddContestant contest = new frmAddContestant();
            contest.MdiParent = this;
            contest.Show();
        }

        private void addCriteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCriteria criteria = new frmAddCriteria();
            criteria.ShowDialog();
        }

        private void addEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser judge = new frmAddUser();
            judge.ShowDialog();
        }

        private void monitoringTS_Click(object sender, EventArgs e)
        {

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (IsLogin)
                menuStrip1.Enabled = true;
            else
                menuStrip1.Enabled = false;
            if (IsAdmin)
            {
                Add.Visible = true;
                manage.Visible = true;
                scoring.Visible = false;
                tallyOfScore.Visible = true;
                reset_to.Visible = true;
                submit.Visible = false;
            }
            else
            {
                scoring.Visible = true;
                submit.Visible = true;
                Add.Visible = false;
                manage.Visible = false;
                tallyOfScore.Visible = false;
                reset_to.Visible = false;
            }
        }


        private void tmPrivelege_Tick(object sender, EventArgs e)
        {

        }
        private void LogoutTS_Click(object sender, EventArgs e)
        {
            IsLogin = false;
            frmLogin log2 = new frmLogin();
           // log2.MdiParent = this;
            log2.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser user = new frmAddUser();
            user.MdiParent = this;
            user.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contestantToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void scoring_Click(object sender, EventArgs e)
        {
            frmScoring score = new frmScoring();
            score.MdiParent = this;
            score.Show();
        }

        private void judgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void scoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateJudge judge = new frmUpdateJudge();
            judge.MdiParent = this;
            judge.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDeleteContestant delete = new frmDeleteContestant();
            delete.MdiParent = this;
            delete.Show();
        }

        private void tallyScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoringTally tally = new frmSoringTally();
            tally.MdiParent = this;
            tally.Show();
        }

        private void tallyOfScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoringTally tally = new frmSoringTally();
            tally.MdiParent = this;
            tally.Show();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to reset ? \n Note: All existing data will be deleted", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                db.InsertQuery("DELETE FROM tbluser WHERE userid != 1");
                db.InsertQuery("DELETE FROM tbljudge WHERE JudgeID != 0");
                db.InsertQuery("DELETE FROM tblcriteria WHERE CriteriaID != 0");
                db.InsertQuery("DELETE FROM tblcontestant WHERE ContestantID != 0");
                db.InsertQuery("DELETE FROM tblscoring WHERE ScoringID != 0");

                MessageBox.Show("Success!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Your default username and password is 'admin'" , "Information" ,
                    MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
        }

        private void submitAllScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want submit? \n Note: Once you click 'Yes' , you can't update ung score.", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                SubmitAll();
            }

        }
        public bool SubmitAll()
        {        
                foreach (Contestant c in contestants)
                {
                    string query = "SELECT * FROM tblscoring WHERE JudgeID = " + frmLogin.userid + " AND ContestantID = " + c.ContestantID +" AND Score != 0 AND CriteriaAverage != 0;";
                    MySqlDataAdapter adptr = new MySqlDataAdapter(query, db.OpenConnection());
                    DataTable dt = new DataTable();
                    adptr.Fill(dt);
                    db.CloseConnection();
                    if (dt.Rows.Count != 0)
                    {
                        frmMain main = new frmMain();
                        main.Enabled = false;
                        HasInputScore = true;
                        return true;
                    }
                }
                MessageBox.Show("Seems like you didn't input score to all contestants.. Please input score!!");
                HasInputScore = false;
                return false;        
        }

        private void PopulateContestant()
        {
            contestants.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT ContestantID, FullName FROM tblContestant ", db.OpenConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();

            foreach (DataRow row in dt.Rows)
            {
                Contestant c = new Contestant();
                c.ContestantID = row["ContestantID"].ToString();
                c.ContestantName = row["FullName"].ToString();
                contestants.Add(c);
            }
        }
    }
    
}
