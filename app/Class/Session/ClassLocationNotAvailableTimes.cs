using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace app.Class.Session
{
    class ClassLocationNotAvailableTimes
    {
        //Getter setter properties
        //Act as a data carrier in app

        public int Id { get; set; }
        public string SeRoom { get; set; }
        public string SeDay { get; set; }
        public string STime { get; set; }
        public string Etime { get; set; }





        //Database Connection
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Read Data form Database
        public DataTable Select()
        {
            //step 1: Database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                //step 2: writting Sql query
                String sql = "Select * From NATLocation";
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
        public bool Insert(ClassLocationNotAvailableTimes LNoTimes)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1 : Connect database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Create sql query to inert data
                String sql = "Insert Into NATLocation(SeRoom, SeDay, STime, Etime) Values(@comboBoxLNo1, @comboBoxLNo2, @comboBoxLNo3, @comboBoxLNo4)";
                //Creating cmd using sql & conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to Add Data
                cmd.Parameters.AddWithValue("@comboBoxLNo1", LNoTimes.SeRoom);
                cmd.Parameters.AddWithValue("@comboBoxLNo2", LNoTimes.SeDay);
                cmd.Parameters.AddWithValue("@comboBoxLNo3", LNoTimes.STime);
                cmd.Parameters.AddWithValue("@comboBoxLNo4", LNoTimes.Etime);



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

            }
            finally
            {
                conn.Close();
            }


            return isSuccess;


        }
        public bool Update(ClassLocationNotAvailableTimes LNoTimes)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;

            //Step 1 : Connect database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Sql command to update data in the database
                string sql = "update NATLocation set SeRoom=@comboBoxLNo1, SeDay=@comboBoxLNo2, STime=@comboBoxLNo3, Etime=@comboBoxLNo4 where Id = @id";
                //Creating cmd using sql & conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to Add Data
                cmd.Parameters.AddWithValue("@id", LNoTimes.Id);
                cmd.Parameters.AddWithValue("@comboBoxLNo1", LNoTimes.SeRoom);
                cmd.Parameters.AddWithValue("@comboBoxLNo2", LNoTimes.SeDay);
                cmd.Parameters.AddWithValue("@comboBoxLNo3", LNoTimes.STime);
                cmd.Parameters.AddWithValue("@comboBoxLNo4", LNoTimes.Etime);



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

        public bool Delete(ClassLocationNotAvailableTimes LNoTimes)
        {
            bool c = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM NATLocation WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", LNoTimes.Id);

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
