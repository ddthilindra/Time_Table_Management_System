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
    public partial class Show_Subject : UserControl
    {
        //Creating object from ClassSubject
        ClassSubject s = new ClassSubject();

        //Create new object from Add_Subject form
        Add_Subject form;

        //Creating object from this Show_Subject to access this form in main menu
        static Show_Subject _obj;

        public static Show_Subject Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Show_Subject();
                }
                return _obj;
            }
        }


        //DB connection
        static string myconstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        public Show_Subject()
        {
            InitializeComponent();
            form = new Add_Subject();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        //form load
        private void Show_Subject_Load(object sender, EventArgs e)
        {
            //load subject table to gridview
            DataTable dt = s.selectSubject();
            tblSub.DataSource = dt;
        }

        //Method for add new subject button
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            form.clear();               //clear form data in addlecturer form
            form.addSubInfo();          //Call addlecInfor methord to change form spesific content
            form.ShowDialog();          //Open add lecturer form to ad new lecturer
            DataTable dt = s.selectSubject();
            tblSub.DataSource = dt;
        }

        //Method for edit and delete oparetion for button click
        private void tblSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit Record Button

                form.clear();           //clear form data in addlecturer form

                //Add table value to update form
                form.id = tblSub.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.subname = tblSub.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.subcode = tblSub.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.offeredyear = tblSub.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.offeredsem = tblSub.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.lechr = tblSub.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.tutehr = tblSub.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.labhr = tblSub.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.evehr = tblSub.Rows[e.RowIndex].Cells[10].Value.ToString();


                form.updateSubInfo();   //Call updateLecInfo methord to change form spesific content
                form.ShowDialog();

                DataTable dt = s.selectSubject();
                tblSub.DataSource = dt;

                return;
            }

            if (e.ColumnIndex == 1)
            {
                //Delete Record Button

                if (MessageBox.Show("Are you sure?\n\nDo you really want to delete this record?\nThis process cannot be undone!", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    //Pass the lecturer id to deleteLecturer method
                    s.deleteSubject(tblSub.Rows[e.RowIndex].Cells[2].Value.ToString());

                    //load lecturer table to gridview after deleting the row
                    DataTable dt = s.selectSubject();
                    tblSub.DataSource = dt;
                }
                return;
            }
        }

        //Method to Search data in table
        private void txtLecSch_TextChange(object sender, EventArgs e)
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Subject WHERE SubjectCode LIKE'%" + keyword + "%' OR SubjectName LIKE'%" + keyword + "%'", con);

                adapter.Fill(dt);

                tblSub.DataSource = dt;
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

        //Refresh the subject table
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = s.selectSubject();
            tblSub.DataSource = dt;
        }

    }
}
