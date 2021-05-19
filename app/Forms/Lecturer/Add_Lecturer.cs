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
        //Create new object from ClassLecturer class
        ClassLecturer c = new ClassLecturer();

        //Creating object from this Show_Lecturer to access this form in main menu
        Show_Lecturer form;

        //Create new object to get access for navigation button
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

        //Creating variable to set the table value to form
        public string id, lecid, lecName, lecCenter, lecFaculty, lecDepartment, lecBuilding, lecLevel, lecWD, lecWH, lecRank,setLevel;

        //Call Connection string get database info
        static string myconstr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //Database Connection
        SqlConnection con = new SqlConnection(myconstr);

        public Add_Lecturer()
        {
            InitializeComponent();
        }

        //Method for submit the add & update Lecturer form
        private void btnAddLecSub_Click(object sender, EventArgs e)
        {
            //get value from input field
            c.ID = lblIndex.Text;
            c.LecturerID = txtLecturerId.Text.Trim();
            c.Name = txtName.Text;
            c.Faculty = ddFaculty.Text.Trim();
            c.Center = ddCenter.Text.Trim();
            c.Department = ddDepartment.Text.Trim();
            c.Level = setLevel;
            c.Building = ddBuilding.Text.Trim();
            c.WorkingDay = ddWorkingD.Text.Trim();
            c.WorkingHours = ddWorkingH.Text.Trim();
            c.Rank = rankOut.Text;

            //Submit the add lecturer form
            if (btnAddLecSub.Text == "Submit")
            {
                //call chkLecID method (check lecturer id alredy in db)
                
                bool exist = c.chkLecID(txtLecturerId.Text.Trim());

                if (exist == false)
                {
                    rankOut.Text = "";        //if alredy exist set the genarated id is empty
                    btnAddLecSub.Visible = false;       //Create one time click button
                }

                //inserting data in to database using insertLecturer method
                if (exist == true)
                {
                    bool success = c.insertLecturer(c);

                    if (success == true)
                    {
                        MessageBox.Show("Lecturer was added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Somthing went Worng!\n\nCannot insert the value!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    btnAddLecSub.Visible = false;       //Create one time click button
                }

            }

            //Submit the update lecturer form
            if (btnAddLecSub.Text == "Update")
            {
                //inserting data in to database using insertLecturer method
                bool success = c.updateLecturer(c);

                if (success == true)
                {
                    MessageBox.Show("Update successful", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update Failed", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnAddLecSub.Visible = false;       //Make one time click submit button
            }

        }

        //Method to genarate the lecurer rank
        private void btnGenRank_Click(object sender, EventArgs e)
        {
            if (isformValid())
            {
                string level = ddLevel.Text.Trim();
                string id = txtLecturerId.Text;
                rankOut.Font = new Font(rankOut.Font, FontStyle.Bold);
                rankOut.ForeColor = SystemColors.ControlText;
                if (level == "Professor")
                {
                    setLevel = "1";
                    rankOut.Text = 1 + "." + id;
                }
                else if (level == "Assistant Professor")
                {
                    setLevel = "2";
                    rankOut.Text = 2 + "." + id;
                }
                else if (level == "Senior Lecturer(HG)")
                {
                    setLevel = "3";
                    rankOut.Text = 3 + "." + id;
                }
                else if (level == "Senior Lecturer")
                {
                    setLevel = "4";
                    rankOut.Text = 4 + "." + id;
                }
                else if (level == "Lecturer")
                {
                    setLevel = "5";
                    rankOut.Text = 5 + "." + id;
                }
                else if (level == "Assistant Lecturer")
                {
                    setLevel = "6";
                    rankOut.Text = 6 + "." + id;
                }
                //If click genarate button submit button will be visible otherwise not visible
                btnAddLecSub.Visible = true;
            }
        }

        //Method to form validation
        private bool isformValid()
        {
            if (txtLecturerId.Text.ToString().Trim() == string.Empty || txtName.Text.ToString().Trim() == string.Empty || ddFaculty.Text.Trim() == string.Empty || ddCenter.Text.Trim() == string.Empty || ddDepartment.Text.Trim() == string.Empty || ddLevel.Text.Trim() == string.Empty || ddBuilding.Text.Trim() == string.Empty || ddWorkingD.Text.Trim() == string.Empty || ddWorkingH.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out the all field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        //Form load
        private void Add_Lecturer_Load(object sender, EventArgs e)
        {
            //Load the drop down data to from
            loadFaculty();
            loadBuilding();
            loadCenter();
            loadDepartment();
            loadLevel();
            loadWorkingDay();
            loadWorkingHours();

            //if button text update, Then table value set to update form
            if (btnAddLecSub.Text == "Update")
            {
                lblAddLec.Text = "Update Lecturer";                
                txtLecturerId.ReadOnly = true;          //User cannot edit id, Read ony

                lblIndex.Text = id;
                txtLecturerId.Text = lecid;
                txtName.Text = lecName;
                ddFaculty.Text = lecFaculty;
                ddDepartment.Text = lecDepartment;
                ddCenter.Text = lecCenter;
                ddBuilding.Text = lecBuilding;
                ddLevel.Text = lecLevel;
                ddWorkingD.Text = lecWD;
                ddWorkingH.Text = lecWH;

                //set lecturer level index to lecturer Category
                if (lecLevel == "1")
                {
                    ddLevel.Text = "Professor";
                }
                else if (lecLevel == "2")
                {
                    ddLevel.Text = "Assistant Professor";
                }
                else if (lecLevel == "3")
                {
                    ddLevel.Text = "Senior Lecturer(HG)";
                }
                else if (lecLevel == "4")
                {
                    ddLevel.Text = "Senior Lecturer";
                }
                else if (lecLevel == "5")
                {
                    ddLevel.Text = "Lecturer";
                }
                else if (lecLevel == "6")
                {
                    ddLevel.Text = "Assistant Lecturer";
                }
            }

            //Make the all feild as empty field
            if (btnAddLecSub.Text == "Submit")
            {
                txtLecturerId.Text = string.Empty;
                ddFaculty.Text = "";
                ddDepartment.Text = "";
                ddCenter.Text = "";
                ddBuilding.Text = "";
                ddLevel.Text = "";
                ddWorkingD.Text = "";
                ddWorkingH.Text = "";
                txtLecturerId.ReadOnly = false;
            }
        }

        private void ddBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        //Method to only allow digit to insert lecturer id text box
        private void txtLecturerId_KeyPress(object sender, KeyPressEventArgs e)
        {            
            char ch = e.KeyChar;
            //set text box to number only field, if user enter string Worning message will be display, allow 8 is for backspace button and 46 for delete button
            if (!Char.IsDigit(ch) && ch!=8 && ch!=46)
            {
                e.Handled = true;
                MessageBox.Show("This field accept number only.!!!\n\nPlease enter 6 digit lecturer id", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //check lecturer id text box have 6 digit,If more than 6 digit. Worning message will be display            
            if(txtLecturerId.Text.Length  >= 6)
            {
                MessageBox.Show("You have exceedede the maximum number of 6 digit in this field.!!!\n\nPlease enter 6 digit lecturer id", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLecturerId_Load(object sender, EventArgs e)
        {
            
        }

        //Method to clear all input field
        public void clear()
        {
            if (btnAddLecSub.Text == "Submit")
            {
                txtLecturerId.Text = string.Empty;
            }

            txtName.Text = string.Empty;
            rankOut.Text = "@";
            ddFaculty.Text = string.Empty;
            ddDepartment.Text = string.Empty;
            ddCenter.Text = string.Empty;
            ddBuilding.Text = string.Empty;
            ddLevel.Text = string.Empty;
            ddWorkingD.Text = string.Empty;
            ddWorkingH.Text = string.Empty;
        }

        //Load the Faculty drop down data from table
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

        //Load the Department drop down data from table
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

        //Load the Center drop down data from table
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

        //Load the Building drop down data from table
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

        //Load the Level drop down data from table
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

        //Load the WorkingD drop down data from table
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

        //Load the WorkingH drop down data from table
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

        //Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        //Method to Set changed botton of text to submit text and othe content
        public void addLecInfo()
        {
            lblAddLec.Text = "Add Lecturer";
            btnAddLecSub.Text = "Submit";
            btnAddLecSub.Visible = false;
        }

        //Method to change submit button text to update 
        public void updateLecInfo()
        {
            btnAddLecSub.Text = "Update";
        }

        //Method to close the form
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
