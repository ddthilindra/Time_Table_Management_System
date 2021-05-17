using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Class.Lecturer
{
    class ClassSession
    {
        public int MyProperty { get; set; }

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
                string sql = "SELECT Id,Lecturer1,Lecturer2,SubjectCode,SubjectName,GroupID,SubGroupID,Tag FROM Session";
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
    }
}
