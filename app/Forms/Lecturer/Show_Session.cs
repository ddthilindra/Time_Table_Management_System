using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms.Lecturer
{
    public partial class Show_Session : UserControl
    {
        static Show_Session _obj;

        public static Show_Session Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Show_Session();
                }
                return _obj;
            }
        }

        public Show_Session()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown4_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown11_onItemSelected(object sender, EventArgs e)
        {

        }

        private void Show_Session_Load(object sender, EventArgs e)
        {
            lecTbl.Rows.Add(
                new object[]
                {
                    001,
                    "Jayalath K",
                    "Haritha J.A",
                    "IT3010",
                    "OOC",
                    "Y1S1 IT 1.1",
                    "Lec"

                }
                );

            lecTbl.Rows.Add(
                new object[]
                {
                    002,
                    "Pathirana",
                    "Jayasuriya ",
                    "IT3010",
                    "DMS",
                    "Y1S1 IT 1.2",
                    "Tute"

                }
                );
            lecTbl.Rows.Add(
                            new object[]
                            {
                    003,
                    "Ravi S",
                    "Nath Rupasinghe",
                    "IT3010",
                    "OOP",
                    "Y1S1 IT 9.1",
                    "Tute"

                            }
                            );
            lecTbl.Rows.Add(
                            new object[]
                            {

                                004,
                    "Palliyaguru K",
                    "",
                    "IT3010",
                    "PAF",
                    "Y1S1 IT 9.3",
                    "Lab"

                            }
                            );
            lecTbl.Rows.Add(
                            new object[]
                            {

                     005,
                    "Sandaruwan K",
                    "Kumara P",
                    "IT3010",
                    "NDM",
                    "Y1S1 IT 1.1",
                    "Lec"

                            }
                            );
            lecTbl.Rows.Add(
                            new object[]
                            {
                    006,
                    "Samaranayake K",
                    "Lakmak K",
                    "IT3010",
                    "OOC",
                    "Y1S1 IT 3.1",
                    "Practical"

                            }
                            );
            lecTbl.Rows.Add(
                            new object[]
                            {
                    007,
                    "Kanchana K",
                    "",
                    "IT3010",
                    "OOC",
                    "Y1S1 IT 8.1",
                    "Lab"

                            }

                            );

            lecTbl.Rows.Add(
                            new object[]
                            {
                    008,
                    "Kanchana K",
                    "",
                    "IT3010",
                    "DMS",
                    "Y1S1 IT 12.1",
                    "Lec"

                            }

                            );

            lecTbl.Rows.Add(
                            new object[]
                            {
                    001,
                    "Kanchana K",
                    "",
                    "IT3010",
                    "OOC",
                    "Y1S1 IT 1.1",
                    "Lec"

                            }

                            );

            lecTbl.Rows.Add(
                            new object[]
                            {
                    001,
                    "Kanchana K",
                    "",
                    "IT3010",
                    "OOC",
                    "Y1S1 IT 1.1",
                    "Lec"

                            }

                            );
        }
    }
}
