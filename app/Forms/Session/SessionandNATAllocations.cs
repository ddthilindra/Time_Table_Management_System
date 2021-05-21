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

            loadLecturer();
            loadGroup();
            loadSubGroup();
            loadSessionID();
            //loadSubject();
        }

        //Database Connection
        SqlConnection con = new SqlConnection(myconstr);
        public void loadLecturer()
        {
            comboBoxNo1.Items.Clear();
            comboBox5.Items.Clear();
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
                comboBoxNo1.Items.Add(dr["Name"].ToString());
                comboBox5.Items.Add(dr["Name"].ToString());
            }

            con.Close();
        }

        public void loadGroup()
        {
            comboBoxNo2.Items.Clear();
            comboBox3.Items.Clear();
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
                comboBoxNo2.Items.Add(dr["GroupID"].ToString());
                comboBox3.Items.Add(dr["GroupID"].ToString());
            }

            con.Close();
        }

        public void loadSubGroup()
        {
            comboBoxNo3.Items.Clear();
            comboBox4.Items.Clear();
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
                comboBoxNo3.Items.Add(dr["SubGroupID"].ToString());
                comboBox4.Items.Add(dr["SubGroupID"].ToString());
            }

            con.Close();
        }

        public void loadSessionID()
        {
            SqlConnection con = new SqlConnection(myconnstrng);

            comboBoxNo4.Items.Clear();
            comboBox2.Items.Clear();
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
                comboBoxNo4.Items.Add(dr["SessionCode"].ToString());
                comboBox2.Items.Add(dr["SessionCode"].ToString());
            }

            con.Close();
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
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT DISTINCT SubjectName FROM Subject", connection);
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

        public void loadSubject()
        {
            cmbSelectSubjectConsec.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SubjectName FROM Subject";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbSelectSubjectConsec.Items.Add(dr["SubjectName"].ToString());
            }

            con.Close();
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
            if (isformValid())
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
                    DataTable dt = NoTimes.Select();
                    dataGridView1.DataSource = dt;

                }
                else
                {
                    //If insert is not Successfull show Error message
                    MessageBox.Show("Error while inserting !!!");
                }
            }
        }

        private bool isformValid()
        {
            if (comboBoxNo1.Text.ToString().Trim() == string.Empty || comboBoxNo2.Text.ToString().Trim() == string.Empty || comboBoxNo3.Text.Trim() == string.Empty || comboBoxNo4.Text.Trim() == string.Empty || comboBoxNo5.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out the all field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
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
        

        ClassLocationNotAvailableTimes wdd = new ClassLocationNotAvailableTimes();

        string ID, SeLecturer, SeGroup, SeSubGroup, SeSessionID, SeTimeDuration;
        int x = 0;

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick_2(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            ID = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            SeLecturer = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            SeGroup = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            SeSubGroup = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            SeSessionID = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            SeTimeDuration = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        ClassMngsessions c = new ClassMngsessions();



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
                DataTable dt = NoTimes.Select();
                dataGridView1.DataSource = dt;
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
                SqlDataAdapter sad = new SqlDataAdapter("SELECT *FROM  TimeT WHERE Id = '" + textBox2.Text.Trim() + "'", con);
                DataTable dt = new DataTable();
                _ = sad.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
