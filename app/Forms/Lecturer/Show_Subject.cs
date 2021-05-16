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
    public partial class Show_Subject : UserControl
    {
        static Show_Subject _obj;

        public static Show_Subject Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Show_Subject();
                }
                return _obj;
            }
        }

        public Show_Subject()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void Show_Subject_Load(object sender, EventArgs e)
        {
            lecTbl.Rows.Add(
                new object[]
                {
                    001,
                    "OOC",
                    "IT3010",
                    "Y1",
                    "S1"

                }
                );

            lecTbl.Rows.Add(
                new object[]
                {
                    002,
                    "Paf",
                    "IT2020",
                    "Y1",
                    "S1"

                }
                );
            lecTbl.Rows.Add(
                            new object[]
                            {
                    003,
                    "IWT",
                    "IT3010",
                    "Y2",
                    "S2"

                            }
                            );
            lecTbl.Rows.Add(
                            new object[]
                            {

                                004,
                    "PS",
                    "IT3040",
                    "Y1",
                    "S1"

                            }
                            );
            lecTbl.Rows.Add(
                            new object[]
                            {

                     005,
                    "MAD",
                    "IT3010",
                    "Y2",
                    "S1"

                            }
                            );
            lecTbl.Rows.Add(
                            new object[]
                            {
                    006,
                    "ESD",
                    "IT3010",
                    "Y3",
                    "S1"

                            }
                            );
            lecTbl.Rows.Add(
                            new object[]
                            {
                    007,
                    "MAC",
                    "IT3010",
                    "Y4",
                    "S1"

                            }

                            );

            lecTbl.Rows.Add(
                            new object[]
                            {
                    008,
                    "OOC",
                    "IT3010",
                    "Y1",
                    "S1"

                            }

                            );

            lecTbl.Rows.Add(
                            new object[]
                            {
                    001,
                    "Kanchana K",
                    "",
                    "IT3010",
                    "OOC"

                            }

                            );

            lecTbl.Rows.Add(
                            new object[]
                            {
                    001,
                    "Kanchana K",
                    "",
                    "IT3010",
                    "OOC"

                            }

                            );
        }
    }
}
