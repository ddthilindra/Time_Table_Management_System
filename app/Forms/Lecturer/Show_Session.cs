using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Class.Lecturer;
using System.Data.SqlClient;

namespace app.Forms.Lecturer
{
    public partial class Show_Session : UserControl
    {
        //Create new object from ClassSession class
        ClassSession s = new ClassSession();

        //Create new object from Add_Session form
        Add_Session form;

        //Creating object from this Show_Session to access this form in main menu
        static Show_Session _obj;        

        public static Show_Session Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Show_Session();
                }
                return _obj;
            }
        }

        public Show_Session()
        {
            InitializeComponent();            
            form = new Add_Session();  //Create new object from Add_Session form
        }

        //DB connection
        static string myconstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown4_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown11_onItemSelected(object sender, EventArgs e)
        {

        }

        //Form Load
        private void Show_Session_Load(object sender, EventArgs e)
        {
            //load lecturer table to gridview
            DataTable dt = s.selectSession();
            tblSession.DataSource = dt;
        }

        //Method for add new session button
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            form.clear();               //clear form data in addlecturer form
            form.addSessInfo();          //Call addsession Info methord to reset the update form to add form
            form.ShowDialog();          //Open add session form to ad new session
            DataTable dt = s.selectSession();
            tblSession.DataSource = dt;
        }

        //Method for edit and delete oparetion for button click
        private void tblSession_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                //Edit Record Button

                form.clear();           //clear form data in addsession form

                //Add table value to update form
                form.id = tblSession.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.faculty = tblSession.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.lec1 = tblSession.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.lec2 = tblSession.Rows[e.RowIndex].Cells[6].Value.ToString();
                //Set subject name and code to subject dropdown, "-" used to spit the subject name and code
                String sub = tblSession.Rows[e.RowIndex].Cells[7].Value.ToString() +"-"+ tblSession.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.subject = sub;
                form.tag = tblSession.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.gid = tblSession.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.subgid = tblSession.Rows[e.RowIndex].Cells[11].Value.ToString();
                form.year = tblSession.Rows[e.RowIndex].Cells[12].Value.ToString();
                form.nstudent = tblSession.Rows[e.RowIndex].Cells[13].Value.ToString();
                form.duration = tblSession.Rows[e.RowIndex].Cells[14].Value.ToString();

                form.updatesessInfo();   //Call updatesessionInfo methord to change form spesific content
                form.ShowDialog();

                DataTable dt = s.selectSession();
                tblSession.DataSource = dt;

                return;
            }
            if (e.ColumnIndex == 2)
            {
                //Delete Record Button

                if (MessageBox.Show("Are you sure?\n\nDo you really want to delete this record?\nThis process cannot be undone!", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    //Pass the lecturer id to deletesession method
                    s.deleteSession(tblSession.Rows[e.RowIndex].Cells[3].Value.ToString());

                    //load lecturer table to gridview after deleting the row
                    DataTable dt = s.selectSession();
                    tblSession.DataSource = dt;
                }
                return;
            }
        }
                
        //Method to Search data in table
        private void txtsessSch_TextChange(object sender, EventArgs e)
        {
            //Assign the keyword
            string keyword = txtsessSch.Text;

            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);

            DataTable dt = new DataTable();

            try
            {
                //Select query
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id,Faculty,Lecturer1,Lecturer2,SubjectCode,Tag,GroupID,SubGroupID,Year,NumOfStu,Duration FROM Session WHERE Faculty LIKE'%" + keyword + "%' OR Lecturer1 LIKE'%" + keyword + "%' OR Lecturer2 LIKE'%" + keyword + "%' OR SubjectCode LIKE'%" + keyword + "%' OR SubjectName LIKE'%" + keyword + "%'", con);

                adapter.Fill(dt);

                tblSession.DataSource = dt;
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

        //Refresh the session table
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = s.selectSession();
            tblSession.DataSource = dt;
        }
    }
}
