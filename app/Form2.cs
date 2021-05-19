using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.LocationClass;

namespace app.Forms
{
    public partial class Form2 : Form
    {
        ClassLocation c = new ClassLocation();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            tblLocation.DataSource = dt;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //get input values 
            c.Bname = comboBName.Text;
            c.Rname = combRName.Text;
            c.Capacity = textBCapacity.Text;
            if(radioButton1.Checked==true)
            {
                c.Rtype = radioButton1.Text;
            }

            if (radioButton2.Checked == true)
            {
                c.Rtype = radioButton2.Text;
            }

            //into db
            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Customer Added Successfully!");
                //clear method
               // Clear();
            }
            else
            {
                MessageBox.Show("Try again");
            }

            //Load data into table
            DataTable dt = c.Select();
            tblLocation.DataSource = dt;
        }
    }
}
