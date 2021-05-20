using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Class.Location;
using System.Data.SqlClient;
using System.Configuration;

namespace app.Forms.Location
{
    public partial class AddLocation : UserControl
    {
        ClassLocation c = new ClassLocation();

        //Call Connection string get database info
        static string myconstr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //Database Connection
        SqlConnection con = new SqlConnection(myconstr);

        public AddLocation()
        {
            InitializeComponent();
            loadLoc();
            loadRoom();
        }

        static AddLocation _obj;

        public static AddLocation Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new AddLocation();
                }
                return _obj;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            tblLocation.DataSource = dt;

            
        }

        public void loadLoc()
        {
            comboBName.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT BuildingName FROM Location";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBName.Items.Add(dr["BuildingName"].ToString());
            }

            con.Close();
        }

        public void loadRoom()
        {
            combRName.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT BuildingName FROM Location";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                combRName.Items.Add(dr["BuildingName"].ToString());
            }

            con.Close();
        }

        public void Clear()
        {
            //ID daana
            comboBName.Text = "";
            combRName.Text = "";
            textBCapacity.Text = "";

        }        

        private void AddLocation_Load(object sender, EventArgs e)
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
            if (radioButton1.Checked == true)
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
                MessageBox.Show("New Location Added Successfully!");
                //clear method
                Clear();
            }
            else
            {
                MessageBox.Show("Try again");
            }

            //Load data into table
            DataTable dt = c.Select();
            tblLocation.DataSource = dt;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //data from txtboxes
            c.ID = int.Parse(textBoxID.Text);
            c.Bname = comboBName.Text;
            c.Rname = combRName.Text;
            c.Capacity = textBCapacity.Text;
            if (radioButton1.Checked == true)
            {
                c.Rtype = radioButton1.Text;
            }

            if (radioButton2.Checked == true)
            {
                c.Rtype = radioButton2.Text;
            }
            //db update
            bool success = c.Update(c);
            if (success == true)
            {
                //msg box
                MessageBox.Show("Updated Successfully!");

                DataTable dt = c.Select();
                tblLocation.DataSource = dt;

                //clear
                Clear();
            }
            else
            {
                MessageBox.Show("Update Faild!");
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            //data from table
            c.ID = Convert.ToInt32(textBoxID.Text);
            bool success = c.Delete(c);

            if (success == true)
            {
                if (MessageBox.Show("Are you sure?\n\nDo you really want to delete this record?\nThis process cannot be undone!", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    c.ID = Convert.ToInt32(textBoxID.Text);
                    //Deleted
                    MessageBox.Show("Deleted Successfully!");
                    DataTable dt = c.Select();
                    tblLocation.DataSource = dt;
                    Clear();
                }                    
            }
            else
            {
                //Not Done
                MessageBox.Show("Error!");
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void tblLocation_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get Data from table to textboxes
            //row identifier
            int rowIndex = e.RowIndex;
            textBoxID.Text = tblLocation.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBName.Text = tblLocation.Rows[e.RowIndex].Cells[1].Value.ToString();
            combRName.Text = tblLocation.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBCapacity.Text = tblLocation.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void tblLocation_RowHeaderMouseClick_2(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get Data from table to textboxes
            //row identifier
            int rowIndex = e.RowIndex;
            textBoxID.Text = tblLocation.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBName.Text = tblLocation.Rows[e.RowIndex].Cells[1].Value.ToString();
            combRName.Text = tblLocation.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBCapacity.Text = tblLocation.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
