using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    class ClassLecturer
    {
        //Getter setter properties
        //Act as a data carrier in app

        public String ID { get; set; }
        public String LecturerID { get; set; }
        public String Name { get; set; }
        public String Center { get; set; }
        public String Faculty { get; set; }
        public String Department { get; set; }
        public String Building { get; set; }
        public String Level { get; set; }
        public String WorkingDay { get; set; }
        public String WorkingHours { get; set; }
        public String Rank { get; set; }

        //Call Connection string get database info
        static string myconstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //Methord to Select record from database
        public DataTable selectLecturer()
        {
            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);
            DataTable dt = new DataTable();

            try
            {
                //Select query
                con.Open();
                string sql = "SELECT Id,Lecturerid,Name,Faculty,Department,Center,Building,Level,WD,WH FROM Lecturer";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                adapter.Fill(dt);

                //dgv.DataSource=dt;
            }
            catch(Exception ex)
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
        public bool insertLecturer(ClassLecturer l)
        {
            //Creating a deult return type and setting its value to false
            bool isSuccess = false;
            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);
            
            try
            {
                
                //Insert query
                String sql2 = "INSERT INTO Lecturer (Lecturerid,Name,Center,Faculty,Department,Building,Level,WD,WH,Rank) VALUES (@txtLecturerId,@txtName,@ddCenter,@ddFaculty,@ddDepartment,@ddBuilding,@ddLevel,@ddWorkingD,@ddWorkingH,@txtRank)";

                SqlCommand cmd2 = new SqlCommand(sql2, con);

                //Create parameter to ad data
                cmd2.Parameters.AddWithValue("@txtLecturerId", l.LecturerID);
                cmd2.Parameters.AddWithValue("@txtName", l.Name);
                cmd2.Parameters.AddWithValue("@ddCenter", l.Center);
                cmd2.Parameters.AddWithValue("@ddFaculty", l.Faculty);
                cmd2.Parameters.AddWithValue("@ddDepartment", l.Department);
                cmd2.Parameters.AddWithValue("@ddBuilding", l.Building);
                cmd2.Parameters.AddWithValue("@ddLevel", l.Level);
                cmd2.Parameters.AddWithValue("@ddWorkingD", l.WorkingDay);
                cmd2.Parameters.AddWithValue("@ddWorkingH", l.WorkingHours);
                cmd2.Parameters.AddWithValue("@txtRank", l.Rank);

                con.Open();

                int rows2 = cmd2.ExecuteNonQuery();

                if (rows2 > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
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
        public bool updateLecturer(ClassLecturer l)
        {
            //Creating a deult return type and setting its value to false
            bool isSuccess = false;

            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);
            
            try
            {

                //Update query
                String sql = "UPDATE Lecturer SET Lecturerid=@txtLecturerId,Name=@txtName,Center=@ddCenter,Faculty=@ddFaculty,Department=@ddDepartment,Building=@ddBuilding,Level=@ddLevel,WD=@ddWorkingD,WH=@ddWorkingH,Rank=@txtRank WHERE Id=@txtId";

                SqlCommand cmd = new SqlCommand(sql, con);

                //Create parameter to ad data
                cmd.Parameters.AddWithValue("@txtId", l.ID);
                cmd.Parameters.AddWithValue("@txtLecturerId", l.LecturerID);
                cmd.Parameters.AddWithValue("@txtName", l.Name);
                cmd.Parameters.AddWithValue("@ddCenter", l.Center);
                cmd.Parameters.AddWithValue("@ddFaculty", l.Faculty);
                cmd.Parameters.AddWithValue("@ddDepartment", l.Department);
                cmd.Parameters.AddWithValue("@ddBuilding", l.Building);
                cmd.Parameters.AddWithValue("@ddLevel", l.Level);
                cmd.Parameters.AddWithValue("@ddWorkingD", l.WorkingDay);
                cmd.Parameters.AddWithValue("@ddWorkingH", l.WorkingHours);
                cmd.Parameters.AddWithValue("@txtRank", l.Rank);

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
        public bool deleteLecturer(string id)
        {
            //Creating a deult return type and setting its value to false
            bool isSuccess = false;
            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);

            try
            {
                //Delete query
                String sql = "DELETE FROM Lecturer WHERE Id=@index";

                SqlCommand cmd = new SqlCommand(sql, con);

                //Create parameter to ad data
                cmd.Parameters.AddWithValue("@index", id);
                
                con.Open();

                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted Successfully", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show("Delete Faild", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        public bool user(string id)
        {
            //Creating a deult return type and setting its value to false
            bool isSuccess = false;
            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);

            try
            {
                //Delete query
                String sql = "SELECT Lecturerid FROM Lecturer WHERE Lecturerid=@uid";

                SqlCommand cmd = new SqlCommand(sql, con);

                //Create parameter to ad data
                cmd.Parameters.AddWithValue("@uid", id);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show("Class Called "+id+"", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show("Delete Faild", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
    }
}
