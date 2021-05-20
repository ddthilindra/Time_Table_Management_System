using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Class.WorkingDays;
using System.Collections;
using System.Data.SqlClient;

namespace app.Forms.WorkingD
{
    public partial class FormManageWorkingDays : UserControl
    {
        static FormManageWorkingDays _obj;
        public static FormManageWorkingDays Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FormManageWorkingDays();
                }
                return _obj;
            }
        }

        ClassWorkingDays wd = new ClassWorkingDays();

        string ID, NumOfWorkingDays, WorkingDays, monS, monE, tueS, tueE, wedS, wedE, thuS, thuE, friS, friE, satS, satE, sunS, sunE;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            numericUpDownNumofW.Value = 0;
            comboBoxM1.SelectedIndex = -1;
            comboBoxM2.SelectedIndex = -1;
            comboBoxS1.SelectedIndex = -1;
            comboBoxS2.SelectedIndex = -1;
            comboBoxF1.SelectedIndex = -1;
            comboBoxF2.SelectedIndex = -1;
            comboBoxSu1.SelectedIndex = -1;
            comboBoxSu2.SelectedIndex = -1;
            comboBoxTh1.SelectedIndex = -1;
            comboBoxTh2.SelectedIndex = -1;
            comboBoxTu1.SelectedIndex = -1;
            comboBoxTu2.SelectedIndex = -1;
            comboBoxW1.SelectedIndex = -1;
            comboBoxW2.SelectedIndex = -1;
            checkBoxMO.Checked = false;
            checkBoxFr.Checked = false;
            checkBoxSa.Checked = false;
            checkBoxSu.Checked = false;
            checkBoxThur.Checked = false;
            checkBoxTU.Checked = false;
            checkBoxWe.Checked = false;
        }

        int x = 0;
        public FormManageWorkingDays()
        {
            InitializeComponent();
        }
        ArrayList arr = new ArrayList();

        //DB connection
        static string myconstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxMO.Checked)
            {
                arr.Add("Monday");
            }
            if (checkBoxTU.Checked)
            {
                arr.Add("Tuesday");
            }
            if (checkBoxWe.Checked)
            {
                arr.Add("Wednesday");
            }
            if (checkBoxThur.Checked)
            {
                arr.Add("Thursday");
            }
            if (checkBoxFr.Checked)
            {
                arr.Add("Friday");
            }
            if (checkBoxSa.Checked)
            {
                arr.Add("Saturday");
            }
            if (checkBoxSu.Checked)
            {
                arr.Add("Sunday");
            }

            String[] Arr = (String[])arr.ToArray(typeof(String));
            String days = string.Join(",", Arr);

            int x = Int32.Parse(textBox2.Text);
            wd.Id = x;
            wd.NumberofWorking = numericUpDownNumofW.Text;
            wd.WorkingDays = days;
            wd.MonS = comboBoxM1.Text;
            wd.MonE = comboBoxM2.Text;
            wd.TueS = comboBoxTu1.Text;
            wd.TueE = comboBoxTu2.Text;
            wd.WedS = comboBoxW1.Text;
            wd.WedE = comboBoxW2.Text;
            wd.ThuS = comboBoxTh1.Text;
            wd.ThuE = comboBoxTh2.Text;
            wd.FriS = comboBoxF1.Text;
            wd.FriE = comboBoxF2.Text;
            wd.SatS = comboBoxS1.Text;
            wd.SatE = comboBoxS2.Text;
            wd.SunS = comboBoxSu1.Text;
            wd.SunE = comboBoxSu2.Text;

            bool s = wd.Update(wd);

            if (s == true)
            {
                MessageBox.Show("Successfull");
            }
            else
            {
                MessageBox.Show("UnSuccessfull");
            }

            using (SqlConnection con = new SqlConnection(myconstr))
            {
                con.Open();
                SqlDataAdapter sad = new SqlDataAdapter("SELECT *FROM  Work WHERE Id = '" + textBox2.Text.Trim() + "'", con);
                DataTable dt = new DataTable();
                _ = sad.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void buttonWDelete_Click(object sender, EventArgs e)
        {
            int y = Int32.Parse(ID);
            wd.Id = y;

            bool s = wd.Delete(wd);

            if (s == true)
            {
                if (MessageBox.Show("Are you sure?\n\nDo you really want to delete this record?\nThis process cannot be undone!", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    MessageBox.Show("Successfull");
                }                    
            }
            else
            {
                MessageBox.Show("UnSuccessfull");
            }
            DataTable dt = wd.select();
            dataGridView1.DataSource = dt;
        }

        public void tableLoad()
        {
            DataTable dt = wd.select();
            dataGridView1.DataSource = dt;
        }

        private void buttonWUpdate_Click(object sender, EventArgs e)
        {
            textBox2.Text = ID;
            numericUpDownNumofW.Text = NumOfWorkingDays;
            textBox1.Text = WorkingDays;

            comboBoxM1.Text = monS;
            comboBoxM2.Text = monE;
            comboBoxTu1.Text = tueS;
            comboBoxTu2.Text = tueE;
            comboBoxW1.Text = wedS;
            comboBoxW2.Text = wedE;
            comboBoxTh1.Text = thuS;
            comboBoxTh2.Text = thuE;
            comboBoxF1.Text = friS;
            comboBoxF2.Text = friE;
            comboBoxS1.Text = satS;
            comboBoxS2.Text = satE;
            comboBoxSu1.Text = sunS;
            comboBoxSu2.Text = sunE;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            ID = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            NumOfWorkingDays = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            WorkingDays = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            monS = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            monE = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            tueS = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            tueE = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            wedS = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            wedE = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
            thuS = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
            thuE = dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
            friS = dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
            friE = dataGridView1.Rows[rowIndex].Cells[12].Value.ToString();
            satS = dataGridView1.Rows[rowIndex].Cells[13].Value.ToString();
            satE = dataGridView1.Rows[rowIndex].Cells[14].Value.ToString();
            sunS = dataGridView1.Rows[rowIndex].Cells[15].Value.ToString();
            sunE = dataGridView1.Rows[rowIndex].Cells[16].Value.ToString();
        }

        private void FormManageWorkingDays_Load(object sender, EventArgs e)
        {
            DataTable dt = wd.select();
            dataGridView1.DataSource = dt;
        }
    }
}
