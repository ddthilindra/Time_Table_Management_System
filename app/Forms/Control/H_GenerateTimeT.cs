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
            //getLectureList();
            loadLec();
            lecturersCombo.SelectedIndex = -1;

            lectureGrid.RowTemplate.Height = 30;
            lectureGrid.AutoResizeColumns();
            lectureGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            lectureGrid.DataSource = createLecTable();

        }

        private void getLecturerTable(int id)
        {

            DataTable dt = getLecturerTableData(id);
            foreach (DataRow row in dt.Rows)
            {
                DateTime enteredDate = DateTime.Parse(row["day"].ToString());
                DayOfWeek dow = enteredDate.DayOfWeek; //enum
                string str = dow.ToString();

                string lecFromTime = row["timeFrom"].ToString();
                string lecToTime = row["timeTo"].ToString();

                string sessionFromTextAmPm = lecFromTime.Substring(lecFromTime.Length - 2);
                string sessionToTextAmPm = lecToTime.Substring(lecToTime.Length - 2);
                string sessionfromText = lecFromTime.Remove(lecFromTime.Length - 2);
                string sessiontoText = lecToTime.Remove(lecToTime.Length - 2);
                DateTime lecDay = Convert.ToDateTime(row["day"]);

                if (lecDay.Month == DateTime.Now.Month && lecDay.Year == DateTime.Now.Year && DatesAreInTheSameWeek(lecDay, DateTime.Now))
                {
                    int rowNo = getRowNo(sessionfromText);
                    int diff = 0;
                    if (sessionFromTextAmPm == sessionToTextAmPm)
                    {
                        diff = Convert.ToInt16(decimal.Parse(sessiontoText) - decimal.Parse(sessionfromText));
                    }
                    else
                    {
                        diff = Convert.ToInt16(decimal.Parse(sessiontoText) - decimal.Parse(sessionfromText)) + 12;
                    }


                    for (int x = 0; x < diff; x++)
                    {
                        var row1 = this.lectureGrid.Rows[rowNo + x];
                        row1.Cells[str].Value = row["session"].ToString();

                    }
                }
            }

            
        }
        //DB connection
        //static string myconstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        private DataTable getLecturerTableData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(myconstr))
            {
                using (SqlCommand cmd = new SqlCommand("getLecTimeTable", con))
                {
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private bool DatesAreInTheSameWeek(DateTime date1, DateTime date2)
        {
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            var d1 = date1.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date1));
            var d2 = date2.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date2));

            return d1 == d2;
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

        private void getLectureList()
        {
            lecturersCombo.DataSource = getLectureListData();
            lecturersCombo.DisplayMember = "Name";
            lecturersCombo.ValueMember = "ID";
        }

        private DataTable getLectureListData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(myconstr))
            {
                String sql = "SELECT * FROM Lecturer";
                
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            string q = string.Empty;

            string lec = (string)lecturersCombo.SelectedItem;

            q = q.Remove(q.Length - 2, 1);

            string sql = string.Format("Select (0) from Session", q);

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, con) 
                { 
                    CommandType = CommandType.Text 
                };
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                using(DataTable dt = new DataTable("session"))
                {
                    adapter.Fill(dt);
                }
            }

            /*clerLecGrid();
            int licId = Convert.ToInt32(lecturersCombo.SelectedValue);
            getLecturerTable(licId);*/
        }
    

        private void clerLecGrid()
        {

            for (int i = 1; i < lectureGrid.Columns.Count; i++)
            {
                foreach (DataGridViewRow myRow in lectureGrid.Rows)
                {
                    myRow.Cells[i].Value = null;
                }
            }

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
    }
}
