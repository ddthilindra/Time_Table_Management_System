using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Class.Student_Tag
{
    class AddStudentClass
    {
        //Getter setter properties
        public int Id { get; set; }
        public string AcademicYearSem { get; set; }
        public string Program { get; set; }
        public string GroupNo { get; set; }
        public string SubGroupNo { get; set; }
        public string GroupID { get; set; }
        public string SubGroupID { get; set; }

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
                String sql = "Select * From StudentGroups";
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
        public bool Insert(AddStudentClass stgroup)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1 : Connect database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Create sql query to inert data
                String sql = "Insert Into StudentGroups(AcademicYearSem, Program, GroupNo, SubGroupNo, GroupID, SubGroupID) Values(@AcademicYearSem, @Program, @GroupNo, @SubGroupNo, @GroupID, @SubGroupID)";
                //Creating cmd using sql & conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to Add Data
                cmd.Parameters.AddWithValue("@AcademicYearSem", stgroup.AcademicYearSem);
                cmd.Parameters.AddWithValue("@Program", stgroup.Program);
                cmd.Parameters.AddWithValue("@GroupNo", stgroup.GroupNo);
                cmd.Parameters.AddWithValue("@SubGroupNo", stgroup.SubGroupNo);
                cmd.Parameters.AddWithValue("@GroupID", stgroup.GroupID);
                cmd.Parameters.AddWithValue("@SubGroupID", stgroup.SubGroupID);

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

        //Update data in the database
        public bool Update(AddStudentClass stgroup)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;

            //Step 1 : Connect database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Sql command to update data in the database
                string sql = "Update StudentGroups set AcademicYearSem=@AcademicYearSem, Program=@Program, GroupNo=@GroupNo, SubGroupNo=@SubGroupNo, GroupID=@GroupID, SubGroupID=@SubGroupID where Id=@Id";
                //Creating cmd using sql & conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to Add Data
                cmd.Parameters.AddWithValue("@Id", stgroup.Id);
                cmd.Parameters.AddWithValue("@AcademicYearSem", stgroup.AcademicYearSem);
                cmd.Parameters.AddWithValue("@Program", stgroup.Program);
                cmd.Parameters.AddWithValue("@GroupNo", stgroup.GroupNo);
                cmd.Parameters.AddWithValue("@SubGroupNo", stgroup.SubGroupNo);
                cmd.Parameters.AddWithValue("@GroupID", stgroup.GroupID);
                cmd.Parameters.AddWithValue("@SubGroupID", stgroup.SubGroupID);

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


        //Method to Delete data from table
        public bool Delete(AddStudentClass stgroup)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;

            //Create SQL connection 
            SqlConnection conn = new SqlConnection(myconnstring);


            try
            {
                //SQL to Delete data
                string sql = "Delete from StudentGroups where Id=@Id";

                //Creating Sql Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", stgroup.Id);

                //Open the connection
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
            catch
            {

            }
            finally
            {
                //Close connection
                conn.Close();
            }

            return isSuccess;
        }
    }
}
