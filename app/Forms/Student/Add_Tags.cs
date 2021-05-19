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
    public partial class Add_Tags : UserControl
    {
        public Add_Tags()
        {
            InitializeComponent();
        }

        static Add_Tags _obj;
        public static Add_Tags Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Add_Tags();
                }
                return _obj;
            }
        }

        TagClass t = new TagClass();       

        public void Clear()
        {
            subName.Text = "";
            subCode.Text = "";
            relatedTag.SelectedIndex = -1;
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
                //Get the values from the input fields
                t.SubjectName = subName.Text;
                t.SubjectCode = subCode.Text;
                t.RelatedTag = relatedTag.Text;


                //Insert Data into Database
                bool success = t.Insert(t);
                if (success == true)
                {
                    //If insert Successfull show successfully message
                    MessageBox.Show("New Tag Inserted");
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
            Clear();
        }
    }
}
