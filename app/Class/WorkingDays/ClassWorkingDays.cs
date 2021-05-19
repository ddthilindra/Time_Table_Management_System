using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Class.WorkingDays
{
    class ClassWorkingDays
    {
        //Getter setter properties
        //Act as a data carrier in app

        public int Id { get; set; }
        public String NumberofWorking { get; set; }
        public String WorkingDays { get; set; }
        public String MonS { get; set; }
        public String MonE { get; set; }
        public String TueS { get; set; }
        public String TueE { get; set; }
        public String WedS { get; set; }
        public String WedE { get; set; }
        public String ThuS { get; set; }
        public String ThuE { get; set; }
        public String FriS { get; set; }
        public String FriE { get; set; }
        public String SatS { get; set; }
        public String SatE { get; set; }
        public String SunS { get; set; }
        public String SunE { get; set; }



        //Call Connection string get database info
        static string connString = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;



        //Methord to Select record from database
        public DataTable select()
        {
            //Database Connection
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                //Select query
                con.Open();
                string sql = "SELECT * from Work";
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

        //Methord to Insert record into database
        public bool insert(ClassWorkingDays workDays)
        {
            //Creating a deult return type and setting its value to false
            bool isSuccess = false;
            //Database Connection
            SqlConnection con = new SqlConnection(connString);

            try
            {

                //Insert query
                String sql = "INSERT INTO Work (NumberofWorking,WorkingDays,MonS,MonE,TueS,TueE,WedS,WedE,ThuS,ThuE,FriS,FriE,SatS,SatE,SunS,SunE) VALUES (@numericUpDownNumofW,@WorkingDays,@comboBoxM1,@comboBoxM2,@comboBoxTu1,@comboBoxTu2,@comboBoxW1,@comboBoxW2,@comboBoxTh1,@comboBoxTh2,@comboBoxF1,@comboBoxF2,@comboBoxS1,@comboBoxS2,@comboBoxSu1,@comboBoxSu2)";

                SqlCommand cmd = new SqlCommand(sql, con);


                //Create parameter to ad data
                cmd.Parameters.AddWithValue("@numericUpDownNumofW", workDays.NumberofWorking);
                cmd.Parameters.AddWithValue("@WorkingDays", workDays.WorkingDays);
                cmd.Parameters.AddWithValue("@comboBoxM1", workDays.MonS);
                cmd.Parameters.AddWithValue("@comboBoxM2", workDays.MonE);
                cmd.Parameters.AddWithValue("@comboBoxTu1", workDays.TueS);
                cmd.Parameters.AddWithValue("@comboBoxTu2", workDays.TueE);
                cmd.Parameters.AddWithValue("@comboBoxW1", workDays.WedS);
                cmd.Parameters.AddWithValue("@comboBoxW2", workDays.WedE);
                cmd.Parameters.AddWithValue("@comboBoxTh1", workDays.ThuS);
                cmd.Parameters.AddWithValue("@comboBoxTh2", workDays.ThuE);
                cmd.Parameters.AddWithValue("@comboBoxF1", workDays.FriS);
                cmd.Parameters.AddWithValue("@comboBoxF2", workDays.FriE);
                cmd.Parameters.AddWithValue("@comboBoxS1", workDays.SatS);
                cmd.Parameters.AddWithValue("@comboBoxS2", workDays.SatE);
                cmd.Parameters.AddWithValue("@comboBoxSu1", workDays.SunS);
                cmd.Parameters.AddWithValue("@comboBoxSu2", workDays.SunE);

                //MessageBox.Show("Exception Called : " +workDays.Mon+ workDays.MonS + workDays.MonE + "", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);


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


        public bool Update(ClassWorkingDays workDays)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;

            //Step 1 : Connect database
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //Sql command to update data in the database
                string sql = "update Work set NumberofWorking=@numericUpDownNumofW, WorkingDays=@WorkingDays, MonS=@comboBoxM1, MonE=@comboBoxM2, TueS=@comboBoxTu1, TueE=@comboBoxTu2, WedS=@comboBoxW1, WedE=@comboBoxW2, ThuS=@comboBoxTh1, ThuE=@comboBoxTh2, FriS=@comboBoxF1, FriE=@comboBoxF2, SatS=@comboBoxS1, SatE=@comboBoxS2,SunS=@comboBoxSu1, SunE=@comboBoxSu2 where Id = @id";
                //Creating cmd using sql & conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to Add Data
                cmd.Parameters.AddWithValue("@id", workDays.Id);
                cmd.Parameters.AddWithValue("@numericUpDownNumofW", workDays.NumberofWorking);
                cmd.Parameters.AddWithValue("@WorkingDays", workDays.WorkingDays);
                cmd.Parameters.AddWithValue("@comboBoxM1", workDays.MonS);
                cmd.Parameters.AddWithValue("@comboBoxM2", workDays.MonE);
                cmd.Parameters.AddWithValue("@comboBoxTu1", workDays.TueS);
                cmd.Parameters.AddWithValue("@comboBoxTu2", workDays.TueE);
                cmd.Parameters.AddWithValue("@comboBoxW1", workDays.WedS);
                cmd.Parameters.AddWithValue("@comboBoxW2", workDays.WedE);
                cmd.Parameters.AddWithValue("@comboBoxTh1", workDays.ThuS);
                cmd.Parameters.AddWithValue("@comboBoxTh2", workDays.ThuE);
                cmd.Parameters.AddWithValue("@comboBoxF1", workDays.FriS);
                cmd.Parameters.AddWithValue("@comboBoxF2", workDays.FriE);
                cmd.Parameters.AddWithValue("@comboBoxS1", workDays.SatS);
                cmd.Parameters.AddWithValue("@comboBoxS2", workDays.SatE);
                cmd.Parameters.AddWithValue("@comboBoxSu1", workDays.SunS);
                cmd.Parameters.AddWithValue("@comboBoxSu2", workDays.SunE);

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

        public bool Delete(ClassWorkingDays workDays)
        {
            bool c = false;
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\T.V.C\Desktop\app\app\TimeTableDB.mdf;Integrated Security=True;User Instance=True");
            try
            {
                string sql = "DELETE FROM Work WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", workDays.Id);

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
