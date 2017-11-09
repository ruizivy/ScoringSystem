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
using MySql.Data.MySqlClient;
using MySql.Data;

namespace ScoringSystemRuizIvyrose
{
    public partial class frmDeleteContestant : Form
    {
        MySqlCommand cmd;
        MySqlDataAdapter adptr;
        MyUtilities db = new MyUtilities();
        DataTable table;
        public long conID;

        public frmDeleteContestant()
        {
            InitializeComponent();
            table = new DataTable();

        }

        private void frmDeleteContestant_Load(object sender, EventArgs e)
        {
            PopulateRecords();
        }
        public void PopulateRecords()
        {
            lstcontestant.Items.Clear();
            table.Clear();

            adptr = new MySqlDataAdapter("SELECT * FROM tblcontestant ORDER BY ContestantNo", db.OpenConnection());
            adptr.Fill(table);
            db.CloseConnection();
            foreach (DataRow row in table.Rows)
            {
                ListViewItem itm = new ListViewItem(row["ContestantID"].ToString());
                itm.SubItems.Add(row["ContestantNo"].ToString());
                itm.SubItems.Add(row["Fullname"].ToString());
                itm.SubItems.Add(row["Details"].ToString());
                itm.SubItems.Add(row["PhotoPath"].ToString());
                lstcontestant.Items.Add(itm);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete the selected contestant?",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) && !conID.Equals("0"))
            {
                db.InsertQuery("DELETE FROM tblcontestant WHERE ContestantID =" + conID);
                MessageBox.Show("Record deleted Successfully!", "Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateRecords();
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            //int itm = listView1.SelectedIndices[0];
            ListViewItem itm = lstcontestant.SelectedItems[0];
            conID = Convert.ToInt64(itm.Text);

        }
    }
}
