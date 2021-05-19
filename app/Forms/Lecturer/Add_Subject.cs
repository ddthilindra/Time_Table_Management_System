using app.Class.Lecturer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms.Lecturer
{
    public partial class Add_Subject : Form
    {
        //Create new object from ClassSubject class
        ClassSubject s = new ClassSubject();
        //Creating variable to set the table value to form
        public string id, subcode, subname, offeredyear, offeredsem, lechr, tutehr, labhr, evehr;

        public Add_Subject()
        {
            InitializeComponent();
        }

        private void dropOffYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Method for submit the add & update subject form
        private void btnAddSubject_Click_1(object sender, EventArgs e)
        {
            
            // Set changed botton of text to submit text if addSubject form change to update form
            if (isformValid())
            {
                //get value from input field
                s.ID = lblIndex.Text;
                s.OfferSemester = dropOffSem.Text.Trim();
                s.OfferYear = dropOffYear.Text.Trim();
                s.SubCode = txtSubCode.Text.Trim();
                s.SubName = txtSubName.Text.Trim();
                s.NumLecHr = numLecHr.Value.ToString().Trim();
                s.NumTuteHr = numTuteHr.Value.ToString().Trim();
                s.NumLabHr = numLabHr.Value.ToString().Trim();
                s.NumEveHr = numEveHr.Value.ToString().Trim();

                //Submit the add subject form
                if (btnAddSubject.Text == "Submit")
                {
                    // call chkSubID method(check lecturer id alredy in db)
                    bool exist = s.chkSubID(txtSubCode.Text.Trim());

                    //inserting data in to database using insertSubject method
                    if (exist == true)
                    {
                        bool success = s.insertSubject(s);

                        if (success == true)
                        {
                            MessageBox.Show("Subject was added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Somthing went Worng!\n\nCannot insert the value!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                //Submit the update subject form
                if (btnAddSubject.Text == "Update")
                {
                    //inserting data in to database using insertSubject method
                    bool success = s.updateSubject(s);

                    if (success == true)
                    {
                        MessageBox.Show("Update successful", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update Failed", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {

        }

        //form load
        private void Add_Subject_Load(object sender, EventArgs e)
        {
            //if button text update, Then table value set to update form
            if (btnAddSubject.Text == "Update")
            {
                lblAddSub.Text = "Update Lecturer";
                txtSubCode.ReadOnly = true;

                lblIndex.Text = id;
                txtSubCode.Text = subcode;
                txtSubName.Text = subname;
                dropOffYear.Text = offeredyear;
                dropOffSem.Text = offeredsem;
                numLecHr.Text = lechr;
                numTuteHr.Text = tutehr;
                numLabHr.Text = labhr;
                numEveHr.Text = evehr;
            }
            //Make the all feild as empty field
            if (btnAddSubject.Text == "Submit")
            {
                txtSubCode.Text = string.Empty;
                txtSubCode.ReadOnly = false;
            }
        }

        //Method to form validation
        private bool isformValid()
        {
            if (txtSubName.Text.ToString().Trim() == string.Empty || txtSubCode.Text.ToString().Trim() == string.Empty || dropOffYear.Text.Trim() == string.Empty || dropOffSem.Text.Trim() == string.Empty || numLecHr.Text.Trim() == "0" || numTuteHr.Text.Trim() == "0" || numLabHr.Text.Trim() == "0")
            {
                MessageBox.Show("Please fill out the all field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        //Methord to clear form data
        public void clear()
        {
            txtSubCode.Text = string.Empty;
            txtSubName.Text = string.Empty;
            dropOffYear.Text = string.Empty;
            dropOffSem.Text = string.Empty;
            numLecHr.Value = 0;
            numTuteHr.Value = 0;
            numLabHr.Value = 0;
            numEveHr.Value = 0;
        }

        //Method to Set changed botton of text to submit text
        public void addSubInfo()
        {
            lblAddSub.Text = "Add Subject";
            btnAddSubject.Text = "Submit";
        }

        //Method to change submit button text to update 
        public void updateSubInfo()
        {
            btnAddSubject.Text = "Update";
        }

        //Method to close the form
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
