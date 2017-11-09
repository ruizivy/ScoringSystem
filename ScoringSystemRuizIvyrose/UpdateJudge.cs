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
    public partial class frmUpdateJudge : Form
    {
        MyUtilities db = new MyUtilities();
        MySqlDataAdapter adptr;
        MySqlCommand cmd;
        DataTable table;
        public long judgeid;
        private static long judgeuserid;
        private string userid = frmLogin.userid;

        public frmUpdateJudge()
        {
            InitializeComponent();
            table = new DataTable();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void frmUpdateJudge_Load(object sender, EventArgs e)
        {
            rdbAdmin.Enabled = false;
            rdbjudge.Checked = true;
            PopulateRecords();
        }
        public void PopulateRecords()
        {
            lstJudge.Items.Clear();
            table.Clear();
            string query = "SELECT * FROM get_details";
            adptr = new MySqlDataAdapter(query, db.OpenConnection());
            db.CloseConnection();
            adptr.Fill(table);

            foreach(DataRow row in table.Rows)
            {
                ListViewItem itm = new ListViewItem(row["JudgeID"].ToString());
                itm.SubItems.Add(row["username"].ToString());
                itm.SubItems.Add(row["userpassword"].ToString());
                itm.SubItems.Add(row["UserType"].ToString());
                itm.SubItems.Add(row["JudgeFName"].ToString());
                itm.SubItems.Add(row["Details"].ToString());
                lstJudge.Items.Add(itm);
            }
        }

        private void lstJudge_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Update";
            ListViewItem itm = lstJudge.SelectedItems[0];
            judgeid = Convert.ToInt64(itm.Text);
            txtUser.Text = itm.SubItems[1].Text;
            txtPass.Text = itm.SubItems[2].Text;
            txtFname.Text = itm.SubItems[4].Text;
            txtAddr.Text = itm.SubItems[5].Text;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            judgeuserid = db.GetID("SELECT  * FROM tbluser INNER JOIN tbljudge WHERE JudgeFName ='" +txtFname.Text+"' AND Details ='"+txtAddr.Text+"'", "userid");
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to update the selected judge?",
                "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) && !userid.Equals("0"))
            {
                db.InsertQuery("UPDATE scoring_db.tbljudge SET JudgeFName = '" + txtFname.Text + "', Details = '" + txtAddr.Text + "'  WHERE JudgeID = " + judgeid + "");
                db.InsertQuery("UPDATE scoring_db.tbluser SET username = '" + txtUser.Text + "', userpassword = '" + txtPass.Text + "' WHERE userid = " +  judgeuserid  + "");
                MessageBox.Show("Record update Successfully!", "Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateRecords();
            }
        }

        private void lstJudge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
