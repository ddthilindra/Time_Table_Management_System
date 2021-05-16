using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace app.Forms.Lecturer
{
    public partial class Add_Lecturer : Form
    {
        public string lecid, lecName, lecCenter, lecFaculty, lecDepartment, lecBuilding, lecLevel, lecWD, lecWH, lecRank;

        public void updateLecInfo()
        {
            lblAddLec.Text = "Update Lecturer";
            btnAddLecSub.Text = "Update";
            txtLecturerId.Text = lecid;
            txtName.Text = lecName;
        }

        public void addLecInfo()
        {
            lblAddLec.Text = "Add Lecturer";
            btnAddLecSub.Text = "Submit";
            
        }

        ClassLecturer c = new ClassLecturer();

        static Add_Lecturer _obj;

        public static Add_Lecturer Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Add_Lecturer();
                }
                return _obj;
            }
        }

        static string myconstr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        SqlConnection con = new SqlConnection(myconstr);

        public Add_Lecturer()
        {
            InitializeComponent();
        }        

        private void btnAddLecSub_Click(object sender, EventArgs e)
        {

            c.LecturerID = txtLecturerId.Text;
            c.Name = txtName.Text;
            c.Faculty = ddFaculty.selectedValue.ToString();
            c.Center = ddCenter.selectedValue.ToString();
            c.Department = ddDepartment.selectedValue.ToString();
            c.Level = ddLevel.selectedValue.ToString();
            c.Building = ddBuilding.selectedValue.ToString();
            c.WorkingDay = ddWorkingD.selectedValue.ToString();
            c.WorkingHours = ddWorkingH.selectedValue.ToString();
            c.Rank = rankOut.Text;

            bool success = c.insertLecturer(c);

            if(success==true)
            {
                MessageBox.Show("Successfully Inserted");
                
            }
            else
            {
                MessageBox.Show("Faild.Try Again !");
            }

            btnAddLecSub.Visible = false;
                       
        }

        private void btnGenRank_Click(object sender, EventArgs e)
        {
            if (isformValid())
            {
                string level = ddLevel.selectedValue.ToString();
                string id = txtLecturerId.Text;
                rankOut.Font = new Font(rankOut.Font,FontStyle.Bold);
                rankOut.ForeColor= SystemColors.ControlText;
                if (level == "Professor")
                {
                    rankOut.Text = 1 + "." + id;
                }
                else if (level == "Assistant Professor")
                {
                    rankOut.Text = 2 + "." + id;
                }
                else if (level == "Senior Lecturer(HG)")
                {
                    rankOut.Text = 3 + "." + id;
                }
                else if (level == "Senior Lecturer")
                {
                    rankOut.Text = 4 + "." + id;
                }
                else if (level == "Lecturer")
                {
                    rankOut.Text = 5 + "." + id;
                }
                else if (level == "Assistant Lecturer")
                {
                    rankOut.Text = 6 + "." + id;
                }

                btnAddLecSub.Visible = true;
            }
        }

        private bool isformValid()
        {
            if (txtLecturerId.Text.ToString().Trim() == string.Empty || txtName.Text.ToString().Trim() == string.Empty || ddFaculty.selectedValue.ToString().Trim() == string.Empty || ddCenter.selectedValue.ToString().Trim() == string.Empty || ddDepartment.selectedValue.ToString().Trim() == string.Empty || ddLevel.selectedValue.ToString().Trim() == string.Empty || ddBuilding.selectedValue.ToString().Trim() == string.Empty || ddWorkingD.selectedValue.ToString().Trim() == string.Empty || ddWorkingH.selectedValue.ToString().Trim() == string.Empty )
            {
                MessageBox.Show("Requred Field", "asadsadasd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Add_Lecturer_Load(object sender, EventArgs e)
        {               
            loadFaculty();
            loadBuilding();
            loadCenter();
            loadDepartment();
            loadLevel();
            loadWorkingDay();
            loadWorkingHours();

            if(btnAddLecSub.Text== "Update")
            {
                c.updateLecturer(c);
            }
        }

        public void clear()
        {
            txtLecturerId.Text=txtName.Text= rankOut.Text=string.Empty;
        }

        public void loadFaculty()
        {
            ddFaculty.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Faculty FROM addlecfill";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ddFaculty.Items.Add(dr["Faculty"].ToString());
            }

            con.Close();
        }

        public void loadDepartment()
        {
            ddDepartment.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Department FROM addlecfill";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ddDepartment.Items.Add(dr["Department"].ToString());
            }

            con.Close();
        }

        public void loadCenter()
        {
            ddCenter.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Center FROM addlecfill";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ddCenter.Items.Add(dr["Center"].ToString());
            }

            con.Close();
        }

        public void loadBuilding()
        {
            ddBuilding.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Building FROM addlecfill";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ddBuilding.Items.Add(dr["Building"].ToString());
            }

            con.Close();
        }

        public void loadLevel()
        {
            ddLevel.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Level FROM addlecfill";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ddLevel.Items.Add(dr["Level"].ToString());
            }

            con.Close();
        }

        public void loadWorkingDay()
        {
            ddWorkingD.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT WD FROM addlecfill";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ddWorkingD.Items.Add(dr["WD"].ToString());
            }

            con.Close();
        }
        
        public void loadWorkingHours()
        {
            ddWorkingH.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT WH FROM addlecfill";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ddWorkingH.Items.Add(dr["WH"].ToString());
            }

            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
