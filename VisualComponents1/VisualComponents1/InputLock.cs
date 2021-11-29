using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Текстовый визуальный компонент для ввода значения
определенного типа (TextBox), предусматривающий
возможность пустого (не заполненного значения). В контроле
должен быть CheckBox, который при проставленной галочке
будет обозначать признак незаполненного значения (null) и
неактивным элементом ввода значения (TextBox). При не
проставленной галочке элемент ввода значения должен быть
активным для заполнения.
Также требуется свойство для установки и получения введенного
значения (set, get) (предусмотреть возможность возврата
значения null). Если у CheckBox не проставлена галочка, а в
элементе не введено значение, выдавать ошибку. Если введенное
значение не соответствует требуемому типу, выдавать ошибку.
Создать также событие, вызываемое при смене значения (либо
при смене CheckBox).

Выпадающий список. Список заполняется через 
метод, передающий строку
*/
namespace VisualComponents1
{
    public partial class InputLock : UserControl
    {
        private string savedValue;
        public string SavedValue
        {
            get {
                if (checkBoxLock.Checked) {
                    return savedValue;
                 }

                if (!checkBoxLock.Checked || (textBox.Text == "" || textBox.Text == null))
                {
                    return null;
                    throw new WarningException("textBox is locked and have no value");
                }

                return savedValue;
            }
            set {
                if (!checkBoxLock.Checked)
                {
                    return;
                }
                if (!(value is string))
                {
                    MessageBox.Show("attempt to set not string value");
                    return;
                    throw new WarningException("attempt to set not string value");
                }

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
