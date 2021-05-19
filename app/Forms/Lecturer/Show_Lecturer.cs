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

namespace app.Forms.Lecturer
{
    public partial class Show_Lecturer : UserControl
    {
        //Creating object from ClassLecturer
        ClassLecturer c = new ClassLecturer();

        //Create new object from Add_Lecturer form
        Add_Lecturer form;        

        //DB connection
        static string myconstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //Creating object from this Show_Lecturer to access this form in main menu
        static Show_Lecturer _obj;
        public static Show_Lecturer Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Show_Lecturer();
                }
                return _obj;
            }
        }

        public Show_Lecturer()
        {
            InitializeComponent();
            form = new Add_Lecturer();  //Create new object from Add_Session form
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //form load
        private void Show_Lecturer_Load(object sender, EventArgs e)
        {
            //load lecturer table to gridview
            DataTable dt = c.selectLecturer();
            lecTbl.DataSource = dt;
        }

        private void btnAddLecture_Click(object sender, EventArgs e)
        {
                
        }

        //Method for add new lecturer button
        private void btnAddLecture_Click_1(object sender, EventArgs e)
        {
            form.clear();               //clear form data in addlecturer form
            form.addLecInfo();          //Call addlecInfor methord to change form spesific content
            form.ShowDialog();          //Open add lecturer form to ad new lecturer
            DataTable dt = c.selectLecturer();
            lecTbl.DataSource = dt;
        }

        //Method for edit and delete oparetion for button click
        private void lecTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0)
            {
                //Edit Record Button

                form.clear();           //clear form data in addlecturer form

                //Add table value to update form
                form.id= lecTbl.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.lecid = lecTbl.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.lecName= lecTbl.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.lecFaculty =lecTbl.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.lecDepartment = lecTbl.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.lecCenter = lecTbl.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.lecBuilding = lecTbl.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.lecLevel = lecTbl.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.lecWD = lecTbl.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.lecWH = lecTbl.Rows[e.RowIndex].Cells[11].Value.ToString();

                form.updateLecInfo();   //Call updateLecInfo methord to change form spesific content
                form.ShowDialog();

                DataTable dt = c.selectLecturer();
                lecTbl.DataSource = dt;

                return;
            }
            if(e.ColumnIndex==1)
            {
                //Delete Record Button

                if(MessageBox.Show("Are you sure?\n\nDo you really want to delete this record?\nThis process cannot be undone!", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    //Pass the lecturer id to deleteLecturer method
                    c.deleteLecturer(lecTbl.Rows[e.RowIndex].Cells[2].Value.ToString());

                    //load lecturer table to gridview after deleting the row
                    DataTable dt = c.selectLecturer();
                    lecTbl.DataSource = dt;
                }
                return;
            }
        }
                
        //Method to Search data in table
        private void lecSch_TextChange(object sender, EventArgs e)
        {
            //Assign the keyword
            string keyword = txtLecSch.Text;

            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);

            DataTable dt = new DataTable();

            try
            {
                //Select query
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id,Lecturerid,Name,Faculty,Department,Center,Building,Level,WD,WH FROM Lecturer WHERE Lecturerid LIKE'%" + keyword + "%' OR Name LIKE'%" + keyword + "%'", con);

                adapter.Fill(dt);

                lecTbl.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        //Refresh the lecturer table
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = c.selectLecturer();
            lecTbl.DataSource = dt;
        }
    }
}
