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
    class ClassMngsessions
    {
        public int ID { get; set; }
        public string SessionName { get; set; }
        public string SessionRoom { get; set; }


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
                string sql = "SELECT * FROM SESLOC";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);


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

        //get data from database================================================================
        public DataTable Select2()
        {
            //Database Connection
            SqlConnection con = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //Select query
                con.Open();
                string sql = "SELECT * FROM SLCON";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);
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
        //get data from database================================================================
        public DataTable Select3()
        {
            //Database Connection
            SqlConnection con = new SqlConnection(myconnstrng);
            DataTable dt3 = new DataTable();

            try
            {
                //Select query
                con.Open();
                string sql = "SELECT * FROM SLNA";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt3);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            return dt3;
        }


        //Insert data 
        public bool Insert(ClassMngsessions c)
        {
            // create  return type value to false 
            bool isSuccess = false;
            //1.connect database 
            SqlConnection conn = new SqlConnection(myconnstrng);
            // return isSuccess;
            try
            {
                //2.sql query to insert 
                string sql = "INSERT INTO SESLOC (SessionName, SessionRoom ) VALUES(@SessionName, @SessionRoom )";
                //create SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Parameters to add data
                cmd.Parameters.AddWithValue("@SessionName", c.SessionName);
                cmd.Parameters.AddWithValue("@SessionRoom", c.SessionRoom);

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

        //Insert data ===================================== SLCON TABLE (CONSECUTIVE)=============================================
        public bool Insert2(ClassMngsessions c)
        {
            // create  return type value to false 
            bool isSuccess = false;
            //1.connect database 
            SqlConnection conn = new SqlConnection(myconnstrng);
            // return isSuccess;
            try
            {
                //2.sql query to insert 
                string sql = "INSERT INTO SLCON (SessionName, SessionRoom ) VALUES(@SessionName, @SessionRoom )";
                //create SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Parameters to add data
                cmd.Parameters.AddWithValue("@SessionName", c.SessionName);
                cmd.Parameters.AddWithValue("@SessionRoom", c.SessionRoom);

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

        //Insert data =============================== SLNA TABLE (NOT AV)================================================
        public bool Insert3(ClassMngsessions c)
        {
            // create  return type value to false 
            bool isSuccess = false;
            //1.connect database 
            SqlConnection conn = new SqlConnection(myconnstrng);
            // return isSuccess;
            try
            {
                //2.sql query to insert 
                string sql = "INSERT INTO SLNA (SessionName, SessionRoom ) VALUES(@SessionName, @SessionRoom )";
                //create SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Parameters to add data
                cmd.Parameters.AddWithValue("@SessionName", c.SessionName);
                cmd.Parameters.AddWithValue("@SessionRoom", c.SessionRoom);

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
