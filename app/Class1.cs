using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    class Class1
    {
        public string ID { get; set; }
        public string Bname { get; set; }
        public string Rname { get; set; }
        public string Capacity { get; set; }
        public string Rtype { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //get data from database
        public DataTable Select()
        {
            //db connection 
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //sql quary
                string sql = "SELECT * from Lecturer";
                //sql cmd and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Insert data 
        public bool Insert(Class1 c)
        {
            // create  return type value to false 
            bool isSuccess = false;
            //1.connect database 
            SqlConnection conn = new SqlConnection(myconnstrng);
            // return isSuccess;
            try
            {
                //2.sql query to insert 
                string sql = "INSERT INTO Table (BuildingName,RoomName,Capacity,RoomType)VALUES(@buildingName,@roomName,@capacity,@roomType)";
                //create SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Parameters to add data
                cmd.Parameters.AddWithValue("@buildingName", c.Bname);
                cmd.Parameters.AddWithValue("@roomName", c.Rname);
                cmd.Parameters.AddWithValue("@capacity", c.Capacity);
                cmd.Parameters.AddWithValue("@roomType", c.Rtype);

                MessageBox.Show("Exception Called : " + c.Bname + c.Rname + c.Capacity + c.Rtype + "", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if sucessful ..method
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
