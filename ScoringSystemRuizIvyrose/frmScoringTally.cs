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
using Excel = Microsoft.Office.Interop.Excel;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Tools.Applications.Runtime;

namespace ScoringSystemRuizIvyrose
{
    public partial class frmSoringTally : Form
    {
        public enum ShowCommands : int
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,
            SW_NORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_FORCEMINIMIZE = 11,
            SW_MAX = 11
        }

        [DllImport("shell32.dll")]
        static extern IntPtr ShellExecute(
            IntPtr hwnd,
            string lpOperation,
            string lpFile,
            string lpParameters,
            string lpDirectory,
            ShowCommands nShowCmd);

        MyUtilities db = new MyUtilities();
        MySqlCommand cmd;
        MySqlDataAdapter adptr;
        DataTable table;

        List<Contestant> contestants = new List<Contestant>();
        List<Criteria> criterias = new List<Criteria>();
        List<Score> scores = new List<Score>();
        List<Judge> judges = new List<Judge>();
        List<Judge> byJudge = new List<Judge>();
        public int count;

        public frmSoringTally()
        {
            table = new DataTable();
            InitializeComponent();
            rdbAll.Checked = true;
            PopulateContestant();
            PopulateCriteria();
            PopulateScore();
            PopulateJudges();
            SetUpListView();
            CountContestant();
            
        }

        private void frmScoringTally_Load(object sender, EventArgs e)
        {
            //BindToComboBox("SELECT * FROM tbljudge", cmbJudge,"judgeID","JudgeFNAme");
            PopulateJudgeName();
            lblJudge.Enabled = false;
            cmbJudge.Enabled = false;
            lstScores.Items.Clear();
        }
        public void PopulateJudgeName()
        {
            DataTable table = new DataTable();
            table.Clear();
            cmbJudge.Items.Clear();
            adptr = new MySqlDataAdapter("SELECT * FROM tbljudge", db.OpenConnection());
            adptr.Fill(table);
            db.CloseConnection();
            foreach (DataRow row in table.Rows)
            {
                cmbJudge.Items.Add(row["JudgeFName"].ToString());
            }
        }
        public void BindToComboBox(string query, ComboBox cmb,string columnkey,string columnvalue)
        {
            DataTable table = db.SelectQuery(query);
            Dictionary<string, string> d = new Dictionary<string, string>();
            foreach (DataRow row in table.Rows)
            {
                d.Add(row[columnkey].ToString(), row[columnvalue].ToString());
            }
            if (table.Rows.Count > 0)
            {
                cmb.DataSource = new BindingSource(d, null);
                cmb.ValueMember = "key";
                cmb.DisplayMember = "value";
            }
 
        }
        public void CountContestant()
        {
            MySqlDataAdapter adptr = new MySqlDataAdapter("SELECT COUNT(*) as 'c' FROM tblcontestant", db.OpenConnection());
            DataTable table = new DataTable();
            adptr.Fill(table);
            db.CloseConnection();
            foreach (DataRow row in table.Rows)
            {
                count = Convert.ToInt32(row["c"].ToString());
                for (int i = 1; i <= count; i++)
                {
                    cmbViewTop.Items.Add(i);
                }
            }
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
        private void PopulateCriteria()
        {
            criterias.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tblcriteria ", db.OpenConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            db.CloseConnection();

            foreach (DataRow row in table.Rows)
            {
                Criteria c = new Criteria();
                try
                {
                    c.CriteriaID = row["CriteriaID"].ToString();
                    c.CriteriaName = row["CriteriaName"].ToString();
                    c.CriteriaPercentage = Convert.ToDouble(row["Percentage"].ToString());
                }
                catch (Exception e)
                {
                    c.CriteriaPercentage = 0;
                    continue;
                }
                criterias.Add(c);
            }
        }
      
        private void PopulateScore()
        {
          
            lstScores.Items.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tblscoring ", db.OpenConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.CloseConnection();

            foreach (DataRow row in dt.Rows)
            {
                Score score = new Score();
                score.Judge = row["JudgeID"].ToString();
                score.Contestant = row["ContestantID"].ToString();
                score.CriteriaID = row["CriteriaID"].ToString();
                score.RawScore = Convert.ToDouble(row["Score"].ToString());
                score.Average = Convert.ToDouble(row["CriteriaAverage"].ToString());
                scores.Add(score);
            }
            dt.Dispose();
            adapter.Dispose();
        }
     
        private void SetUpListView()
        {
            lstScores.Items.Clear();
            lstScores.Columns.Add("ContestantID", 0);
            lstScores.Columns.Add("Contestant Name", 180);

            foreach (Criteria c in criterias)
            {
                lstScores.Columns.Add(c.CriteriaName + " (" + c.CriteriaPercentage + ")", 207);
            }

            lstScores.Columns.Add("Total Score", 120);

            LoadContestantToListView();
        }
        private void LoadContestantToListView()
        {
            lstScores.Items.Clear();
            foreach (Contestant c in contestants)
            {
                double totalScore = 0;
                ListViewItem item = new ListViewItem(c.ContestantID);
                item.SubItems.Add(c.ContestantName);
                foreach (Criteria criteria in criterias)
                {
                    double score = ComputePercentage(GetScore(c.ContestantID, criteria.CriteriaID), criteria.CriteriaID);
                    item.SubItems.Add(score.ToString());
                    totalScore += score;
                }
                item.SubItems.Add(totalScore.ToString());
                lstScores.Items.Add(item);
            }
        }
        private void loadScoreEachJudge()
        {
            lstScores.Items.Clear();
            foreach (Judge j in byJudge)
            {
                foreach (Contestant c in contestants)
                {
                    double totalScore = 0;
                    ListViewItem itm = new ListViewItem(c.ContestantID);
                    itm.SubItems.Add(c.ContestantName);
                    foreach (Criteria crit in criterias)
                    {
                        double score = GetScoreByJudge(j.JudgeID, c.ContestantID, crit.CriteriaID);
                        itm.SubItems.Add(score.ToString());
                        totalScore += score;
                    }
                    itm.SubItems.Add(totalScore.ToString());
                    lstScores.Items.Add(itm);
                }
            }
           
        }

        private void PopulateJudges()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tbljudge  ", db.OpenConnection());
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            db.CloseConnection();
            foreach (DataRow row in table.Rows)
            {
                judges.Add(new Judge(row["JudgeID"].ToString()));
            }
            adapter.Dispose();
            table.Dispose();
        }

        private void PopulateJudges2()
        {
            lstScores.Items.Clear();
            string judgeid = db.GetID("SELECT * FROM tbljudge WHERE JudgeFName = '" + cmbJudge.Text + "'", "JudgeID").ToString();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tbljudge WHERE JudgeID = "+judgeid+"", db.OpenConnection());
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            db.CloseConnection();
            foreach (DataRow row in table.Rows)
            {
                byJudge.Add(new Judge(row["JudgeID"].ToString()));
            }
            adapter.Dispose();
            table.Dispose();
        }
        private double ComputePercentage(double score, string criteriaID)
        {
            try
            {
                return criterias.Where(n => n.CriteriaID.Equals(criteriaID)).Select(n => n).Select(n => n.CriteriaPercentage).Single() * score;
            }
            catch (Exception e)
            {
                return score;
            }
        }
        private double GetScore(string contestantID, string criteriaID)
        {
            try
            {
                return scores.Where(s => s.Contestant.Equals(contestantID) &&
                                         s.CriteriaID.Equals(criteriaID)).Sum(s => s.Average);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        private double GetScoreByJudge(string JudgeID ,string contestantID, string criteriaID)
        {
            try
            {
                return scores.Where(s => s.Judge.Equals(JudgeID) &&
                                    s.Contestant.Equals(contestantID) &&
                                    s.CriteriaID.Equals(criteriaID)).Sum(s => s.Average);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private void rdbByJudge_CheckedChanged(object sender, EventArgs e)
        {
            lstScores.Items.Clear();
            lblJudge.Enabled = true;
            cmbJudge.Enabled = true;
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            lstScores.Items.Clear();
            lblJudge.Enabled = false;
            cmbJudge.Enabled = false;
            //cmbJudge.Text = null;
            LoadContestantToListView();
        }


        private void PrintReportToExcel()
        {
            Excel.Application oXL;
            Excel.Workbook oWB;
            Excel.Worksheet oSheet;
            Excel.Range oRng;
            object oMissing = Missing.Value;

            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;
                
                //Get a new workbook.
                oWB = oXL.Workbooks._Open(Application.StartupPath+ "\\eventscoring\\eventscoring.xlsx", oMissing, oMissing, oMissing,
                                          oMissing, oMissing, oMissing, oMissing, oMissing, oMissing,
                                          oMissing, oMissing, oMissing);

                oSheet = oWB.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                //oSheet.Cells[row,col] = " data "
                oSheet.Cells[4, 6] = DateTime.Now.ToLongDateString(); //Print Date on excel row 4, column F (6)

                int counter = 7;
                int addcol = 2;
                Excel.Range range = oSheet.Cells[1, 1] as Excel.Range;
                oSheet.Cells[counter, 1] = "Contestant Name";
                foreach (Criteria c in criterias)
                {
                    oSheet.Cells[counter,addcol++] = c.CriteriaName + "(" + c.CriteriaPercentage + ")";
                }
                oSheet.Cells[counter, addcol++] = "Total Score";
                oSheet.Columns.AutoFit();

                int counter1 = 8;
                int addcol1 = 2;
                int counter2 = 8;
                int addcol2 = 1;
                foreach (Contestant c in contestants)
                {
                    double totalScore = 0;
                    oSheet.Cells[counter2, addcol2] = c.ContestantName;
                    foreach (Criteria criteria in criterias)
                    {
                        double score = ComputePercentage(GetScore(c.ContestantID, criteria.CriteriaID), criteria.CriteriaID);
                        oSheet.Cells[counter1, addcol1++] = score.ToString();
                        oSheet.Cells[counter1, addcol1] = (totalScore += score);
                    }
                    counter1++;
                    addcol1 = 2;
                   counter2++;
                   Excel.Range r = oSheet.get_Range("A" + counter1, "F" + counter1).EntireRow;
                   r.Insert(Excel.XlInsertShiftDirection.xlShiftDown, oMissing);
                }

                oWB.SaveAs(Application.StartupPath + "\\eventscoring\\eventscoring" + DateTime.Now.Second + ".xlsx", oMissing, oMissing, oMissing, oMissing,
                          oMissing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                          oMissing, oMissing, oMissing, oMissing, oMissing);
                oWB.Close(true, Type.Missing, Type.Missing);
                oXL.Quit();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
       
        private void btnExport_Click(object sender, EventArgs e)
        {
            PrintReportToExcel();
        }

        private void cmbJudge_SelectedIndexChanged(object sender, EventArgs e)
        {
           // scores.Clear();
           
          //  PopulateScore();

        }

        private void txtNumOfTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.TextHandler(ref sender, ref e, true);
        }

        private void cmbJudge_SelectedValueChanged(object sender, EventArgs e)
        {
            lstScores.Items.Clear();
            PopulateJudges2();
            loadScoreEachJudge();
        }

    }
    class Criteria
    {
        private string criteriaID;
        private string criteriaName;
        private double criteriaPercentage;

        public string CriteriaID
        {
            get { return this.criteriaID; }
            set { this.criteriaID = (value.ToString().Trim().Length > 0 ? value : "-1"); }
        }
        public string CriteriaName
        {
            get { return this.criteriaName; }
            set { this.criteriaName = (value.ToString().Trim().Length > 0 ? value : "-1"); }
        }
        public double CriteriaPercentage
        {
            get { return this.criteriaPercentage; }
            set { this.criteriaPercentage = value; }
        }
    }
    class Score
    {
        private string contestantID;
        private string judgeID;
        private string criteriaID;
        private double rawScore;
        private double average;

        public double RawScore
        {
            get { return this.rawScore; }
            set { this.rawScore = value; }
        }
        public double Average
        {
            get { return this.average; }
            set { this.average = value; }
        }
        public string Judge
        {
            get { return this.judgeID; }
            set { this.judgeID = (value.ToString().Trim().Length > 0 ? value : "-1"); }
        }
        public string CriteriaID
        {
            get { return this.criteriaID; }
            set { this.criteriaID = (value.ToString().Trim().Length > 0 ? value : "-1"); }
        }
        public string Contestant
        {
            set { this.contestantID = value; }
            get { return this.contestantID; }
        }
    }
    class Contestant
    {
        private string contestantID;
        private string contestantName;

        public string ContestantID
        {
            get { return this.contestantID; }
            set { this.contestantID = (value.ToString().Trim().Length > 0 ? value : "-1"); }
        }
        public string ContestantName
        {
            get { return this.contestantName; }
            set { this.contestantName = (value.ToString().Trim().Length > 0 ? value : ""); }
        }
    }
    class Judge
    {
        private string judgeID;
        public Judge(string id)
        {
            this.judgeID = id;
        }
        public string JudgeID
        {
            set { this.judgeID = value; }
            get { return this.judgeID; }

        }
    }
}
