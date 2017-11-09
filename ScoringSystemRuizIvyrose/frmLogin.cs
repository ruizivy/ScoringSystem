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
using System.IO;

namespace ScoringSystemRuizIvyrose
{
    public partial class frmLogin : Form
    {
        MyUtilities dt = new MyUtilities();
        MySqlDataAdapter adptr;
       
        DataTable table = new DataTable();
        public static string dir = @"C:\Users\" + Environment.UserName + @"\ConnectionString";
        bool isNotDone = true;
        public static string userid;

        public static string admin;

        public frmLogin()
        {
            InitializeComponent();
            lblwarning.Visible = false;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                    ProcessLogin(); 
        }
        public void ProcessLogin()
        {
            try
            {
                adptr = new MySqlDataAdapter("SELECT * FROM tbluser WHERE username ='" + txtuser.Text +"'", dt.OpenConnection());
                table = new DataTable();
                adptr.Fill(table);
                dt.CloseConnection();

                foreach (DataRow row in table.Rows)
                {
                    if (txtuser.Text.Equals(row["username"].ToString()))
                    {
                        if (txtpass.Text.Equals(row["userpassword"].ToString()))
                        {
                            string type = row["UserType"].ToString();
                            userid = row["userid"].ToString();
                            frmMain.IsAdmin = (type.Equals("admin") ? true : false);
                            frmMain.IsLogin = true;
                            frmMain main = new frmMain();
                            main.Show();
                            isNotDone = false;
                            this.Hide();
                        }
                        else
                            MessageBox.Show("Wrong password!!");
                    }
                    else
                    {
                        lblwarning.Visible = true;
                        MessageBox.Show("User doesn't Exist!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblwarning.Visible = true;
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //if (!File.Exists(dir + "\\settings.ini"))
            //{
            //    if (!Directory.Exists(dir))
            //        Directory.CreateDirectory(dir);
            //    frmConnection conn = new frmConnection();
            //    conn.ShowDialog();
            //}
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && isNotDone)
                Environment.Exit(1);
        }
    }
}
