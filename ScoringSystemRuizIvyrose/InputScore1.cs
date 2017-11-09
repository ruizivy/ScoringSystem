using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MyDBUtilities;

namespace ScoringSystemRuizIvyrose
{

    struct Scoring
    {
        public string judgeID;
        public string contestandID;
        public string criteriaID;
        public double percentage;
        public double rawScore;
        public double averageScore;

        public TextBox judgeRawScore;
        public Label judgeAverageScore;
        public Label totalScore;
    }

    public partial class frmInputScore1 : Form
    {
        public static string contestantTrueID;
        public static string contestantID = "";
        public static bool toUpdate = false;

        public static string jID = "1";

        MySqlConnection connection;
        MySqlCommand command;
        DataTable table;
        MySqlDataAdapter adapter;
        MyUtilities db = new MyUtilities();

        /// <summary>
        /// 
        /// </summary>
        private int textBoxPosX;
        private int textBoxPosY;

        private int labelPosX;
        private int labelPosY;

        private int groupBoxPosX;
        private int groupBoxPosY;

        private int horizontalMargin = 80;
        private Label totalScore;

        List<Scoring> scores = new List<Scoring>();
        public frmInputScore1()
        {
            InitializeComponent();
            table = new DataTable();
            labelPosX = groupBox1.Width + 30;
            labelPosY = 100;

            textBoxPosX = 200;
            textBoxPosY = labelPosY;

            groupBoxPosX = labelPosX;
            groupBoxPosY = labelPosY + 40;

            LoadGroupDetails();

            GetCriteriaForJudging();
        }

        private void frmInputScore1_Load(object sender, EventArgs e)
        {
           
        }      
        private string GetRawAndAverageScore(string _cID, string _criID , string _jID, string flag)
        {
          //  MessageBox.Show(_cID + _criID + flag);
            MySqlDataAdapter d = new MySqlDataAdapter("SELECT * FROM tblscoring WHERE contestantid = " + _cID + " AND criteriaID = " + _criID + " AND JudgeID = "+_jID +";", db.OpenConnection());
            DataTable dt = new DataTable();
            d.Fill(dt);
            db.CloseConnection();
            foreach (DataRow row in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    toUpdate = true;
                    if (flag.Equals("score")) return dt.Rows[0]["Score"].ToString();
                    if (flag.Equals("average")) return dt.Rows[0]["CriteriaAverage"].ToString();
                }
            }
            return "0";
        }

        public void GetCriteriaForJudging()
        {
            Panel panel = new Panel();
            panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom)));
            panel.Location = new System.Drawing.Point(5, 5);
            panel.Size = new System.Drawing.Size(this.Width - 30, this.Height - 50);
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.AutoScroll = true;

            table.Clear();
            adapter = new MySqlDataAdapter("SELECT * FROM tblcriteria ORDER BY CriteriaID", db.OpenConnection());
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                jID = db.GetID("SELECT * FROM tbluser WHERE userid = " + frmLogin.userid + "", "judgeid").ToString();
                Scoring score = new Scoring();
                score.judgeID = jID.ToString();
                score.contestandID = contestantTrueID;
                score.criteriaID = row["CriteriaID"].ToString();
                score.percentage = ProcessValueToDouble(row["Percentage"].ToString());
                score.rawScore =  Convert.ToDouble(GetRawAndAverageScore(contestantTrueID, score.criteriaID, jID , "score"));
                score.averageScore = Convert.ToDouble(GetRawAndAverageScore(contestantTrueID, score.criteriaID, jID, "average"));


                this.Controls.Add(CreateLabel("cr_" + score.criteriaID, row["CriteriaName"].ToString(), labelPosX, labelPosY));
                this.Controls.Add(CreateLabel("pr_" + score.criteriaID, row["Percentage"].ToString(), labelPosX + 200, labelPosY));

                TextBox t = CreateTextBox("rs_" + score.criteriaID, score.rawScore.ToString(), textBoxPosX + 500, textBoxPosY );
                t.KeyPress += new KeyPressEventHandler(limitto);
                
                Label l = CreateLabel("score_" + score.criteriaID,score.averageScore.ToString(), textBoxPosX + 800, labelPosY);
                
                this.Controls.Add(t);
                this.Controls.Add(l);
                this.Controls.Add(CreateGroupBox(groupBoxPosX, groupBoxPosY));

                labelPosY += horizontalMargin;
                textBoxPosY += horizontalMargin;
                groupBoxPosY += horizontalMargin;

                score.judgeAverageScore = l;
                score.judgeRawScore = t;

                scores.Add(score);
            }   

            this.Controls.Add(CreateLabel("TotalLabel", "Total Score", textBoxPosX + 300, textBoxPosY));
            totalScore = CreateLabel("TotalScore", ComputeTotalScore().ToString(), textBoxPosX + 800, textBoxPosY);
            this.Controls.Add(totalScore);
            this.Controls.Add(CreateButton(groupBoxPosX, 480));
            this.Controls.Add(panel);
        }

        private double ComputeTotalScore()
        {
            double retVal = 0;
            try
            {
                foreach (Scoring score in scores)
                {
                    retVal += score.averageScore;
                }
            }
            catch (Exception e)
            {
                return retVal;
            }
            return retVal;
        }
        public void decimalhandler(object sender, KeyPressEventArgs e)
        {
            
        }
        public void texthandler(object sender, KeyPressEventArgs e)
        {
            
        }
        public void limitto(object sender, KeyPressEventArgs e)
        {
            db.LimitTo(ref sender, ref e, 100);
            db.TextHandler(ref sender, ref e, true);
            //db.DecimalHandler(ref sender, ref e);
        }
        private double ProcessValueToDouble(string value)
        {
            try
            {
                return Convert.ToDouble(value);
            }
            catch (Exception e)
            {
                return 0;
            }

        }
        public Button CreateButton(int locX, int locY)
        {
            Button button = new Button();
            button.Location = new System.Drawing.Point(locX, locY);
            button.Size = new System.Drawing.Size(600, 78);
            button.Text = (toUpdate? "Update " : "Save ") +  "Score";
            button.UseVisualStyleBackColor = true;
            button.Click += new System.EventHandler(Save_Score);
            return button;
        }

        public void Save_Score(object sender, EventArgs e)
        {
            try
            {
                if (toUpdate)
                {
                   // getScoreAndAverage();
                    UpdateScore();
                }
                else
                {
                    //for (int i = 0; i < scores.Count; i++)
                    //{
                    //    Scoring s = scores[i];
                    //    s.rawScore = Convert.ToDouble(s.judgeRawScore.Text);
                    //    s.averageScore = s.percentage * s.rawScore;
                    //    scores[i] = s;
                    //}
                    SaveScore();
                }
                frmScoring.hasUpdated = true;   
                this.Close();
            }
            catch (Exception ex)
            { }
        }

        private void SaveScore()
        {
            DialogResult res = MessageBox.Show("Save the score?", "Save Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (Scoring s in scores)
                {
                    string insert_query = "INSERT INTO tblscoring(JudgeID, CriteriaID, ContestantID, Score, CriteriaAverage) " +
                                          "VALUES (" + s.judgeID + "," + s.criteriaID + "," + s.contestandID + "," + s.rawScore + "," + s.averageScore + ")";
                    command = new MySqlCommand(insert_query, db.OpenConnection());
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("The score is saved successfully!", "Save Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateScore()
        {
            DialogResult res = MessageBox.Show("Update the score?", "Update Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (Scoring s in scores)
                {
                    string update_query = " UPDATE tblscoring SET Score = " + s.rawScore + ", CriteriaAverage = " + s.averageScore +
                                          " WHERE JudgeID = " + s.judgeID + " AND ContestantID = " + s.contestandID + " AND CriteriaID = " + s.criteriaID + " ";
                    command = new MySqlCommand(update_query, db.OpenConnection());
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("The score is updated successfully!", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public TextBox CreateTextBox(string name, string text, int locX, int locY)
        {
            TextBox textBox = new TextBox();
            textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.Location = new System.Drawing.Point(locX, locY);
            textBox.Name = name;
            textBox.Text = text;
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.Size = new System.Drawing.Size(250, 49);
            textBox.TextChanged += new EventHandler(Compute_Score);
            return textBox;
        }

        private void Compute_Score(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            try
            {
                int index = Convert.ToInt32(t.Name.Split(new char[] { '_' })[1]);

                Scoring s = scores[index - 1];

                Label l = s.judgeAverageScore;

                double averageScore = Convert.ToDouble(t.Text) * s.percentage;

                l.Text = averageScore.ToString();
                s.rawScore = Convert.ToDouble(t.Text);
                s.averageScore = averageScore;
                scores[index - 1] = s;

                totalScore.Text = ComputeTotalScore().ToString();

            }
            catch (Exception ex)
            {
                t.Text = "0";
            }
        }
        public Label CreateLabel(string name, string text, int locX, int locY)
        {
            Label label = new Label();

            label.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(locX, locY);
            label.Name = name;
            label.Size = new System.Drawing.Size(134, 39);
            label.Text = text;

            return label;
        }

        public GroupBox CreateGroupBox(int locX, int locY)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Location = new System.Drawing.Point(locX, locY);
            groupBox.Size = new System.Drawing.Size(800, 12);
            groupBox.TabStop = false;
            return groupBox;
        }
        public void LoadGroupDetails()
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT * FROM tblcontestant WHERE Contestantno = " + contestantID, db.OpenConnection());
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    groupBox1.Text = row["FullName"].ToString();
                    label2.Text = row["Details"].ToString();
                    pictureBox1.Image = Image.FromFile(row["PhotoPath"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
