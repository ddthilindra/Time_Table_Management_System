using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Class.Location;

namespace app.Forms.Location
{
    public partial class manageSessions : Form
    {
      
        static string myconnstrng = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        ClassMsessions c = new ClassMsessions();

        public manageSessions()
        {
            InitializeComponent();
            FillLocationCombo();
            FillSessionCombo();
        }


       public void FillLocationCombo()
        {
            SqlConnection con = new SqlConnection(myconnstrng);

            comboSroom.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT RoomName,RoomType,Capacity FROM LOC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboSroom.Items.Add(dr["RoomName"].ToString()+"  " + dr["RoomType"].ToString()+ "   Capacity - " + dr["Capacity"].ToString());
            }

            con.Close();
        }
        
             public void FillSessionCombo()
        {
            SqlConnection con = new SqlConnection(myconnstrng);

            comboSsession.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Lecturer1,SubjectCode,SubjectName,Tag FROM SES";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {   
                comboSsession.Items.Add(dr["Lecturer1"].ToString()+"      "+ dr["SubjectCode"].ToString()+"     "+ dr["SubjectName"].ToString()+ "       " + dr["Tag"].ToString());
            }

            con.Close();
        }

        private void comboSroom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboSsection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private void manageSessions_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            tblSessions.DataSource = dt;
        }

        public void Clear()
        {
            comboSroom.Text = "";
            comboSsession.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //get input values 
            c.SessionName = comboSsession.Text;
            c.SessionRoom = comboSroom.Text;


            //into db
            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Session Added Successfully!");
                //clear method
                Clear();
            }
            else
            {
                MessageBox.Show("Try again");
            }

            //Load data into table
            DataTable dt = c.Select();
            tblSessions.DataSource = dt;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
