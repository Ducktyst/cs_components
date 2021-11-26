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
    public partial class InputLock : UserControl
    {
        private string savedValue;
        public string SavedValue
        {
            get {
                if (checkBoxLock.Checked) {
                    savedValue = SavedValue;
                    return SavedValue;
                 }

                if (!checkBoxLock.Checked && (textBox.Text == "" || textBox.Text == null))
                {
                    //MessageBox.Show("textBox is locked and have not value");
                    return null;
                    throw new WarningException("textBox is locked and have no value");
                }

                savedValue = SavedValue;
                return SavedValue;
            }
            set {
                /*if (!checkBoxLock.Checked)
                {
                    return;
                }*/
         /*       if (!(value is string))
                {
                    //MessageBox.Show("attempt to set not string value");
                    return;
                    throw new WarningException("attempt to set not string value");
                }
*/
               // SavedValue = value;
                savedValue = value;
            }
        }

        private event EventHandler _lockChanged;
        
        public event EventHandler LockChanged
        {
            add { _lockChanged += value; }
            remove { _lockChanged -= value; }
        }

        public event EventHandler ValueChanged;


        public InputLock()
        {
            InitializeComponent();
            checkBoxLock.EnabledChanged += (object sender, EventArgs e) => { };
        }

        private void InputLock_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxLock_CheckedChanged(object sender, EventArgs e)
        {
            // Is it checked?
            if (checkBoxLock.Checked)
            {
                textBox.Enabled = false;
                
                SavedValue = textBox.Text;
                savedValue = SavedValue;
                textBox.Text = null;
            } else 
            {
                textBox.Enabled = true;

                textBox.Text = savedValue;
            }

            //LockChanged(EventArgs.Empty);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OnValueChanged(EventArgs.Empty);
        }

        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }
    }
}
