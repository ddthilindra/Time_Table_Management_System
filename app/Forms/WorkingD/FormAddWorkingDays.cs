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

namespace app.Forms.WorkingD
{
    public partial class FormAddWorkingDays : UserControl
    {
        public FormAddWorkingDays()
        {
            InitializeComponent();
        }

        static FormAddWorkingDays _obj;
        public static FormAddWorkingDays Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FormAddWorkingDays();
                }
                return _obj;
            }
        }

        ClassWorkingDays workDays = new ClassWorkingDays();

        ArrayList arr = new ArrayList();
        private void buttonWSave_Click(object sender, EventArgs e)
        {
            //get value from input field
            workDays.NumberofWorking = numericUpDownNumofW.Value.ToString();
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
            //MessageBox.Show(days);

            workDays.WorkingDays = days;
            workDays.MonS = comboBoxM1.Text.Trim();
            workDays.MonE = comboBoxM2.Text.Trim();
            workDays.TueS = comboBoxTu1.Text.Trim();
            workDays.TueE = comboBoxTu2.Text.Trim();
            workDays.WedS = comboBoxW1.Text.Trim();
            workDays.WedE = comboBoxW2.Text.Trim();
            workDays.ThuS = comboBoxTh1.Text.Trim();
            workDays.ThuE = comboBoxTh2.Text.Trim();
            workDays.FriS = comboBoxF1.Text.Trim();
            workDays.FriE = comboBoxF2.Text.Trim();
            workDays.SatS = comboBoxS1.Text.Trim();
            workDays.SatE = comboBoxS2.Text.Trim();
            workDays.SunS = comboBoxSu1.Text.Trim();
            workDays.SunE = comboBoxSu2.Text.Trim();

            bool success = workDays.insert(workDays);

            if (success == true)
            {
                MessageBox.Show("Successfully Inserted");
            }
            else
            {
                MessageBox.Show("Error while inserting");
            }
        }

        private void buttonWClear_Click(object sender, EventArgs e)
        {            
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
    }
}
