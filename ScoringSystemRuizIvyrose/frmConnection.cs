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

namespace ScoringSystemRuizIvyrose
{
    public partial class frmConnection : Form
    {
        MyUtilities db = new MyUtilities();
        string connStr;
        bool isNotDone = true;
        public frmConnection()
        {
            InitializeComponent();
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {

        }
     
        public void TestConnection()
        {
            connStr = "SERVER=" + txtserver.Text + ";" +
                "PORT=" + txtport.Text + ";" +
                "UID=" + txtuid.Text + ";" +
                "DATABASE=" + txtdatabase.Text + ";" +
                "PASSWORD=" + txtpassword.Text + ";";
            if (db.IsConnectionValid(connStr))
                MessageBox.Show("Connection Valid!");
            else
                MessageBox.Show("Invalid Connection!");
        }
        public void Apply()
        {
            if (db.IsConnectionValid(connStr))
            {
                string[] arr = new string[5];
                arr[0] = "SERVER=" + txtserver.Text + ";";
                arr[1] = "PORT=" + txtport.Text + ";";
                arr[2] = "UID=" + txtuid.Text + ";";
                arr[3] = "DATABASE=" + txtdatabase.Text + ";";
                arr[4] = "PASSWORD=" + txtpassword.Text + ";";
                File.WriteAllLines(frmLogin.dir + "\\settings.ini", arr);
                isNotDone = false;
                this.Close();
            }
        }

        private void frmConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && isNotDone)
                Environment.Exit(1);
        }

        private void btntest_Click_1(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void btnapply_Click_1(object sender, EventArgs e)
        {
            TestConnection();
            Apply();
        }
    }
}
