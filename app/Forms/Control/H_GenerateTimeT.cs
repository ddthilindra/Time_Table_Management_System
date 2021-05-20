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
using System.Configuration;

namespace app.Forms.Control
{
    public partial class H_GenerateTimeT : UserControl
    {
        public H_GenerateTimeT()
        {
            InitializeComponent();
            createLecTable();
        }

        //Call Connection string get database info
        static string myconstr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //Database Connection
        SqlConnection con = new SqlConnection(myconstr);

        static H_GenerateTimeT _obj;

        public static H_GenerateTimeT Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new H_GenerateTimeT();
                }
                return _obj;
            }
        }

        private void H_GenerateTimeT_Load(object sender, EventArgs e)
        {            
            loadLec();
            loadGroup();
            loadLoc();

            lectureGrid.RowTemplate.Height = 40;
            lectureGrid.DataSource = createLecTable();

            grpTbl.RowTemplate.Height = 40;
            grpTbl.DataSource = createLecTable();

            locTbl.RowTemplate.Height = 40;
            locTbl.DataSource = createLecTable();
        }
        private string[] subArr;
        private string[] subArr2;

        private void btnClear_Click(object sender, EventArgs e)
        {
            createSlot();
        }
        int a, b;
        private void createSlot()
        {
            string lecSlt = lecturersCombo.Text.Trim();
            
            subArr = lecSlt.Split('-');
            string sessionC = chkSessCode(subArr[0]);
            String td = chksessionTime(sessionC);
            
            subArr2 = td.Split('-');
            string st = subArr2[0];
            string et = subArr2[1];

            int a = -1; 
            a=getRowNo(subArr2[0]);
            int b = -1; 
            b=getRowNo(subArr2[1]);                     

            MessageBox.Show(subArr2[0]+ subArr2[1]);
            MessageBox.Show(sessionC);
        }

        private int getRowNo(string time)
        {
            switch (time)
            {
                case "8.30":
                    return 0;
                case "9.30":
                    return 1;
                case "10.30":
                    return 2;
                case "11.30":
                    return 3;
                case "12.30":
                    return 4;
                case "1.30":
                    return 5;
                case "2.30":
                    return 6;
                case "3.30":
                    return 7;
                case "4.30":
                    return 8;
                default:
                    return 9;
            }
        }

        string n,m;

        private string chkSessCode(string name)
        {                        
            string q= "SELECT SessionCode FROM Session WHERE Lecturer1 = '"+name+"'";
            SqlCommand cmd = new SqlCommand(q, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    m = dr.GetString(0);
                }                    
            }
            dr.Close();
            con.Close();
            return m;
        }

        private string chksessionTime(string sc)
        {
            string q = "SELECT SeTimeDuration FROM Time WHERE SeSessionID='"+sc+"'";
            SqlCommand cmd = new SqlCommand(q, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    n = dr.GetString(0);
                }
            }
            dr.Close();
            con.Close();
            return n;
        }

        private DataTable createLecTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TimeSlots");
            dt.Columns.Add("Sunday");
            dt.Columns.Add("Monday");
            dt.Columns.Add("Tuesday");
            dt.Columns.Add("WednesDay");
            dt.Columns.Add("ThursDay");
            dt.Columns.Add("Friday");
            dt.Columns.Add("Satday");

            DataRow dr = dt.NewRow();
            dr["TimeSlots"] = "8.30-9.30";
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1["TimeSlots"] = "9.30-10.30";
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["TimeSlots"] = "10.30-11.30";
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3["TimeSlots"] = "11.30-12.30";
            dt.Rows.Add(dr3);

            DataRow dr4 = dt.NewRow();
            dr4["TimeSlots"] = "12.30-1.30";
            dt.Rows.Add(dr4);

            DataRow dr5 = dt.NewRow();
            dr5["TimeSlots"] = "1.30-2.30";
            dt.Rows.Add(dr5);

            DataRow dr6 = dt.NewRow();
            dr6["TimeSlots"] = "2.30-3.30";
            dt.Rows.Add(dr6);

            DataRow dr7 = dt.NewRow();
            dr7["TimeSlots"] = "3.30-4.30";
            dt.Rows.Add(dr7);

            DataRow dr8 = dt.NewRow();
            dr8["TimeSlots"] = "4.30-5.30";
            dt.Rows.Add(dr8);

            return dt;
        }
        
        //Method to load all Subject Name and Subject Code
        public void loadLec()
        {
            lecturersCombo.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Name,LecturerID FROM Lecturer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lecturersCombo.Items.Add(dr["Name"].ToString() + "-" + dr["LecturerID"].ToString());
            }

            con.Close();
        }

        public void loadGroup()
        {
            drpStuG.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT GroupID FROM StudentGroups";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                drpStuG.Items.Add(dr["GroupID"].ToString());
            }

            con.Close();
        }

        public void loadLoc()
        {
            drpLoc.Items.Clear();
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
                drpLoc.Items.Add(dr["BuildingName"].ToString());
            }

            con.Close();
        }
    }
}
