using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using app.Class.Student_Tag;

namespace app.Forms.Student
{
    public partial class Add_Student_Groups : UserControl
    {
        public Add_Student_Groups()
        {
            InitializeComponent();
        }

        static Add_Student_Groups _obj;
        public static Add_Student_Groups Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Add_Student_Groups();
                }
                return _obj;
            }
        }

        AddStudentClass stgroup = new AddStudentClass();

        private void Add_Student_Groups_Load(object sender, EventArgs e)
        {

        }       

        public void Clear()
        {
            //Method to clear the insert fields
            Ac_Year_Sem_Drop.SelectedIndex = -1;
            prog_drop.SelectedIndex = -1;
            Group_No.Value = 0;
            Sub_Group_no.Value = 0;
            Group_Id.Text = "";
            Sub_Group_Id.Text = "";

        }

        //Method and clickevent to Genarate Group ID and subgroup ID
        private void btn_Generate_Click_1(object sender, EventArgs e)
        {           
                //Database Connection
                string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

                SqlConnection conn = new SqlConnection(myconnstring);

                try
                {
                    //Sql to check whether the Generated sub groupID already in the databse
                    String sql = "SELECT SubGroupID FROM StudentGroups WHERE SubGroupID =@SubGroupID";

                    //Get the data from the input fields and Generate the Group ID
                    String GroupID = Ac_Year_Sem_Drop.Text + "." + Int16.Parse(Group_No.Text) + "(" + prog_drop.Text + ")";
                    Group_Id.Text = GroupID;
                    //Get the data from the input fields and Generate the Sub Group ID
                    String SubGroupID = Ac_Year_Sem_Drop.Text + "." + Int16.Parse(Group_No.Text) + "." + Int16.Parse(Sub_Group_no.Text) + "(" + prog_drop.Text + ")";
                    Sub_Group_Id.Text = SubGroupID;

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
                        MessageBox.Show(Sub_Group_Id.Text + "Group is already created...Please Insert a new SubGroup ID!");
                        Group_Id.Text = "";
                        Sub_Group_Id.Text = "";
                    }

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
                //Get the values from the input fields
                stgroup.AcademicYearSem = Ac_Year_Sem_Drop.Text;
                stgroup.Program = prog_drop.Text;
                stgroup.GroupNo = Group_No.Value.ToString();
                stgroup.SubGroupNo = Sub_Group_no.Value.ToString();
                stgroup.GroupID = Group_Id.Text;
                stgroup.SubGroupID = Sub_Group_Id.Text;

                //Insert Data into Database
                bool success = stgroup.Insert(stgroup);
                if (success == true)
                {
                    //If insert Successfull show successfully message
                    MessageBox.Show("New Student Group Inserted");
                    Clear();
                }
                else
                {
                    //If insert is not Successfull show Error message
                    MessageBox.Show("Try Again");
                }
        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            //Call the clear method to clear textboxes and comboboxes
            Clear();
        }
    }
}
