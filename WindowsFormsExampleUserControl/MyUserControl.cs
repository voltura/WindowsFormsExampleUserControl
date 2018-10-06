using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExampleUserControl
{
    public partial class MyUserControl : AbstractUserControlClass
    {
        private bool _custom;

        public MyUserControl()
        {
            InitializeComponent();
        }

        public override bool GetCustom { get => _custom; set => _custom = value; }

    }
}
