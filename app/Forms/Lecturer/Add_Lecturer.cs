﻿using System;
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
        //Creating object from this Show_Lecturer to access this form in main menu
        ClassLecturer c = new ClassLecturer();

        Show_Lecturer form;

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
        public string id, lecid, lecName, lecCenter, lecFaculty, lecDepartment, lecBuilding, lecLevel, lecWD, lecWH, lecRank;

        //Method to change addlecturer form content
        public void updateLecInfo()
        {
            btnAddLecSub.Text = "Update";            
        }

        //Call Connection string get database info
        static string myconstr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //Database Connection
        SqlConnection con = new SqlConnection(myconstr);

        public Add_Lecturer()
        {
            InitializeComponent();
        }        

        private void btnAddLecSub_Click(object sender, EventArgs e)
        {
            //get value from input field
            c.ID = lblIndex.Text;
            c.LecturerID = txtLecturerId.Text.Trim();
            c.Name = txtName.Text;
            c.Faculty = ddFaculty.Text.Trim();
            c.Center = ddCenter.Text.Trim();
            c.Department = ddDepartment.Text.Trim();
            c.Level = ddLevel.Text.Trim();
            c.Building = ddBuilding.Text.Trim();
            c.WorkingDay = ddWorkingD.Text.Trim();
            c.WorkingHours = ddWorkingH.Text.Trim();
            c.Rank = rankOut.Text;

            //Set changed botton of text to submit text if addlecturer form change to update form
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
                if (exist== true)
                {
                    bool success = c.insertLecturer(c);

                    if (success == true)
                    {
                        MessageBox.Show("Successfully Inserted", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Insert Failed", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    btnAddLecSub.Visible = false;       //Create one time click button
                }

            }

            if (btnAddLecSub.Text == "Update")
            {
                //inserting data in to database using insertLecturer method
                bool success = c.updateLecturer(c);

                if (success == true)
                {
                    MessageBox.Show("Successfully Updated", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Failed", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnAddLecSub.Visible = false;       //Make one time click submit button
            }

        }

        //Method to Set changed botton of text to submit text
        public void addLecInfo()
        {
            lblAddLec.Text = "Add Lecturer";
            btnAddLecSub.Text = "Submit";
        }

        //Method to genarate the rank
        private void btnGenRank_Click(object sender, EventArgs e)
        {
            if (isformValid())
            {
                string level = ddLevel.Text.Trim();
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
                //If click genarate button submit button will be visible otherwise not visible
                btnAddLecSub.Visible = true;    
            }
        }

        //Method to check form input are filled
        private bool isformValid()
        {
            if (txtLecturerId.Text.ToString().Trim() == string.Empty || txtName.Text.ToString().Trim() == string.Empty || ddFaculty.Text.Trim() == string.Empty || ddCenter.Text.Trim() == string.Empty || ddDepartment.Text.Trim() == string.Empty || ddLevel.Text.Trim() == string.Empty || ddBuilding.Text.Trim() == string.Empty || ddWorkingD.Text.Trim() == string.Empty || ddWorkingH.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Please Enter All Field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

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
            loadFaculty2();

            //set the dropdown to visible selected item from table
            if (btnAddLecSub.Text == "Update")
            {
                lblAddLec.Text = "Update Lecturer";
                ddFaculty.DropDownStyle = ComboBoxStyle.DropDown;
                ddDepartment.DropDownStyle = ComboBoxStyle.DropDown;
                ddCenter.DropDownStyle = ComboBoxStyle.DropDown;
                ddBuilding.DropDownStyle = ComboBoxStyle.DropDown;
                ddLevel.DropDownStyle = ComboBoxStyle.DropDown;
                ddWorkingD.DropDownStyle = ComboBoxStyle.DropDown;
                ddWorkingH.DropDownStyle = ComboBoxStyle.DropDown;
                txtLecturerId.ReadOnly = true;

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
            }
            //Make the dropdown style as DropDownList
            if (btnAddLecSub.Text == "Submit")
            {
                txtLecturerId.Text = string.Empty;
                ddFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
                ddDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
                ddCenter.DropDownStyle = ComboBoxStyle.DropDownList;
                ddBuilding.DropDownStyle = ComboBoxStyle.DropDownList;
                ddLevel.DropDownStyle = ComboBoxStyle.DropDownList;
                ddWorkingD.DropDownStyle = ComboBoxStyle.DropDownList;
                ddWorkingH.DropDownStyle = ComboBoxStyle.DropDownList;
                txtLecturerId.ReadOnly = false;
            }
        }

        private void ddBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        //Methord to clear form data
        public void clear()
        {
            if (btnAddLecSub.Text == "Submit")
            {
                txtLecturerId.Text = string.Empty;
            }
            
            txtName.Text = string.Empty;
            ddFaculty.SelectedIndex = -1;
            ddDepartment.SelectedIndex = -1;
            ddCenter.SelectedIndex = -1;
            ddBuilding.SelectedIndex = -1;
            ddLevel.SelectedIndex = -1;
            ddWorkingD.SelectedIndex = -1;
            ddWorkingH.SelectedIndex = -1;
        }

        public void loadFaculty2()
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

        //Method to close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
