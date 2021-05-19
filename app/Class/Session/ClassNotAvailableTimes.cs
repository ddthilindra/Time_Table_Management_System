using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace app
{
    class ClassNotAvailableTimes
    {
        //Getter setter properties
        //Act as a data carrier in app

        public int Id { get; set; }
        public string SeLecturer { get; set; }
        public string SeGroup { get; set; }
        public string SeSubGroup { get; set; }
        public string SeSessionID { get; set; }
        public string SeTimeDuration { get; set; }




        //Database Connection
        static string myconnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        //Read Data form Database
        public DataTable Select()
        {
            //step 1: Database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                //step 2: writting Sql query
                String sql = "Select * From Time";
                //Creating cmd using sql & conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating Sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting Data into Database
        public bool Insert(ClassNotAvailableTimes NoTimes)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1 : Connect database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Create sql query to inert data
                String sql = "Insert Into Time(SeLecturer, SeGroup, SeSubGroup, SeSessionID, SeTimeDuration) Values(@comboBoxNo1, @comboBoxNo2, @comboBoxNo3, @comboBoxNo4, @comboBoxNo5)";
                //Creating cmd using sql & conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to Add Data
                cmd.Parameters.AddWithValue("@comboBoxNo1", NoTimes.SeLecturer);
                cmd.Parameters.AddWithValue("@comboBoxNo2", NoTimes.SeGroup);
                cmd.Parameters.AddWithValue("@comboBoxNo3", NoTimes.SeSubGroup);
                cmd.Parameters.AddWithValue("@comboBoxNo4", NoTimes.SeSessionID);
                cmd.Parameters.AddWithValue("@comboBoxNo5", NoTimes.SeTimeDuration);


                //Connection Open
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the value of rows will be greater than 0 else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }


            return isSuccess;


        }




        public bool Update(ClassNotAvailableTimes NoTimes)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;

            //Step 1 : Connect database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Sql command to update data in the database
                string sql = "update Time set SeLecturer=@comboBoxNo1, SeGroup=@comboBoxNo2, SeSubGroup=@comboBoxNo3, SeSessionID=@comboBoxNo4, SeTimeDuration=@comboBoxNo5 where Id = @id";
                //Creating cmd using sql & conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to Add Data
                cmd.Parameters.AddWithValue("@id", NoTimes.Id);
                cmd.Parameters.AddWithValue("@comboBoxNo1", NoTimes.SeLecturer);
                cmd.Parameters.AddWithValue("@comboBoxNo2", NoTimes.SeGroup);
                cmd.Parameters.AddWithValue("@comboBoxNo3", NoTimes.SeSubGroup);
                cmd.Parameters.AddWithValue("@comboBoxNo4", NoTimes.SeSessionID);
                cmd.Parameters.AddWithValue("@comboBoxNo5", NoTimes.SeTimeDuration);


                //Connection Open
                conn.Open();
                int rows = cmd.ExecuteNonQuery();


                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!!");
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;

        }

        public bool Delete(ClassNotAvailableTimes NoTimes)
        {
            bool c = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM Time WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", NoTimes.Id);

                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    c = true;
                }
                else
                {
                    c = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return c;
        }
    }
}
