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
using MySql.Data;
using MySql.Data.MySqlClient;
using MyDBUtilities;

namespace ScoringSystemRuizIvyrose
{
    public partial class frmAddContestant : Form
    {
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        MySqlDataReader r;
        MyUtilities db = new MyUtilities();
        DataTable table = new DataTable();
        private string path = "";
        bool isDone = true;
        private long update_id = 0;
        private long prevNum = 0;

        public frmAddContestant()
        {
            InitializeComponent();
            lblWarning.Visible = false;
            PopulateRecords();
        }
        private void ClearAllInfo()
        {
            txtConNum.Text = "";
            txtName.Text = "";
            txtRemarks.Text = "";
            path = "";
            update_id = 0;
            picCon.Image = db.DuplicateImage(Environment.CurrentDirectory + "\\Picture\\default.jpg");
            prevNum = 0;
        }
        public bool IsAllInfoValid(string cons)
        {
            string query = "SELECT * FROM tblcontestant WHERE Fullname ='" + txtName.Text + "'" + cons;
            DataTable dt = db.SelectQuery(query);
            if (txtName.Text.Equals("") || txtConNum.Text.Equals("") && txtRemarks.Text.Equals(""))
            {
                MessageBox.Show("Please fillup the whole form.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            txtName.Text = db.CorrectCasing(txtName.Text);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Name already exist!", "Information Duplicate",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            query = "SELECT * FROM tblcontestant WHERE ContestantNo =" + txtConNum.Text + cons;
            dt = db.SelectQuery(query);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Contestant number already exist!",
                    "Information Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (path.Equals(""))
            {
                MessageBox.Show("Please insert Contestant's image.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                if (!txtConNum.Text.Equals(prevNum))
                {
                    //path = path.Replace("\\", "\\\\");
                    File.Copy(@path, Application.StartupPath + "\\Picture\\" + path.Substring(path.LastIndexOf("\\")), true);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Failed to use current Image.", "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Save Information?",
                "Save Datas", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (btnSave.Text.Equals("Save"))
                {
                    if (IsAllInfoValid(""))
                        SaveContestant();
                }
                else if(btnSave.Text.Equals("Update"))
                {
                        
                    UpdateContestant();
                }
            }
        }
        private void SavePhoto()
        {
            if (!path.Equals(""))
            {
                try
                {
                    File.Copy(path, Application.StartupPath + "\\Picture\\" + path.Substring(path.LastIndexOf("\\")));
                }
                catch (Exception e)
                {

                }
            }
        }

        public void SaveContestant()
        {
            cmd = new MySqlCommand("insert_contestant", db.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?ConNum", txtConNum.Text));
            cmd.Parameters.Add(new MySqlParameter("?fullname", db.CorrectCasing(txtName.Text)));
            cmd.Parameters.Add(new MySqlParameter("?details", txtRemarks.Text));
            cmd.Parameters.Add(new MySqlParameter("?photopath", Application.StartupPath + "\\Picture\\" + path.Substring(path.LastIndexOf("\\"))));
            cmd.Parameters.Add(new MySqlParameter("?ctype", "Insert"));
            cmd.Parameters.Add(new MySqlParameter("?conid", update_id));
            cmd.ExecuteNonQuery();
            PopulateRecords();
            ClearAllInfo();
            MessageBox.Show("Successfully saved!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public void UpdateContestant()
        {
            try
            {
                cmd = new MySqlCommand("insert_contestant", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?ConNum", txtConNum.Text));
                cmd.Parameters.Add(new MySqlParameter("?fullname", db.CorrectCasing(txtName.Text)));
                cmd.Parameters.Add(new MySqlParameter("?details", txtRemarks.Text));
                cmd.Parameters.Add(new MySqlParameter("?photopath", Application.StartupPath + "\\Picture\\" + path.Substring(path.LastIndexOf("\\"))));
                cmd.Parameters.Add(new MySqlParameter("?ctype", "Update"));
                cmd.Parameters.Add(new MySqlParameter("?conid", update_id));
                cmd.ExecuteNonQuery();
                PopulateRecords();
                ClearAllInfo();
                MessageBox.Show("Update Sucess", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.CloseConnection();

                btnSave.Text = "Save";
                lstContestant.Enabled = true;
               
            }
            catch (Exception ex)
            {
 
            }
        }
        public void PopulateRecords()
        {
            lstContestant.Items.Clear();
            table.Clear();

            adpt = new MySqlDataAdapter("SELECT * FROM tblcontestant ORDER BY ContestantNo", db.OpenConnection());
            adpt.Fill(table);
            db.CloseConnection();
            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["ContestantNo"].ToString());
                item.SubItems.Add(row["Fullname"].ToString());
                item.SubItems.Add(row["Details"].ToString());
                item.SubItems.Add(row["PhotoPath"].ToString());
                lstContestant.Items.Add(item);
            }

        }
        private void TextHandler(ref object sender, ref KeyPressEventArgs e, bool withDecimal)
        {
            if (withDecimal)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
        }
        private void txtConNum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            TextHandler(ref sender, ref e, true);
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            path = op.FileName;
            picCon.Image = db.DuplicateImage(path);
            path = path.Replace("\\", "\\\\");
            //path = "C:\\\\Users\\\\" + Environment.UserName.Replace("\\", "\\\\") +
            //    "\\\\Documents\\\\Scoring\\\\Pictures\\\\";
        }

        private void lstContestant_DoubleClick(object sender, EventArgs e)
        {
            lstContestant.Enabled = false;
            btnSave.Text = "Update";
            btnCancel.Visible = true;
            
            ListViewItem items = lstContestant.SelectedItems[0];
            update_id = Convert.ToInt64(items.Text);
            txtConNum.Text = items.SubItems[0].Text;
            txtName.Text = items.SubItems[1].Text;
            txtRemarks.Text = items.SubItems[2].Text;
            path = items.SubItems[3].Text;
            picCon.Image = db.DuplicateImage(path);

           // update_id = itm.Text;
            
        }
        private void lstContestant_Click(object sender, EventArgs e)
        {
           
        }

        private void frmAddContestant_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing && isDone)
            //    Environment.Exit(2);
        }

        private void frmAddContestant_Load_1(object sender, EventArgs e)
        {
            lblnote.Visible = true;
            btnCancel.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Save";
            lstContestant.Enabled = true;
            btnCancel.Visible = false;
            ClearAllInfo();
        }
    }
}
