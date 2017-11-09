using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyDBUtilities;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ScoringSystemRuizIvyrose
{
    public partial class frmScoring : Form
    {
        
        private const int PADDING = 15;

        private int paddingX = 25;
        private int paddingY = 10;
        private int paddingZ = 15;

        private int selectedContestant = -1;
        public static bool hasUpdated = false;

        private bool hasScore = false;
        public string judgeid;
 
        const int locx = 10;
        const int locy = 10;
        const int height = 500;
        const int width = 600;
        PictureBox[] pictures;
        Button[] buttons;

        MyUtilities db = new MyUtilities();

        public frmScoring()
        {
            InitializeComponent();
            //if (!Directory.Exists(Environment.CurrentDirectory + "\\Picture"))
            //{
            //    Directory.CreateDirectory(Environment.CurrentDirectory + "\\Picture");
            //}
            //DataTable dt = db.SelectQuery("SELECT * FROM tblcontestant ORDER BY ContestantNo;");
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    string env = Environment.CurrentDirectory.ToString().Replace("\\", "\\\\");
            //    db.InsertQuery("UPDATE tblcontestant SET PhotoPath = '" + (env + "\\\\Picture\\\\") + (i + 1) + ".png' WHERE contestantid = " + (i + 1));
            //}
        }

        private void frmScoring_Load(object sender, EventArgs e)
        {
            GenerateControls();
            this.WindowState = FormWindowState.Maximized;
        }
        public GroupBox CreateGroupBox(int LocX, int LocY, string text,string name)
        {
            GroupBox groupbox = new GroupBox();
            groupbox.Size = new Size(width, height);
            groupbox.Location = new Point(LocX, LocY);
            groupbox.Text = text;
            groupbox.Name = name;
            return groupbox;
        }
        public Label GenerateLabel(int LocX, int LocY, string text)
        {
            Label lbl = new Label();
            lbl.Location = new Point(LocX, LocY);
            lbl.Size = new Size(200, 400);
            lbl.AutoSize = false;
            lbl.Text = text;
            return lbl;
        }
        public Button GenerateButton(int LocX, int LocY, string text,string name)
        {
            Button btn = new Button();
            btn.Location = new Point(LocX, LocY);
            btn.Size = new Size(200, 40);
            btn.Text = text;
            btn.Name = name;
            btn.FlatStyle = FlatStyle.Flat;
            return btn;
        }
        public PictureBox GeneratePictureBox(int locX, int locY, Image im)
        {
            PictureBox picture = new PictureBox();
            picture.Location = new Point(locX, locY);
            picture.Size = new Size(200, 200);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.BorderStyle = BorderStyle.FixedSingle;
            picture.Visible = true;
            picture.Image = im;
            return picture;
        }
        public void GenerateControls()
        {
            Panel panel = new Panel();
            panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom)));
            panel.Location = new System.Drawing.Point(5, 5);
            panel.Size = new System.Drawing.Size(this.Width - 30, this.Height - 50);
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.AutoScroll = true;

            DataTable dt = db.SelectQuery("SELECT * FROM tblcontestant ORDER BY ContestantNo;");
            pictures = new PictureBox[dt.Rows.Count];
            buttons = new Button[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow r = dt.Rows[i];
                GroupBox tempGroupBox = CreateGroupBox(paddingX, paddingY, "Contestant# " + r["ContestantNo"].ToString(),r["ContestantID"].ToString());

                PictureBox pic = GeneratePictureBox(20, 30, db.DuplicateImage(r["PhotoPath"].ToString()));
                tempGroupBox.Controls.Add(pic);

                PictureBox icon = GeneratePictureBox(tempGroupBox.Size.Width - (locx * 2), locy, db.DuplicateImage(Environment.CurrentDirectory + "\\Picture\\" + (HasScoreAlready(r["contestantid"].ToString()) ? "ok" : "no") + ".png"));
                icon.Size = new Size(20, 20);
                pictures[i] = icon;
                tempGroupBox.Controls.Add(icon);

                tempGroupBox.Controls.Add(GenerateLabel(240, 50, r["Fullname"].ToString() + "\n\n" + r["Details"].ToString()));

                Button tempButton = GenerateButton(width - 300, height - 50, (hasScore? "Update" : "Input") + " Score for C# " + r["ContestantNo"].ToString(),r["ContestantID"].ToString());
                tempButton.Click += new EventHandler(ClickMe);
                buttons[i] = tempButton;
                tempGroupBox.Controls.Add(tempButton);

                panel.Controls.Add(tempGroupBox);
                paddingX += PADDING + width;
                if (i % 2 == 1)
                {
                    paddingY += PADDING + height;
                    paddingX -= PADDING + width + width + paddingZ; 
                }
            }
            this.Controls.Add(panel);
        }

        public bool HasScoreAlready(string id)
        {
            judgeid = db.GetID("SELECT * FROM tbluser WHERE userid = " + frmLogin.userid + "", "judgeid").ToString();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT COUNT(*) as 'c' FROM tblscoring WHERE  contestantID = " + id + " AND judgeid = " +judgeid+"", db.OpenConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (!dt.Rows[0]["c"].ToString().Equals("0"))
                {
                    hasScore = true;
                    return true;
                }
            }
            hasScore = false;
            return false;
        }

        public int GetButtonIndex(Button b)
        {
            int retVal = -1;
            for (int i = 0; i < buttons.Length; i++)
            {
                if (b == buttons[i])
                    retVal = i;
            }
            return retVal;
        }

        public void ClickMe(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Button btn = (Button)sender;
                selectedContestant = GetButtonIndex(btn);
                string[] temp = btn.Text.Split('#');
                frmInputScore1.contestantID = temp[1].Trim();
                frmInputScore1.contestantTrueID = btn.Name;
                //pictures[Convert.ToInt64(temp[temp.Length - 1]) - 1].ImageLocation = Environment.CurrentDirectory + "\\Picture\\5.png";
                frmInputScore1 score = new frmInputScore1();
                score.Show();
                //MessageBox.Show("This must be saved");
                // btn.Enabled = false;
            }
            //MessageBox.Show(button.Text);
        }
        public void NumbersOnly(ref object sender, ref KeyPressEventArgs e, bool withDecPoint)
        {
            if (withDecPoint)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    e.Handled = true;
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                    e.Handled = true;
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
        public void CheckScore(object sender, KeyPressEventArgs e)
        {
            NumbersOnly(ref sender, ref e, true);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hasUpdated)
            {
                if (selectedContestant != -1)
                {
                    pictures[selectedContestant].Image = Image.FromFile(Environment.CurrentDirectory + "\\Picture\\ok.png");
                    buttons[selectedContestant].Text = buttons[selectedContestant].Text.Replace("Input", "Update");
                    selectedContestant = -1;
                }
                hasUpdated = false;
            }
        }
    }
}
