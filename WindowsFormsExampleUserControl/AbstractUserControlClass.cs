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
    public abstract class AbstractUserControlClass : UserControl
    {
        public AbstractUserControlClass()
        {
        }
        public override bool AutoSize { get => true; set => base.AutoSize = value; }
        public abstract bool GetCustom { get; set; }
    }
}
