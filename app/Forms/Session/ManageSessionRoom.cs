using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Class.Location;
using System.Configuration;
using System.Data.SqlClient;
using app.Class.Session;

namespace app.Forms.Session
{
    public partial class ManageSessionRoom : UserControl
    {
        public ManageSessionRoom()
        {
            InitializeComponent();
            FillLocationCombo();
            FillSessionCombo();
        }

        //Creating object from this Show_Lecturer to access this form in main menu
        static ManageSessionRoom _obj;

        public static ManageSessionRoom Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ManageSessionRoom();
                }
                return _obj;
            }
        }

        //DB connection
        static string myconstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        public void FillLocationCombo()
        {
            SqlConnection con = new SqlConnection(myconnstrng);

            comboSroom.Items.Clear();
            comboBoxLNo1.Items.Clear();
            comboBox9.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT RoomName,RoomType,Capacity FROM Location";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboSroom.Items.Add(dr["RoomName"].ToString() + "  " + dr["RoomType"].ToString() + "   Capacity - " + dr["Capacity"].ToString());
                comboBoxLNo1.Items.Add(dr["RoomName"].ToString() + "  " + dr["RoomType"].ToString() + "   Capacity - " + dr["Capacity"].ToString());
                comboBox9.Items.Add(dr["RoomName"].ToString() + "  " + dr["RoomType"].ToString() + "   Capacity - " + dr["Capacity"].ToString());
            }

            con.Close();
        }

        public void loadRoom()
        {
            SqlConnection con = new SqlConnection(myconnstrng);

            comboBoxLNo1.Items.Clear();
            comboBox9.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT RoomName FROM Location";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                
                comboBoxLNo1.Items.Add(dr["RoomName"].ToString());
                comboBox9.Items.Add(dr["RoomName"].ToString());
            }

            con.Close();
        }

        public void FillSessionCombo()
        {
            SqlConnection con = new SqlConnection(myconnstrng);

            comboSsession.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SessionCode FROM Session";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboSsession.Items.Add(dr["SessionCode"].ToString());
            }

            con.Close();
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;


        ClassMngsessions c = new ClassMngsessions();
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //validation
            if (isformValid())
            {
                //=============================  SESSIONS  ============================================

                if (tabControl1.SelectedTab == tabPage1)
                {
                    // Do stuff here...
                    //get input values 
                    c.SessionName = comboSsession.Text.Trim();
                    c.SessionRoom = comboSroom.Text.Trim();


                    //into db
                    bool success = c.Insert(c);
                    if (success == true)
                    {
                        MessageBox.Show("New Session Added Successfully!");
                        //clear method
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Try again");
                    }

                    //Load data into table
                    DataTable dt = c.Select();
                    tblSessions.DataSource = dt;

                }

                //=============================  Consecutive  ==============================================

                if (tabControl1.SelectedTab == tabPage2)
                {
                    // Do stuff here...
                    //get input values 
                    c.SessionName = comboSsession.Text.Trim();
                    c.SessionRoom = comboSroom.Text.Trim();


                    //into db
                    bool success = c.Insert2(c);
                    if (success == true)
                    {
                        MessageBox.Show("New Consecutive Session Added Successfully!");
                        //clear method
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Try again");
                    }

                    //Load data into table
                    DataTable dt2 = c.Select2();
                    tblSCON.DataSource = dt2;

                }

                //================================= NOT Avilable Session =========================================

                if (tabControl1.SelectedTab == tabPage6)
                {

                    //get input values 
                    c.SessionName = comboSsession.Text.Trim();
                    c.SessionRoom = comboSroom.Text.Trim();


                    //into db
                    bool success = c.Insert3(c);
                    if (success == true)
                    {
                        MessageBox.Show("New NOT Avilable Session Added Successfully!");
                        //clear method
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Try again");
                    }

                    //Load data into table
                    DataTable dt3 = c.Select3();
                    tblSNA.DataSource = dt3;

                }
            }
        }

        //Method to form validation
        private bool isformValid()
        {
            if (comboSsession.Text.ToString().Trim() == string.Empty || comboSroom.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out the all field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }


        public void Clear()
        {
            comboSroom.Text = "";
            comboSsession.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ManageSessionRoom_Load(object sender, EventArgs e)
        {
            DataTable dt = LNoTimes.Select();
            dataGridView2.DataSource = dt;

            DataTable dt1 = c.Select();
            tblSessions.DataSource = dt1;

            DataTable dt2 = c.Select2();
            tblSCON.DataSource = dt2;

            DataTable dt3 = c.Select3();
            tblSNA.DataSource = dt3;

            loadRoom();

        }
        ClassLocationNotAvailableTimes LNoTimes = new ClassLocationNotAvailableTimes();

        private void btnLocNATSave_Click(object sender, EventArgs e)
        {
            if(isfformValid())
            {
                //get value from input field

                LNoTimes.SeRoom = comboBoxLNo1.Text;
                LNoTimes.SeDay = comboBoxLNo2.Text;
                LNoTimes.STime = comboBoxLNo3.Text;
                LNoTimes.Etime = comboBoxLNo4.Text;

                //Insert Data into Database
                bool success = LNoTimes.Insert(LNoTimes);
                if (success == true)
                {
                    //If insert Successfull show successfully message
                    MessageBox.Show(" Not Availble Time Successfully Inserted !!!");

                }
                else
                {
                    //If insert is not Successfull show Error message
                    MessageBox.Show("Try Again");
                }
                DataTable dtt = LNoTimes.Select();
                dataGridView2.DataSource = dtt;
            }
            
        }

        private bool isfformValid()
        {
            if (comboBoxLNo1.Text.ToString().Trim() == string.Empty || comboBoxLNo2.Text.ToString().Trim() == string.Empty || comboBoxLNo3.Text.Trim() == string.Empty || comboBoxLNo4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out the all field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLocNATClear_Click(object sender, EventArgs e)
        {
            comboBoxLNo1.Text = string.Empty;
            comboBoxLNo2.Text = string.Empty;
            comboBoxLNo3.Text = string.Empty;
            comboBoxLNo4.Text = string.Empty;
        }
        string IDD, SeRoom, SeDay, SeTime, ETime;
        private void btnNATLocUpdt_Click(object sender, EventArgs e)
        {
            textBox1.Text = IDD;
            comboBox9.Text = SeRoom;
            comboBox8.Text = SeDay;
            comboBox6.Text = SeTime;
            comboBox7.Text = ETime;
        }

        private void dataGridView2_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            IDD = dataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
            SeRoom = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();
            SeDay = dataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
            SeTime = dataGridView2.Rows[rowIndex].Cells[3].Value.ToString();
            ETime = dataGridView2.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btnNATLocDlt_Click(object sender, EventArgs e)
        {
            int y = Int32.Parse(IDD);
            LNoTimes.Id = y;
            bool s = LNoTimes.Delete(LNoTimes);

            if (s == true)
            {
                MessageBox.Show("Delete Successfull !!!");
            }
            else
            {
                MessageBox.Show("UnSuccessfull !!!");
            }
            DataTable dtt = LNoTimes.Select();
            dataGridView2.DataSource = dtt;
        }

        private void bntMNATLocClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            comboBox9.Text = string.Empty;
            comboBox8.Text = string.Empty;
            comboBox6.Text = string.Empty;
            comboBox7.Text = string.Empty;
        }

        private void bntMNATLocSave_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text);
            LNoTimes.Id = x;

            LNoTimes.SeRoom = comboBox9.Text;
            LNoTimes.SeDay = comboBox8.Text;
            LNoTimes.STime = comboBox6.Text;
            LNoTimes.Etime = comboBox7.Text;


            bool s = LNoTimes.Update(LNoTimes);

            if (s == true)
            {
                MessageBox.Show("Update Successfull !!!");
            }
            else
            {
                MessageBox.Show("UnSuccessfull !!!");
            }

            using (SqlConnection con = new SqlConnection(myconstr))
            {
                con.Open();
                SqlDataAdapter sad = new SqlDataAdapter("SELECT *FROM  NATLocation WHERE Id = '" + textBox1.Text.Trim() + "'", con);
                DataTable dt = new DataTable();
                _ = sad.Fill(dt);

                dataGridView2.DataSource = dt;
            }
            DataTable dtt = LNoTimes.Select();
            dataGridView2.DataSource = dtt;
        }

    }
}
