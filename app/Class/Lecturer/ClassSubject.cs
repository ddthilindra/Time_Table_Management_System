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
    class ClassSubject
    {
        //Getter setter properties
        //Act as a data carrier in application
        public string ID { get; set; }
        public string SubName { get; set; }
        public string SubCode { get; set; }
        public string OfferYear { get; set; }
        public string OfferSemester { get; set; }
        public string NumLecHr { get; set; }
        public String NumTuteHr { get; set; }
        public String NumLabHr { get; set; }
        public String NumEveHr { get; set; }

        //Call Connection string get database info
        static string myconstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        //Methord to Select record from database
        public DataTable selectSubject()
        {
            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);
            DataTable dt = new DataTable();

            try
            {
                //Select query
                con.Open();
                string sql = "SELECT * FROM Subject";
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

        public bool insertSubject(ClassSubject s)
        {
            //Creating a deult return type and setting its value to false
            bool isSuccess = false;
            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);

            try
            {

                //Insert query
                String sql2 = "INSERT INTO Subject (SubjectCode,SubjectName,OfferedYear,OfferedSem,NumLecHr,NumTuteHr,NumLabHr,NumEveHr) VALUES (@txtSubCode,@txtSubName,@txtOffYear,@drpOffSem,@NumLecHr,@NumTuteHr,@NumLabHr,@NumEveHr)";

                SqlCommand cmd2 = new SqlCommand(sql2, con);

                //Create parameter to ad data
                cmd2.Parameters.AddWithValue("@txtOffYear", s.OfferYear);
                cmd2.Parameters.AddWithValue("@drpOffSem", s.OfferSemester);
                cmd2.Parameters.AddWithValue("@txtSubCode", s.SubCode);
                cmd2.Parameters.AddWithValue("@txtSubName", s.SubName);
                cmd2.Parameters.AddWithValue("@NumLecHr", s.NumLecHr);
                cmd2.Parameters.AddWithValue("@NumTuteHr", s.NumTuteHr);
                cmd2.Parameters.AddWithValue("@NumLabHr", s.NumLabHr);
                cmd2.Parameters.AddWithValue("@NumEveHr", s.NumEveHr);

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
        public bool deleteSubject(string id)
        {
            //Creating a deult return type and setting its value to false
            bool isSuccess = false;
            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);

            try
            {
                //Delete query
                String sql = "DELETE FROM Subject WHERE Id=@index";

                SqlCommand cmd = new SqlCommand(sql, con);

                //Create parameter to ad data
                cmd.Parameters.AddWithValue("@index", id);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show("Subject deleted successfully", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        //Methord to Update record in database from app
        public bool updateSubject(ClassSubject s)
        {
            //Creating a deult return type and setting its value to false
            bool isSuccess = false;

            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);

            try
            {

                //Update query
                String sql = "UPDATE Subject SET SubjectCode=@txtSubCode,SubjectName=@txtSubName,OfferedYear=@txtOffYear,OfferedSem=@drpOffSem,NumLecHr=@NumLecHr,NumTuteHr=@NumTuteHr,NumLabHr=@NumLabHr,NumEveHr=@NumEveHr WHERE Id=@txtId";

                SqlCommand cmd = new SqlCommand(sql, con);

                //Create parameter to ad data
                cmd.Parameters.AddWithValue("@txtId", s.ID);
                cmd.Parameters.AddWithValue("@txtOffYear", s.OfferYear);
                cmd.Parameters.AddWithValue("@drpOffSem", s.OfferSemester);
                cmd.Parameters.AddWithValue("@txtSubCode", s.SubCode);
                cmd.Parameters.AddWithValue("@txtSubName", s.SubName);
                cmd.Parameters.AddWithValue("@NumLecHr", s.NumLecHr);
                cmd.Parameters.AddWithValue("@NumTuteHr", s.NumTuteHr);
                cmd.Parameters.AddWithValue("@NumLabHr", s.NumLabHr);
                cmd.Parameters.AddWithValue("@NumEveHr", s.NumEveHr);

                //MessageBox.Show("" + s.ID + s.OfferYear + s.OfferSemester + s.SubName + s.SubCode + s.NumLecHr + s.NumTuteHr + s.NumLabHr + s.NumEveHr + "Update Called", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);


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

        //Methord to check subject id alredy in database
        public bool chkSubID(string code)
        {
            //Creating a deult return type and setting its value to false
            bool isSuccess = false;
            //Database Connection
            SqlConnection con = new SqlConnection(myconstr);

            try
            {
                //Select query to find the Subject Code
                String sql = "SELECT * FROM Subject WHERE SubjectCode=@id";

                SqlCommand cmd = new SqlCommand(sql, con);

                //Create parameter to ad data
                cmd.Parameters.AddWithValue("@id", code);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                //Creating sql data reader Subject Code already exist
                SqlDataReader dr = cmd.ExecuteReader();

                //if dataset has rows show the 
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MessageBox.Show("Sorry, " + dr.GetValue(2).ToString() + " " + dr.GetValue(1).ToString() + " Subject Code already exists!\n\nPlease try again using another Lecturer ID or Update Lecturer profile", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dr.Close();

                    isSuccess = true;//Subject Code not in table
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
