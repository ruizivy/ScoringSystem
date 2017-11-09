using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using ScoringSystemRuizIvyrose;

namespace MyDBUtilities
{
    class MyUtilities
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adptr;

        string connquery = "SERVER=localhost;" + "PORT = 3306;" +
                        "DATABASE= scoring_db;" + "UID = root;" + "PASSWORD=sehun;";
        public MyUtilities()
        {
            cmd = new MySqlCommand();
            adptr = new MySqlDataAdapter();
        }
        public MySqlConnection OpenConnection()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = connquery;//ReadFromIniFile();
            try
            {
                conn.Open();
                return conn;
            }
            catch
            {
                return null;
            }
        }
        public DataTable SelectQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                adptr = new MySqlDataAdapter(query, OpenConnection());
                adptr.Fill(dt);
                adptr.Dispose();
                CloseConnection();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        private string ReadFromIniFile()
        {
            string text = string.Empty;
            if (!File.Exists(frmLogin.dir + "\\settings.ini"))
                File.WriteAllText(frmLogin.dir + "\\settings.ini", "");
            else
            {
                string[] datas = File.ReadAllLines(frmLogin.dir + "\\settings.ini");
                foreach (string s in datas)
                    text += s;
            }
            return text;
        }
        public void CloseConnection()
        {

            if (conn.State == ConnectionState.Open)
                conn.Close();

        }
        public bool IsConnectionValid(string connStr)
        {
            conn.ConnectionString = connStr;
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void InsertQuery(string query)
        {
            cmd.CommandText = query;
            try
            {
                cmd.Connection = OpenConnection();
                int res = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public Image DuplicateImage(string path)
        {
            if (path.Equals(""))
            {
                return null;
            }
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }

        }
        public string CorrectCasing(string source)
        {
            string retval = "";
            if (source.Contains(' '))
            {
                string[] temp = source.Split(' ');
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i].Length > 1)
                        retval += temp[i].Substring(0, 1).ToUpper() + temp[i].Substring(1).ToLower() + " ";
                    else
                        retval += temp[i].ToUpper();
                }
            }
            else
                retval += source.Substring(0, 1).ToUpper() + source.Substring(1).ToLower() + " ";
            retval = retval.Trim();
            return retval;
        }
        public long GetID(string query, string colname)
        {
            DataTable dt = SelectQuery(query);
            if (dt.Rows.Count != 0)
            {
                DataRow r = dt.Rows[0];
                long i = Convert.ToInt64(r[colname].ToString());
                return i;
            }
            else
                return 0;
        }
        public void LimitTo(ref object sender, ref KeyPressEventArgs e, double count)
        {
            TextBox txtbox = (TextBox)sender;
           
                if (!txtbox.Text.Equals("") && !txtbox.Text.Equals(".") && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) )
                {
                    double temp = Convert.ToDouble(txtbox.Text + e.KeyChar);
                    if (temp > count)
                        e.Handled = true;
                }
            //&& e.KeyChar == '.'
        }
        public void TextHandler(ref object sender, ref KeyPressEventArgs e, bool IsDigit)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && IsDigit)
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSymbol(e.KeyChar) && !IsDigit && !char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }
        public void DecimalHandler(ref object sender, ref KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Contains(".") && e.KeyChar == '.')
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }
    }
}
