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

        static string myconstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        public DataTable selectLecturer()
        {
            SqlConnection con = new SqlConnection(myconstr);
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                string sql = "SELECT Lecturerid,Name,Faculty,Department,Center,Building,Level FROM Lecturer";
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

        public bool insertLecturer(ClassLecturer l)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(myconstr);
            
            try
            {
                String sql = "INSERT INTO Lecturer (Lecturerid,Name,Center,Faculty,Department,Building,Level,WD,WH,Rank) VALUES (@txtLecturerId,@txtName,@ddCenter,@ddFaculty,@ddDepartment,@ddBuilding,@ddLevel,@ddWorkingD,@ddWorkingH,@txtRank)";

                SqlCommand cmd = new SqlCommand(sql, con);

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

        public bool updateLecturer(ClassLecturer l)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(myconstr);
            
            try
            {
                String sql = "UPDATE Lecturer SET Lecturerid=@txtLecturerId,Name=@txtName,Center=@ddCenter,Faculty=@ddFaculty,Department=@ddDepartment,Building=@ddBuilding,Level=@ddLevel,WD=@ddWorkingD,WH=@ddWorkingH,Rank=@txtRank";

                SqlCommand cmd = new SqlCommand(sql, con);

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

        public bool deleteLecturer(string id)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(myconstr);

            try
            {
                String sql = "DELETE FROM Lecturer WHERE Lecturerid=@txtLecturerId";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@txtLecturerId", id);
                
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
    }
}
