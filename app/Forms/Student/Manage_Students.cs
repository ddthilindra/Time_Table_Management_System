using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Class.Student_Tag;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;

namespace app.Forms.Student
{
    public partial class Manage_Students : UserControl
    {
        public Manage_Students()
        {
            InitializeComponent();
        }

        static Manage_Students _obj;
        public static Manage_Students Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Manage_Students();
                }
                return _obj;
            }
        }

        //AddStudent Class import and create a new object
        AddStudentClass stgroup = new AddStudentClass();

        //Create Variables to store data to update method
        string Id, Ac_Year_Sem, Programme, GroupNo, SubGroupNo, GroupID, SubGroupID;

        
        public void Clear()
        {
            //Clear method to clear the texboxes and comboboxes
            Ac_Year_Sem_Updt.SelectedIndex = -1;
            Programme_Updt.SelectedIndex = -1;
            GroupNo_Updt.Value = 0;
            SubGroupNo_Updt.Value = 0;
            GroupID_Updt.Text = "";
            SubGroupID_Updt.Text = "";

        }

        
        //Method and clickevent to Genarate Group ID and subgroup ID
        private void button1_Click_1(object sender, EventArgs e)
        {       
                //Database Connection
                string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

                SqlConnection conn = new SqlConnection(myconnstring);

                try
                {
                    //Sql to check whether the Generated sub groupID already in the databse
                    String sql = "SELECT SubGroupID FROM StudentGroups WHERE SubGroupID =@SubGroupID";

                    //Get the data from the input fields and Generate the Group ID
                    String GroupID = Ac_Year_Sem_Updt.Text + "." + Int16.Parse(GroupNo_Updt.Text) + "(" + Programme_Updt.Text + ")";
                    GroupID_Updt.Text = GroupID;

                    //Get the data from the input fields and Generate the Sub Group ID
                    String SubGroupID = Ac_Year_Sem_Updt.Text + "." + Int16.Parse(GroupNo_Updt.Text) + "." + Int16.Parse(SubGroupNo_Updt.Text) + "(" + Programme_Updt.Text + ")";
                    SubGroupID_Updt.Text = SubGroupID;

                    //Creating cmd using sql & conn
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    //Create Parameters to Add Data
                    cmd.Parameters.AddWithValue("@SubGroupID", SubGroupID);
                    DataTable table = new DataTable();

                    //Creating Sql data adapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    ArrayList list = new ArrayList();

                    foreach (DataRow row in table.Rows)
                    {
                        String temp = row["SubGroupID"].ToString();
                        list.Add(temp);
                    }
                    String[] Arr = (String[])list.ToArray(typeof(String));
                    if (Arr.Length != 0)
                    {
                        MessageBox.Show(SubGroupID_Updt.Text + " Group is already exist. Please enter another Sub-Group ID!");
                        GroupID_Updt.Text = "";
                        SubGroupID_Updt.Text = "";
                    }

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
        }

        private void st_Groups_GridView_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
                //Get data from grid view and load data in to the variables respectively
                //Identify the row on which mouse is clicked
                int rowIndex = e.RowIndex;
                Id = st_Groups_GridView.Rows[rowIndex].Cells[0].Value.ToString();
                Ac_Year_Sem = st_Groups_GridView.Rows[rowIndex].Cells[1].Value.ToString();
                Programme = st_Groups_GridView.Rows[rowIndex].Cells[2].Value.ToString();
                GroupNo = st_Groups_GridView.Rows[rowIndex].Cells[3].Value.ToString();
                SubGroupNo = st_Groups_GridView.Rows[rowIndex].Cells[4].Value.ToString();
                GroupID = st_Groups_GridView.Rows[rowIndex].Cells[5].Value.ToString();
                SubGroupID = st_Groups_GridView.Rows[rowIndex].Cells[6].Value.ToString();
        }

        //Button click event method to Update data
        private void btn_Save_Click_1(object sender, EventArgs e)
        {
                stgroup.Id = int.Parse(Id);
                stgroup.AcademicYearSem = Ac_Year_Sem_Updt.Text;
                stgroup.Program = Programme_Updt.Text;
                stgroup.GroupNo = GroupNo_Updt.Text;
                stgroup.SubGroupNo = SubGroupNo_Updt.Text;
                stgroup.GroupID = GroupID_Updt.Text;
                stgroup.SubGroupID = SubGroupID_Updt.Text;

                //Update data in the database
                bool success = stgroup.Update(stgroup);

                if (success == true)
                {
                    //Update successfully
                    MessageBox.Show("Successfully Updated");
                    //Load Data in the grid view
                    DataTable dt = stgroup.Select();
                    st_Groups_GridView.DataSource = dt;
                    //Call clear method to clear texboxes
                    Clear();
                }
                else
                {
                    //Faild to Update
                    MessageBox.Show("Faild to update Try again");
                }
        }

        //Button click event to clear the data fields
        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
                //Get the row clicked StudentGroup table Id
                stgroup.Id = int.Parse(Id);

                bool success = stgroup.Delete(stgroup);

                if (success == true)
                {
                    if (MessageBox.Show("Are you sure?\n\nDo you really want to delete this record?\nThis process cannot be undone!", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        //Delete successfully
                        MessageBox.Show("Successfully Deleted");
                        //Load Data in the grid view
                        DataTable dt = stgroup.Select();
                        st_Groups_GridView.DataSource = dt;
                    }
                    
                }
                else
                {
                    //Faild to Update
                    MessageBox.Show("Faild");
                }
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
                //Get data from grid view and load data in to the textboxes respectively

                Ac_Year_Sem_Updt.Text = Ac_Year_Sem;
                Programme_Updt.Text = Programme;
                GroupNo_Updt.Text = GroupNo;
                SubGroupNo_Updt.Text = SubGroupNo;
                GroupID_Updt.Text = GroupID;
                SubGroupID_Updt.Text = SubGroupID;
        }

        private void Manage_Students_Load_1(object sender, EventArgs e)
        {
            //Load data in the gridview
            DataTable dt = stgroup.Select();
            st_Groups_GridView.DataSource = dt;
        }        
        public void st_Groups_GridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data from grid view and load data in to the variables respectively
            //Identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            Id = st_Groups_GridView.Rows[rowIndex].Cells[0].Value.ToString();
            Ac_Year_Sem = st_Groups_GridView.Rows[rowIndex].Cells[1].Value.ToString();
            Programme = st_Groups_GridView.Rows[rowIndex].Cells[2].Value.ToString();
            GroupNo = st_Groups_GridView.Rows[rowIndex].Cells[3].Value.ToString();
            SubGroupNo = st_Groups_GridView.Rows[rowIndex].Cells[4].Value.ToString();
            GroupID = st_Groups_GridView.Rows[rowIndex].Cells[5].Value.ToString();
            SubGroupID = st_Groups_GridView.Rows[rowIndex].Cells[6].Value.ToString();
        }
        
    }
}
