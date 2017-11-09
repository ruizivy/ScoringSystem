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
    public partial class frmAddCriteria : Form
    {
        MySqlCommand cmd;
        DataTable table;
        MyUtilities db = new MyUtilities();
        Panel panel = new Panel();
        int paddingy = 15;
        int positiony = 40;
        TextBox[] txtCriterias;
        TextBox[] txtAverages;
        int numOfCriteria = 0;

        public frmAddCriteria()
        {
            InitializeComponent();
        }

        private void frmAddCriteria_Load(object sender, EventArgs e)
        {

        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (DialogResult.Yes == MessageBox.Show("Proceed? ", "Finalize Settings",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) && !txtNum.Text.Equals(""))
                {
                    numOfCriteria = Convert.ToInt32(txtNum.Text);
                    int height = ((Convert.ToInt32(txtNum.Text) + 1) * 45) + 70;
                    this.Size = new Size(300, height);
                    lblcriteria.Dispose();
                    txtNum.Dispose();
                    lblwarning.Dispose();
                    GenerateControls();
                }
            }
        }
        public void GenerateControls()
        {
            Panel panel = new Panel();
            panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom)));
            panel.Location = new System.Drawing.Point(5,5);
            panel.Size = new System.Drawing.Size(this.Width - 30, this.Height - 35);
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.AutoScroll = true;
            panel.Controls.Add(GenerateLabel(10, 10, new Size(200, 20), "Criteria Name"));
            panel.Controls.Add(GenerateLabel(220, 10, new Size(70, 20), "Avg in %"));

            txtAverages = new TextBox[numOfCriteria];
            txtCriterias = new TextBox[numOfCriteria];
            for (int i = 0; i < numOfCriteria; i++)
            {
                TextBox txtCrit = GenerateTextBox(10, positiony, new Size(190, 27));
                txtCrit.KeyPress += new KeyPressEventHandler(TextKeyPressLetter);
                txtCriterias[i] = txtCrit;
                panel.Controls.Add(txtCriterias[i]);

                TextBox txtAvg = GenerateTextBox(220, positiony, new Size(50, 27));
                txtAvg.KeyPress += new KeyPressEventHandler(TextKeyPressDecimal);
                txtAvg.KeyPress += new KeyPressEventHandler(limitto);
                txtAverages[i] = txtAvg;
                panel.Controls.Add(txtAverages[i]);
                positiony += 27 + paddingy;
            }
            Button btn = GenerateButton(100, positiony, new Size(100, 36), "Save");
            btn.Click += new EventHandler(btnSave_Click);
            panel.Controls.Add(btn);
            this.Controls.Add(panel);
        }
        public Label GenerateLabel(int x, int y, Size s, string text)
        {
            Label lbl = new Label();
            lbl.Location = new Point(x, y);
            lbl.AutoSize = false;
            lbl.Size = s;
            lbl.Text = text;
            return lbl;
        }
        public TextBox GenerateTextBox(int x, int y, Size s)
        {
            TextBox txt = new TextBox();
            txt.Location = new Point(x, y);
            txt.Size = s;
            return txt;
        }
        public Button GenerateButton(int x, int y, Size s, string text)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = s;
            btn.Text = text;
            return btn;
        }
        public void limitto(object sender, KeyPressEventArgs e)
        {
            db.LimitTo(ref sender, ref e, 100);
        }
        public void TextKeyPressLetter(object sender, KeyPressEventArgs e)
        {
            TextHandle(ref sender, ref e, false);
        }
        public void TextKeyPressDecimal(object sender, KeyPressEventArgs e)
        {
            DecimalHandle(ref sender, ref e);
        }
        public void TextHandle(ref object sender, ref KeyPressEventArgs e, bool IsDigit)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && IsDigit)
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !IsDigit)
                e.Handled = true;
        }
        public void DecimalHandle(ref object sender, ref KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Contains(".") && e.KeyChar == '.')
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        public void btnSave_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to save the following?",
                "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (IsAllInfoValid())
                {
                    Save();
                }
            }
        }
        private bool IsAllInfoValid()
        {
            List<string> textCheck = new List<string>();
            double total = 0;
            for (int i = 0; i < txtAverages.Length; i++)
            {
                if (textCheck.Contains(txtCriterias[i].Text))
                {
                    MessageBox.Show("Criteria names must not be repeated", "Repeated Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                    textCheck.Add(txtCriterias[i].Text);
                if (txtCriterias[i].Text.Equals("") || txtAverages[i].Text.Equals(""))
                {
                    MessageBox.Show("Please complete the requirements", "Insufficient Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                    total += Convert.ToDouble(txtAverages[i].Text);
            }
            if (total != 100.00)
            {
                MessageBox.Show("The total value of all criteria average must be 100%.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void Save()
        {
            List<string> ids = new List<string>();
            table = db.SelectQuery("SELECT * FROM tblcriteria");
            foreach (DataRow r in table.Rows)
                ids.Add(r["CriteriaID"].ToString());
            if (ids.Count > 0)
            {
                for (int i = 0; i < ids.Count; i++)
                    db.InsertQuery("DELETE FROM tblcriteria WHERE CriteriaID =" + ids[i]);
            }
            for (int i = 0; i < numOfCriteria; i++)
            {     
                cmd = new MySqlCommand("insert_criteria", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?criteria_name", db.CorrectCasing(txtCriterias[i].Text)));
                cmd.Parameters.Add(new MySqlParameter("?percentage", "."+txtAverages[i].Text));
                cmd.Parameters.Add(new MySqlParameter("?isinsert", "1"));
                cmd.Parameters.Add(new MySqlParameter("criteria_ID", 0));
                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
            MessageBox.Show("All criteria is successfully saved!!", "Saved",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
