using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Визуальный компонент для вывода списка в виде списка записей
(ListBox). 

Строки ListBox заполняются на основе макетной
строки. В макетной строке указывается некая фраза (например,
«Температура воздуха {T}, давление {P}»). Вместо {T} и {P}
подставляются значения из свойств/полей объекта какого-то
класса. Из каких именно свойств/полей вытаскиваются значения,
указывается внутри фигурных скобок (в примере это будет имена
свойств/полей T и P).

Также задаются символы, которые будут
означать начало и конец имени свойства в макетной строке (в
примере это будут символы ʹ{ʹ и ʹ}ʹ).

Макетная строка и символы начала и конца для имени свойства 
заполняется через публичный метод. 

Публичное свойство для установки и получения индекса
выбранной строки (set, get). 
Публичный параметризованный метод для получения объекта 
из выбранной строки (создать объект и через рефлексию заполнить свойства его).

Заполнение может происходит 3 возможными способами, в
зависимости от варианта:
 через параметризованный метод, у которого в
передаваемых параметрах идет список объектов какого-то
класса и через этот список идет заполнение ListBox;
 через параметризованный метод, у которого в
передаваемых параметрах идет объект какого-то класса,
который добавляется в новую строку ListBox (в конец
списка);
 через параметризованный метод, у которого в
передаваемых параметрах идет объект какого-то класса,
номер строки и имя свойства/поля, значение которого
требуется подставить в указанной строке, если этого
свойство/поле там еще не заполнено (если строк меньше,
чем указано, то добавить строки).

Список значений. Список заполняется через метод, передающий объект
 */
namespace VisualComponents1
{
    public partial class ValuesList : UserControl
    {
        public char StartVar;
        public char EndVar;
        public string Template { get; set; }

        private ArrayList Objects { get; set; }
        public ValuesList()
        {
            InitializeComponent();
            //listBox1.ContextMenuStrip = contextMenuStrip1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Установка строки с шаблоном
        /// Вместо { и } указываются свои символы выделения значения
        /// Вместо T и P свойства объекта с учетом регистра.
        /// </summary>
        /// <param name="template">например,«Температура воздуха {T}, давление {P}»</param>
        public void SetTemplate(string template, char startVar, char endVar)
        {
            if (!IsValidTemplate(template, startVar, endVar))
            {
                return;
            }
            StartVar = startVar;
            EndVar = endVar;
            Template = template;
        }

        public int GetSelectedElementIndex()
        {
            return listBox1.SelectedIndex;
        }

        public void FillList(ArrayList items)
        {
            Objects = items;
            listBox1.Items.Clear();
            foreach (object item in items)
            {
                listBox1.Items.Add(fillTemplate(item));
            }
        }

        public object GetOjbectAt(int idx)
        {
            if (idx < 0 || idx > Objects.Count-1)
                return null;

            return Objects[idx];
        }

        public void DeleteAt(int idx)
        {
            Objects.RemoveAt(idx);
        }

        public void DeleteObject(object item)
        {
            Objects.Remove(item);
        }

        private string fillTemplate(object obj)
        {
            if (Template is null)
            {
                return "";
            }

            List<string> varNames = new List<string> { };

            string tmpVariableName = "";
            string status = "findStart";
            foreach (char chr in Template)
            {
                if (chr == StartVar)
                {
                    status = "collectName";
                    continue;
                } else if (chr == EndVar)
                {
                    status = "findStart";
                    varNames.Add(tmpVariableName);
                    tmpVariableName = "";
                }
                if (status == "collectName")
                {
                    tmpVariableName += chr;
                }
            }

            string listItem = Template;
            string fieldName;
            foreach (string variable in varNames)
            {
                string repl = StartVar + variable + EndVar;
                fieldName = variable.Substring(0, 1).ToUpper() + variable.Substring(1, variable.Length - 1);
                FieldInfo field = obj.GetType().GetField(fieldName);
                if (field is null)
                {
                    throw new Exception("given objects have no field named as template variables");
                }
                object val = field.GetValue(obj);
                listItem = listItem.Replace(repl, val.ToString());
            }

            return listItem;
        }

        private bool IsValidTemplate(string template, char startVar, char endVar)
        {
            if (template.Count(f => (f == startVar)) == template.Count(f => (f == endVar)))
            {
                return true;
            }
            return false;
        }

        private void ValuesList_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //contextMenuStrip1.Show();
        }

        private void отчетВWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
