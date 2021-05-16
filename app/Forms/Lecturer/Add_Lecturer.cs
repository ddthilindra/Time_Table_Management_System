using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class Add_Lecturer : UserControl
    {
        static Add_Lecturer _obj;

        public static Add_Lecturer Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Add_Lecturer();
                }
                return _obj;
            }
        }

        public Add_Lecturer()
        {
            InitializeComponent();
        }
    }
}
