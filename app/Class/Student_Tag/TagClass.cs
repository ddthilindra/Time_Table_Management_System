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
    class TagClass
    {
        //Getter Setter properties
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public string RelatedTag { get; set; }

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
                String sql = "Select * From Tag";
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
        public bool Insert(TagClass t)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1 : Connect database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Create sql query to inert data
                String sql = "Insert Into Tag(SubjectName,SubjectCode,RelatedTag) Values(@SubjectName,@SubjectCode,@RelatedTag)";
                //Creating cmd using sql & conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to Add Data
                cmd.Parameters.AddWithValue("@SubjectName", t.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", t.SubjectCode);
                cmd.Parameters.AddWithValue("@RelatedTag", t.RelatedTag);


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
        public bool Update(TagClass t)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;

            //Step 1 : Connect database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Sql command to update data in the database
                string sql = "Update Tag set SubjectName=@SubjectName, SubjectCode=@SubjectCode, RelatedTag=@RelatedTag where Id=@Id";
                //Creating cmd using sql & conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to Add Data
                cmd.Parameters.AddWithValue("@Id", t.Id);
                cmd.Parameters.AddWithValue("@SubjectName", t.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", t.SubjectCode);
                cmd.Parameters.AddWithValue("@RelatedTag", t.RelatedTag);


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
        public bool Delete(TagClass t)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;

            //Create SQL connection 
            SqlConnection conn = new SqlConnection(myconnstring);


            try
            {
                //SQL to Delete data
                string sql = "Delete from Tag where Id=@Id";

                //Creating Sql Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", t.Id);

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
