using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace VisualComponents1
{
    public partial class NewTabControl : System.Windows.Forms.TabControl
    {
        public NewTabControl()
        {
            InitializeComponent();
        }

        public NewTabControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            int TCM_ADJUSTRECT = 0x1328;
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }
    }

    public class NewTabPanel : System.Windows.Forms.Panel
    {

    }

    public class PanelTP: System.Windows.Forms.Panel
    { 
    }
}
