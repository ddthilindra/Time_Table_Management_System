using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Class.Location
{
    class ClassLocation
    {
        public int ID { get; set; }
        public string Bname { get; set; }
        public string Rname { get; set; }
        public string Capacity { get; set; }
        public string Rtype { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //get data from database
        public DataTable Select()
        {
            //Database Connection
            SqlConnection con = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //Select query
                con.Open();
                string sql = "SELECT * FROM Location";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);

                //dgv.DataSource=dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        //Insert data 
        public bool Insert(ClassLocation c)
        {
            // create  return type value to false 
            bool isSuccess = false;
            //1.connect database 
            SqlConnection conn = new SqlConnection(myconnstrng);
            // return isSuccess;
            try
            {
                //2.sql query to insert 
                string sql = "INSERT INTO Location (BuildingName, RoomName, Capacity, RoomType ) VALUES(@buildingName, @roomName, @capacity, @roomType)";
                //create SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Parameters to add data
                cmd.Parameters.AddWithValue("@buildingName", c.Bname);
                cmd.Parameters.AddWithValue("@roomName", c.Rname);
                cmd.Parameters.AddWithValue("@capacity", c.Capacity);
                cmd.Parameters.AddWithValue("@roomType", c.Rtype);

                //MessageBox.Show("Exception Called : " + c.Bname + c.Rname+ c.Capacity+c.Rtype+ "", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        //UPDATE values
        public bool Update(ClassLocation c)
        {
            //default type to false 
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //update data in database
                string sql = "UPDATE Location SET buildingName=@buildingName, roomName=@roomName, capacity=@capacity, RoomType=@roomType WHERE id=@id";
                //SQL command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //parameters to value 
                cmd.Parameters.AddWithValue("@id", c.ID);
                cmd.Parameters.AddWithValue("@buildingName", c.Bname);
                cmd.Parameters.AddWithValue("@roomName", c.Rname);
                cmd.Parameters.AddWithValue("@capacity", c.Capacity);
                cmd.Parameters.AddWithValue("@roomType", c.Rtype);

                //  MessageBox.Show("Exception Called : " + c.Bname + c.Rname+ c.Capacity+c.Rtype+ "", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // database conection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if sucecc method 
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
        //DELETE
        public bool Delete(ClassLocation c)
        {
            //default return 
            bool isSuccess = false;
            //Sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to delte data
                string sql = "DELETE FROM Location WHERE id=@id";
                //sql command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", c.ID);
                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //method
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
                //close connection
                conn.Close();
            }

            return isSuccess;
        }
    }
}
