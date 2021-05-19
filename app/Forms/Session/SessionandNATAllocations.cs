using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using app.Class.Session;
using System.Configuration;
using app.Class.Location;

namespace app.Forms.Session
{
    public partial class SessionandNATAllocations : UserControl
    {
        SqlConnection connection;

        //DB connection
        static string myconstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        public SessionandNATAllocations()
        {
            InitializeComponent();

            connection = new SqlConnection(myconstr);
            FillLocationCombo();
            FillSessionCombo();
        }

        //Creating object from this Show_Lecturer to access this form in main menu
        static SessionandNATAllocations _obj;

        public static SessionandNATAllocations Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new SessionandNATAllocations();
                }
                return _obj;
            }
        }

        private void SessionandNATAllocations_Load(object sender, EventArgs e)
        {
            fetchSubjectFromDB();
            fetchAcademicYearFromDB(cmbSelectYearPar);

            fetchAcademicYearFromDB(cmbSelectYearNO);

            DataTable dt = NoTimes.Select();
            dataGridView1.DataSource = dt;

            DataTable dtt = LNoTimes.Select();
            dataGridView2.DataSource = dtt;

            DataTable dttt = c.Select();
            tblSessions.DataSource = dttt;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedIndex == 0)
                {

                    fetchSubjectFromDB();

                }
                if (tabControl.SelectedIndex == 1)
                {

                    fetchAcademicYearFromDB(cmbSelectYearPar);

                }
                if (tabControl.SelectedIndex == 2)
                {

                    fetchAcademicYearFromDB(cmbSelectYearNO);

                }
                if (tabControl.SelectedIndex == 3)
                {

                    //loadConsecutives();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fetchSubjectFromDB()
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT DISTINCT SubjectName FROM Session", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                cmbSelectSubjectConsec.DataSource = dataTable;
                cmbSelectSubjectConsec.DisplayMember = "SubjectName";
                cmbSelectSubjectConsec.ValueMember = "SubjectName";

                cmbSelectSubjectConsec.Text = "SELECT";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fetchAcademicYearFromDB(ComboBox comboName)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT DISTINCT Year FROM Session", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboName.DataSource = dataTable;
                comboName.DisplayMember = "Year";
                comboName.ValueMember = "Year";

                comboName.Text = "SELECT";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewConsec_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSelectSubjectConsec.Text == "SELECT")
                {
                    MessageBox.Show("Please Select a Subject", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    connection.Open();

                    dgvResultConsec.DataSource = null;

                    if (dgvResultConsec.Columns.Count > 0)
                    {

                        dgvResultConsec.Columns.RemoveAt(0);
                    }


                    SqlDataAdapter sda = new SqlDataAdapter("  SELECT * FROM Session WHERE SubjectName = '" + cmbSelectSubjectConsec.Text + "' ;", connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dgvResultConsec.DataSource = ds.Tables[0];
                        connection.Close();
                        DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                        checkBoxColumn.HeaderText = "";
                        checkBoxColumn.Width = 30;
                        checkBoxColumn.Name = "checkBoxColumn";
                        dgvResultConsec.Columns.Insert(0, checkBoxColumn);
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("No Data about Parallel Sessions!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddSessionConsec_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvResultConsec.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    connection.Open();
                    string Query = "Update Session set  Status = 'Consecutive' where Id=" + row.Cells["Id"].Value.ToString() + ";";
                    SqlCommand cmd = new SqlCommand(Query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            MessageBox.Show("Consecutive Sessions Adding Successful .");
        }

        private void btnViewPar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSelectYearPar.Text == "SELECT")
                {
                    MessageBox.Show("Please Select a Year", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    connection.Open();

                    dgvResultPar.DataSource = null;

                    if (dgvResultPar.Columns.Count > 0)
                    {

                        dgvResultPar.Columns.RemoveAt(0);
                    }


                    SqlDataAdapter sda = new SqlDataAdapter(" SELECT * FROM Session  WHERE Year ='" + cmbSelectYearPar.Text + "' ; ", connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dgvResultPar.DataSource = ds.Tables[0];
                        connection.Close();
                        DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                        checkBoxColumn.HeaderText = "";
                        checkBoxColumn.Width = 30;
                        checkBoxColumn.Name = "checkBoxColumn";
                        dgvResultPar.Columns.Insert(0, checkBoxColumn);
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("No Data about Parallel Sessions!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddSessionPar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvResultPar.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    connection.Open();
                    string Query = "Update Session set  Status = 'Parallel' where Id=" + row.Cells["Id"].Value.ToString() + ";";
                    SqlCommand cmd = new SqlCommand(Query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            MessageBox.Show("Parallel Sessions Adding Successful .");
        }

        private void btnViewNO_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbSelectYearNO.Text == "SELECT")
                {
                    MessageBox.Show("Please Select a Year", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    connection.Open();
                    dgvResultNO.DataSource = null;

                    if (dgvResultNO.Columns.Count > 0)
                    {

                        dgvResultNO.Columns.RemoveAt(0);
                    }


                    SqlDataAdapter sda = new SqlDataAdapter(" SELECT * FROM Session  WHERE Year ='" + cmbSelectYearNO.Text + "' ; ", connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dgvResultNO.DataSource = ds.Tables[0];
                        connection.Close();
                        DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                        checkBoxColumn.HeaderText = "";
                        checkBoxColumn.Width = 30;
                        checkBoxColumn.Name = "checkBoxColumn";
                        dgvResultNO.Columns.Insert(0, checkBoxColumn);
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("No Data about Non Overlapping Sessions!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddSessionNO_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvResultNO.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    connection.Open();
                    string Query = "Update Session set  Status = 'NO' where Id=" + row.Cells["Id"].Value.ToString() + ";";
                    SqlCommand cmd = new SqlCommand(Query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            MessageBox.Show(" Non Overlapping Sessions Adding Successful .");
        }

        ClassNotAvailableTimes NoTimes = new ClassNotAvailableTimes();
        private void btnSave_Click(object sender, EventArgs e)
        {
            //get value from input field

            NoTimes.SeLecturer = comboBoxNo1.Text;
            NoTimes.SeGroup = comboBoxNo2.Text;
            NoTimes.SeSubGroup = comboBoxNo3.Text;
            NoTimes.SeSessionID = comboBoxNo4.Text;
            NoTimes.SeTimeDuration = comboBoxNo5.Text;
            //Insert Data into Database
            bool success = NoTimes.Insert(NoTimes);
            if (success == true)
            {
                //If insert Successfull show successfully message
                MessageBox.Show("Not Availble Time Successfully Inserted !!!");

            }
            else
            {
                //If insert is not Successfull show Error message
                MessageBox.Show("Error while inserting !!!");
            }
        }

//################################################################################

        private void buttonNoSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonNoDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonNoUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonLNoSave_Click(object sender, EventArgs e)
        {

        }
        ClassLocationNotAvailableTimes LNoTimes = new ClassLocationNotAvailableTimes();
        private void btnLocNATSave_Click(object sender, EventArgs e)
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
        }

        ClassLocationNotAvailableTimes wdd = new ClassLocationNotAvailableTimes();

        string ID, SeLecturer, SeGroup, SeSubGroup, SeSessionID, SeTimeDuration;
        int x = 0;

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            ID = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            SeLecturer = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            SeGroup = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            SeSubGroup = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            SeSessionID = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            SeTimeDuration = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
        }

        string IDD, SeRoom, SeDay, SeTime, ETime;

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
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        ClassMngsessions c = new ClassMngsessions();

        public void Clear()
        {
            comboSroom.Text = "";
            comboSsession.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //get input values 
            c.SessionName = comboSsession.Text;
            c.SessionRoom = comboSroom.Text;


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

        public void FillSessionCombo()
        {
            SqlConnection con = new SqlConnection(myconnstrng);

            comboSsession.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Lecturer1,SubjectCode,SubjectName,Tag FROM Session";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboSsession.Items.Add(dr["Lecturer1"].ToString() + "      " + dr["SubjectCode"].ToString() + "     " + dr["SubjectName"].ToString() + "       " + dr["Tag"].ToString());
            }

            con.Close();
        }

        public void FillLocationCombo()
        {
            SqlConnection con = new SqlConnection(myconnstrng);

            comboSroom.Items.Clear();
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
            }

            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxNo1.Text = string.Empty;
            comboBoxNo2.Text = string.Empty;
            comboBoxNo3.Text = string.Empty;
            comboBoxNo4.Text = string.Empty;
            comboBoxNo5.Text = string.Empty;
        }

        private void btnNATClear_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            comboBox5.Text= string.Empty;
            comboBox3.Text = string.Empty;
            comboBox4.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox1.Text = string.Empty;
        }

        private void btnLocNATClear_Click(object sender, EventArgs e)
        {
            comboBoxLNo1.Text = string.Empty;
            comboBoxLNo2.Text = string.Empty;
            comboBoxLNo3.Text = string.Empty;
            comboBoxLNo4.Text = string.Empty;
        }

        private void bntMNATLocClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            comboBox9.Text = string.Empty;
            comboBox8.Text = string.Empty;
            comboBox6.Text = string.Empty;
            comboBox7.Text = string.Empty;
        }

        int xx = 0;

        private void btnNATLocUpdt_Click(object sender, EventArgs e)
        {
            textBox1.Text = IDD;
            comboBox9.Text = SeRoom;
            comboBox8.Text = SeDay;
            comboBox6.Text = SeTime;
            comboBox7.Text = ETime;
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            IDD = dataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
            SeRoom = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();
            SeDay = dataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
            SeTime = dataGridView2.Rows[rowIndex].Cells[3].Value.ToString();
            ETime = dataGridView2.Rows[rowIndex].Cells[4].Value.ToString();
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

                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            textBox2.Text = ID;
            comboBox5.Text = SeLecturer;
            comboBox3.Text = SeGroup;
            comboBox4.Text = SeSubGroup;
            comboBox2.Text = SeSessionID;
            comboBox1.Text = SeTimeDuration;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int y = Int32.Parse(ID);
            NoTimes.Id = y;
            bool s = NoTimes.Delete(NoTimes);

            if (s == true)
            {
                MessageBox.Show("Delete Successfull !!!");
            }
            else
            {
                MessageBox.Show("UnSuccessfull !!!"+ NoTimes.Id);
            }
        }

        private void btnNATSave_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox2.Text);
            NoTimes.Id = x;

            NoTimes.SeLecturer = comboBox5.Text;
            NoTimes.SeGroup = comboBox3.Text;
            NoTimes.SeSubGroup = comboBox4.Text;
            NoTimes.SeSessionID = comboBox2.Text;
            NoTimes.SeTimeDuration = comboBox1.Text;


            bool s = NoTimes.Update(NoTimes);

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
                SqlDataAdapter sad = new SqlDataAdapter("SELECT *FROM  Time WHERE Id = '" + textBox2.Text.Trim() + "'", con);
                DataTable dt = new DataTable();
                _ = sad.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
