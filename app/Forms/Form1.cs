using app.Forms;
using SLRDbConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        //DbConnector db;

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\T.V.C\source\repos\app\app\TimeTableDB.mdf;Integrated Security=True;User Instance=True"); 
        public Form1()
        {
            InitializeComponent();
            //db = new DbConnector();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isformValid())
            {

                if (checkLogin())
                {
                    
                    using(Forms.Form_Dashbord fd = new Forms.Form_Dashbord())
                    {
                        fd.ShowDialog();
                    }
                }
            }
        }

        private bool checkLogin()
        {
            con.Open();
            
            SqlDataAdapter ad = new SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE Fname='" + txtUname.Text + "'and Password='" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            
            if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                //new Form_Dashbord().Show();
                con.Close();
                return true;
                } 
            else
                {
                        MessageBox.Show("USer name or Password incorect", "Incorect Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                }

        }

        private bool isformValid()
        {
            if(txtUname.Text.ToString().Trim() == string.Empty || txtPassword.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Requred Field","asadsadasd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
