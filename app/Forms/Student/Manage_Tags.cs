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

namespace app.Forms.Student
{
    public partial class Manage_Tags : UserControl
    {
        public Manage_Tags()
        {
            InitializeComponent();
        }

        static Manage_Tags _obj;
        public static Manage_Tags Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Manage_Tags();
                }
                return _obj;
            }
        }

        //Tag Class import and create a new object
        TagClass t = new TagClass();

        //Create Variables to store data to update method
        string Id, sub_name, sub_code, related_Tag;

        private void Manage_Tags_Load_1(object sender, EventArgs e)
        {
            //Load data in the gridview
            DataTable dt = t.Select();
            tagGridView.DataSource = dt;
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            //Get data from grid view and load data in to the textboxes respectively
            subName.Text = sub_name;
            subCode.Text = sub_code;
            relatedTag.Text = related_Tag;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Get the row clicked Tag Id
            t.Id = int.Parse(Id);

            bool success = t.Delete(t);

            if (success == true)
            {
                if (MessageBox.Show("Are you sure?\n\nDo you really want to delete this record?\nThis process cannot be undone!", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    //Delete successfully
                    MessageBox.Show("Successfully Deleted");
                    //Load Data in the grid view
                    DataTable dt = t.Select();
                    tagGridView.DataSource = dt;
                }                  

            }
            else
            {
                //Faild to Update
                MessageBox.Show("Faild");
            }
        }
        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
        //Button click event method to Update data
        private void btn_Save_Click(object sender, EventArgs e)
        {
            t.Id = int.Parse(Id);
            t.SubjectName = subName.Text;
            t.SubjectCode = subCode.Text;
            t.RelatedTag = relatedTag.Text;

            //Update data in the database
            bool success = t.Update(t);

            if (success == true)
            {
                //Update successfully
                MessageBox.Show("Successfully Updated");
                //Load Data in the grid view
                DataTable dt = t.Select();
                tagGridView.DataSource = dt;
                //Call clear method to clear texboxes
                Clear();
            }
            else
            {
                //Faild to Update
                MessageBox.Show("Faild to update Try again");
            }
        }

        private void tagGridView_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
                //Get data from grid view and load data in to the variables respectively
                //Identify the row on which mouse is clicked
                int rowIndex = e.RowIndex;
                Id = tagGridView.Rows[rowIndex].Cells[0].Value.ToString();
                sub_name = tagGridView.Rows[rowIndex].Cells[1].Value.ToString();
                sub_code = tagGridView.Rows[rowIndex].Cells[2].Value.ToString();
                related_Tag = tagGridView.Rows[rowIndex].Cells[3].Value.ToString();
        }

        public void Clear()
        {
            //Clear method to clear the texboxes and comboboxes
            subName.Text = "";
            subCode.Text = "";
            relatedTag.Text = "";
        }


        //Button click event to clear the data fields
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

    }
}
