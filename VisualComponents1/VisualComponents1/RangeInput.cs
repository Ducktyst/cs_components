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
 Визуальный компонент для ввода значения с проверкой 
вхождения в диапазон (TextBox, DateTimePicker, 
NumericUpDown). Должно быть 2 публичных поля для настройки 
границ диапазона. 

Публичное свойство для установки и получения введенного 
значения (set, get). При получении должна проводиться проверка, 
если введенное значение не входит в диапазон, возвращать 
значение null, а в отдельное поле выводить текст ошибки. При 
установке должна проводиться проверка, если передаваемое 
значение не входит в диапазон, то не заполнять поле компонента. 
Создать также событие, вызываемое при смене значения

Список значений. Список 
заполняется через метод, 
передающий объект
 */
namespace VisualComponents1
{
    public partial class RangeInput : UserControl
    {
        public int MinLength { get; set; } = 0;
        public int MaxLength { get; set; } = 100;
        
        public event EventHandler ContentChanged;
        public RangeInput()
        {
            InitializeComponent();
        }

        private void listView_ItemActivate(object sender, EventArgs e)
        {
            // activate remove item button
        }

        public virtual void  OnContentChanged(EventArgs e)
        {
            ContentChanged?.Invoke(this, e);
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            if (tbInput.Text.Length < MinLength || tbInput.Text.Length > MaxLength)
            {
                btnAdd.Enabled = false;
            }
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
