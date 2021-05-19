using app.Class.Lecturer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms.Lecturer
{
    public partial class Add_Session : Form
    {
        //Create new object from ClassSession class
        ClassSession s = new ClassSession();
        public Add_Session()
        {
            InitializeComponent();
        }

        //Creating variable to set the table value to form
        public string id, faculty, lec1, lec2, subject, tag, year, gid, subgid, nstudent, duration, gencode;
        private string[] subArr;

        //Call Connection string get database info
        static string myconstr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //Database Connection
        SqlConnection con = new SqlConnection(myconstr);

        //Method for submit the add & update session form
        private void btnAddSession_Click(object sender, EventArgs e)
        {
            //get value from input field
            s.ID = sessionId.Text;
            s.Faculty = drpFaculty.Text.Trim();
            s.lecturer1 = drpLec1.Text;
            s.lecturer2 = drpLec2.Text.Trim();
            s.SubjectCode = subArr[1];
            s.SubjectName = subArr[0];
            s.Tag = drpTag.Text.Trim();
            s.Year = drpYear.Text.Trim(); ;
            s.GID = drpGroupId.Text.Trim();
            s.SubGID = drpSubGId.Text.Trim();
            s.noOfStu = numOfStu.Text.Trim();
            s.Duration = Duration.Text;
            s.Generate = gSession.Text;

            //Submit the add Session form
            if (btnAddSession.Text == "Submit")
            {
                //inserting data in to database using insertLecturer method
                
                    bool success = s.insertSession(s);

                    if (success == true)
                    {
                        MessageBox.Show("Session was added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Somthing went Worng!\n\nCannot insert the value!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    btnAddSession.Visible = false;       //Create one time click button
                
            }

            //Submit the update session form
            if (btnAddSession.Text == "Update")
            {
                //inserting data in to database using insertsession method
                bool success = s.updatesession(s);

                if (success == true)
                {
                    MessageBox.Show("Update successful"+ s.SubjectCode, "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update Failed", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnAddSession.Visible = false;       //Make one time click submit button
            }
        }

        private void drpFaculty_onItemSelected(object sender, EventArgs e)
        {
            
        }

        private void drpFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public string lect2;
        //Method to generete session code
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (isformValid())
            {
                
                string faculty = drpFaculty.Text.Trim();
                string lec1 = drpLec1.Text.Trim();
                string phrase = drpSubject.Text.Trim();
                //Split the subject name and subject code
                subArr = phrase.Split('-');
                string subcode = subArr[1];
                string subname = subArr[0];
                string tag = drpTag.Text.Trim();
                string gId = drpGroupId.Text.Trim();
                string subGId = drpSubGId.Text.Trim();
                string noOfStu = numOfStu.Text.Trim();
                string duration = Duration.Text.Trim();
                gSession.Font = new Font(gSession.Font, FontStyle.Bold);
                gSession.ForeColor = SystemColors.ControlText;

                //Generate session code acording to dropdown
                if(drpLec2.SelectedIndex == -1 || drpLec2.Text.Trim() == string.Empty)
                {
                    if(drpSubGId.SelectedIndex == -1 || drpSubGId.Text.Trim() == string.Empty)
                    {
                        gSession.Text = lec1 + " - " + subcode + " - " + subname + " - " + tag + " - " + gId + " - "  + noOfStu + " - " + duration;
                    }
                    else
                    {
                        gSession.Text = lec1 + " - " + subcode + " - " + subname + " - " + tag + " - " + gId + " - " + subGId + " - " + noOfStu + " - " + duration;
                    }                    
                }
                else if (drpSubGId.SelectedIndex == -1 || drpSubGId.Text.Trim() == string.Empty)
                {
                    lect2 = drpLec2.Text.Trim();
                    gSession.Text = lec1 + " - " + lect2 + " - " + subcode + " - "  + subname + " - " + tag + " - " + gId + " - " + noOfStu + " - " + duration;
                }
                else
                {
                    lect2 = drpLec2.Text.Trim();
                    gSession.Text = lec1 + " - " + lect2 + " - " + subcode + " - " + subname + " - " + tag + " - " + gId + " - " + subGId + " - " + noOfStu + " - " + duration;
                }
                
                //If click genarate button submit button will be visible otherwise not visible
                btnAddSession.Visible = true;
            }
        }

        //Method to form validation
        private bool isformValid()
        {
            if (drpFaculty.Text.Trim() == string.Empty || drpLec1.Text.Trim() == string.Empty || drpSubject.Text.Trim() == string.Empty || drpTag.Text.Trim() == string.Empty || drpGroupId.Text.Trim() == string.Empty || numOfStu.Text.Trim() == string.Empty || Duration.Text.Trim() == string.Empty)
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
        private void Add_Session_Load(object sender, EventArgs e)
        {
            //Load the drop down data to from
            loadLecturer1();
            loadLecturer2();
            loadTag();
            loadSubject();
            loadGroup();
            loadSubGroup();

            //change the add session form to update session form
            if (btnAddSession.Text == "Update")
            {
                lblAddSess.Text = "Update Session";

                sessionId.Text = id;
                drpFaculty.Text = faculty;
                drpLec1.Text = lec1;
                drpLec2.Text = lec2;
                drpSubject.Text = subject;
                drpTag.Text = tag;
                drpYear.Text = year;
                drpGroupId.Text = gid;
                drpSubGId.Text = subgid;
                numOfStu.Text = nstudent;
                Duration.Text = duration;
                gSession.Text = gencode;
            }

            //Make the all feild as empty field
            if (btnAddSession.Text == "Submit")
            {
                sessionId.Text = string.Empty;
                drpFaculty.Text = "";
                drpLec1.Text = "";
                drpLec2.Text = "";
                drpSubject.Text = "";
                drpTag.Text = "";
                drpYear.Text = "";
                drpGroupId.Text = "";
                drpSubGId.Text = "";
                numOfStu.Text = "";
                Duration.Text = "";
                gSession.Text = "";
            }

        }

        //Method to load all lecturer to lecturer1 dropdown
        public void loadLecturer1()
        {
            drpLec1.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Name FROM Lecturer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                drpLec1.Items.Add(dr["Name"].ToString());
            }

            con.Close();
        }

        //Method to load all lecturer to lecturer2 dropdown
        public void loadLecturer2()
        {
            drpLec2.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Name FROM Lecturer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                drpLec2.Items.Add(dr["Name"].ToString());
            }

            con.Close();
        }

        //Method to load all Subject Name and Subject Code
        public void loadSubject()
        {
            drpSubject.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SubjectName,SubjectCode FROM Subject";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                drpSubject.Items.Add(dr["SubjectName"].ToString()+"-"+dr["SubjectCode"].ToString());
            }

            con.Close();
        }

        //Method to load all Tag
        public void loadTag()
        {
            drpTag.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT RelatedTag FROM Tag";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                drpTag.Items.Add(dr["RelatedTag"].ToString());
            }

            con.Close();
        }

        //Method to load all Group
        public void loadGroup()
        {
            drpGroupId.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT GroupID FROM StudentGroups";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                drpGroupId.Items.Add(dr["GroupID"].ToString());
            }

            con.Close();
        }

        //Method to load all Group to subgroup drodown
        public void loadSubGroup()
        {
            drpSubGId.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SubGroupID FROM StudentGroups";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                drpSubGId.Items.Add(dr["SubGroupID"].ToString());
            }

            con.Close();
        }

        //Method to clear all input field
        public void clear()
        {
            drpFaculty.SelectedIndex = -1;
            drpLec1.SelectedIndex = -1;
            drpLec2.SelectedIndex = -1;
            drpSubject.SelectedIndex = -1;
            drpTag.SelectedIndex = -1;
            drpYear.SelectedIndex = -1;
            drpGroupId.SelectedIndex = -1;
            drpSubGId.SelectedIndex = -1;
            numOfStu.SelectedIndex = -1;
            Duration.SelectedIndex = -1;
        }

        //Method to change submit button text to update 
        public void updatesessInfo()
        {
            btnAddSession.Text = "Update";
        }

        //Method to Set changed botton of text to submit text and othe content
        public void addSessInfo()
        {
            lblAddSess.Text = "Add Session";
            btnAddSession.Text = "Submit";
        }

        //Method to close the form
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
