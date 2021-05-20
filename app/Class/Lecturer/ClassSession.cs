using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Class.Lecturer
{
    class ClassSession
    {
        //Getter setter properties
        //Act as a data carrier in application
        public string ID { get; set; }
        public string Faculty { get; set; }
        public string lecturer1 { get; set; }
        public string lecturer2 { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string Tag { get; set; }
        public String Year { get; set; }
        public String GID { get; set; }
        public String SubGID { get; set; }
        public String noOfStu { get; set; }
        public String Duration { get; set; }
        public String Generate { get; set; }
        

        //Call Connection string get database info
        static string myconstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //Methord to Select record from database
        public DataTable selectSession()
        {
            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);
            DataTable dt = new DataTable();

            try
            {
                //Select query
                con.Open();
                string sql = "SELECT Id,Faculty,Lecturer1,Lecturer2,SubjectName,SubjectCode,Tag,GroupID,SubGroupID,Year,NumOfStu,Duration,Status FROM Session";
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

        //Methord to Insert record into database
        public bool insertSession(ClassSession s)
        {
            //Creating a deult return type and setting its value to false
            bool isSuccess = false;
            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);

            try
            {

                //Insert query
                String sql2 = "INSERT INTO Session (Faculty,Lecturer1,Lecturer2,SubjectCode,SubjectName,GroupID,SubGroupID,Tag,Year,NumOfStu,Duration,SessionCode) VALUES (@faculty,@txtLecturer1,@txtLecturer2,@subcode,@subname,@gid,@subgid,@tag,@year,@noofstu,@duration,@generate)";

                SqlCommand cmd = new SqlCommand(sql2, con);

                //Create parameter to ad data
                cmd.Parameters.AddWithValue("@faculty", s.Faculty);
                cmd.Parameters.AddWithValue("@txtLecturer1", s.lecturer1);
                cmd.Parameters.AddWithValue("@txtLecturer2", s.lecturer2);
                cmd.Parameters.AddWithValue("@subcode", s.SubjectCode);
                cmd.Parameters.AddWithValue("@subname", s.SubjectName);
                cmd.Parameters.AddWithValue("@gid", s.GID);
                cmd.Parameters.AddWithValue("@subgid", s.SubGID);
                cmd.Parameters.AddWithValue("@tag", s.Tag);
                cmd.Parameters.AddWithValue("@year", s.Year);
                cmd.Parameters.AddWithValue("@noofstu", s.noOfStu);
                cmd.Parameters.AddWithValue("@duration", s.Duration);
                cmd.Parameters.AddWithValue("@generate", s.Generate);

                con.Open();

                int rows2 = cmd.ExecuteNonQuery();

                if (rows2 > 0)
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
                con.Close();
            }
            return isSuccess;
        }

        //Methord to Update record in database from app
        public bool updatesession(ClassSession s)
        {
            //Creating a deult return type and setting its value to false
            bool isSuccess = false;

            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);

            try
            {
                //Update query
                String sql = "UPDATE Session SET Faculty=@faculty,Lecturer1=@txtLecturer1,Lecturer2=@txtLecturer2,SubjectCode=@subcode,SubjectName=@subname,GroupID=@gid,SubGroupID=@subgid,Tag=@tag,Year=@year,NumOfStu=@noofstu,Duration=@duration,SessionCode=@generate WHERE Id=@txtId";

                SqlCommand cmd = new SqlCommand(sql, con);

                //Create parameter to ad data
                cmd.Parameters.AddWithValue("@txtId", s.ID);
                cmd.Parameters.AddWithValue("@faculty", s.Faculty);
                cmd.Parameters.AddWithValue("@txtLecturer1", s.lecturer1);
                cmd.Parameters.AddWithValue("@txtLecturer2", s.lecturer2);
                cmd.Parameters.AddWithValue("@subcode", s.SubjectCode);
                cmd.Parameters.AddWithValue("@subname", s.SubjectName);
                cmd.Parameters.AddWithValue("@gid", s.GID);
                cmd.Parameters.AddWithValue("@subgid", s.SubGID);
                cmd.Parameters.AddWithValue("@tag", s.Tag);
                cmd.Parameters.AddWithValue("@year", s.Year);
                cmd.Parameters.AddWithValue("@noofstu", s.noOfStu);
                cmd.Parameters.AddWithValue("@duration", s.Duration);
                cmd.Parameters.AddWithValue("@generate", s.Generate);

                con.Open();

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
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        //Methord to Delete record in database from app
        public bool deleteSession(string id)
        {
            //Creating a deult return type and setting its value to false
            bool isSuccess = false;
            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);

            try
            {
                //Delete query
                String sql = "DELETE FROM Session WHERE Id=@index";

                SqlCommand cmd = new SqlCommand(sql, con);

                //Create parameter to ad data
                cmd.Parameters.AddWithValue("@index", id);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show("Session deleted successfully", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show("Exception Called : " + ex + "", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
    }
}
