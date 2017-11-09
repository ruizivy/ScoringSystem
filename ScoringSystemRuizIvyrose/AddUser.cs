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
    public partial class frmAddUser : Form
    {
        MyUtilities db = new MyUtilities();
        MySqlCommand cmd;
        public long judgeid;
        private long userid;
       
        public frmAddUser()
        {
            InitializeComponent();
            lblwarning.Visible = false;
           
        }
        private void frmAddJudge_Load(object sender, EventArgs e)
        {
            grbJudge.Enabled = false;
        }
        public void Judgeuser()
        {
            if (IsInputValid(false))
            {
                
                cmd = new MySqlCommand("insert_judge", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?judgeFname", db.CorrectCasing(txtJFName.Text)));
                cmd.Parameters.Add(new MySqlParameter("?details", db.CorrectCasing(txtDetails.Text)));
                cmd.Parameters.Add(new MySqlParameter("?jtype", "Insert"));
                cmd.Parameters.Add(new MySqlParameter("judgeid1", judgeid));
                cmd.ExecuteNonQuery();

                judgeid = db.GetID("SELECT JudgeID FROM tbljudge WHERE JudgeFName = '" + txtJFName.Text + 
                    "' AND Details = '" + txtDetails.Text + "'", "JudgeID");

                cmd = new MySqlCommand("insert_user", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?user", txtuser.Text));
                cmd.Parameters.Add(new MySqlParameter("?pass", txtpass.Text));
                cmd.Parameters.Add(new MySqlParameter("?usertype", "judge"));
                cmd.Parameters.Add(new MySqlParameter("judgeid1", judgeid));
                cmd.Parameters.Add(new MySqlParameter("utype", "Insert"));
                cmd.Parameters.Add(new MySqlParameter("userid1", this.userid));
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("insert_user", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?user", txtuser.Text));
                cmd.Parameters.Add(new MySqlParameter("?pass", txtpass.Text));
                cmd.Parameters.Add(new MySqlParameter("?usertype", "judge"));
                cmd.Parameters.Add(new MySqlParameter("judgeid1", judgeid));
                cmd.Parameters.Add(new MySqlParameter("utype", "Update"));
                cmd.Parameters.Add(new MySqlParameter("userid1", this.userid));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Save!!!");
                db.CloseConnection();
                this.Close();
            }
        }
        public void ProcessUser(bool isAdmin)
        {
                if (IsInputValid(isAdmin))
                {
                        cmd = new MySqlCommand("insert_user", db.OpenConnection());
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?user", txtuser.Text));
                        cmd.Parameters.Add(new MySqlParameter("?pass", txtpass.Text));
                        cmd.Parameters.Add(new MySqlParameter("?usertype", (isAdmin ? "admin" : "judge")));
                        cmd.Parameters.Add(new MySqlParameter("judgeid1", judgeid));
                        cmd.Parameters.Add(new MySqlParameter("utype", "Insert"));
                        cmd.Parameters.Add(new MySqlParameter("userid1", userid));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Succesfully saved user", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        judgeid = 0;
                        Clear();
                        db.CloseConnection();
                }
        }
        public string Status()
        {
            if (rdbAdmin.Checked == true)
                return "admin";
            else if (rdbJudge.Checked == true)
                return "judge";
            else
                return "";
        }
        public void Clear()
        {
            txtDetails.Text = "";
            txtJFName.Text = "";
            txtpass.Text = "";
            txtuser.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure do you want to proceed?",
               "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (rdbAdmin.Checked)
                    ProcessUser(rdbAdmin.Checked);
                else if (rdbJudge.Checked)
                    Judgeuser();
            }
        }
        private bool IsInputValid(bool IsAdmin)
        {
            DataTable dtUser = db.SelectQuery("SELECT * FROM tbluser WHERE username = '" + txtuser.Text + "'");
            DataTable dtJudge = db.SelectQuery("SELECT * FROM tbljudge WHERE JudgeFName = '" + txtJFName.Text + "'");
            if (txtuser.Text != null && txtpass.Text != null)
            {
                if (dtUser.Rows.Count != 0)
                {
                    MessageBox.Show("Username Already Exist!",
                        "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                MessageBox.Show("Please fill up the whole form!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!IsAdmin)
            {
                if (txtJFName.Text == null && txtDetails.Text == null)
                    return false;
            }
            return true;
        }
        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdbJudge_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked == true)
                grbJudge.Enabled = false;
            else
                grbJudge.Enabled = true;
        }
    }
}
