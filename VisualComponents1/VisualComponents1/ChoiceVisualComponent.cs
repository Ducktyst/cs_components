using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualComponents1
{
    public partial class ChoiceVisualComponent : UserControl
    {
        public int NewProp { get; set; }
        public ChoiceVisualComponent()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AddElement(string element)
        {
            this.comboBox1.Items.Add(element);
        }
    }
}
