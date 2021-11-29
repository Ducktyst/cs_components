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
 Текстовый визуальный компонент для ввода значения с 
проверкой по шаблону (TextBox). 
Шаблон, по которому будет проверяться вводимое значение, 
должен заполняться через публичное свойство. 
Должна всплывать подсказка (например, ToolTip) 
с примером правильного ввода 
(пример должен заполняться через публичный метод). 

Публичное свойство для установки и получения введенного 
значения (set, get). При получении должна проводиться проверка, 
если введенное значение не соответствует шаблону, выдавать 
ошибку. 

Создать также событие, вызываемое при смене значения.

Поле для ввода даты 
(формат даты должен 
соответствовать 
шаблону)

 */
namespace VisualComponents1
{
    public partial class TemplateInput : UserControl
    {
        private DateTime currentDate;
        public DateTime CurrentDate 
        {
            get { return currentDate; } 
            set { currentDate = value; }
        }

        public string Value 
        { 
            get { return tbDate.Text; } 
            set { tbDate.Text = value; } 
        }

        public string DateExample = "31.12.2021";

        private string DateTemplate = "dd.mm.yyyy";

        public event EventHandler InputChanged;
        public TemplateInput()
        {
            InitializeComponent();
            ttExample.SetToolTip(tbDate, DateTemplate);
            ttExample.ToolTipTitle = DateExample;
        }

        public void OnInputChanged(EventArgs e)
        {
            InputChanged?.Invoke(this, e);
        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {
            string dateStr = tbDate.Text.ToLower();
            if ((dateStr.Length != DateTemplate.Length) || (!DateTemplate.Contains("dd") || !DateTemplate.Contains("mm") || !DateTemplate.Contains("yyyy")))
            {
                 return;
            }
 
            int first = DateTemplate.IndexOf("dd");
            int day = int.Parse(dateStr.Substring(first, 2));

            first = DateTemplate.IndexOf("mm") ;
            int month = int.Parse(dateStr.Substring(first, 2));
            int year = int.Parse(dateStr.Substring(DateTemplate.IndexOf("yyyy"), 4));

            currentDate = new DateTime(year, month, day);

            OnInputChanged(EventArgs.Empty);
        }

        public void SetTemplate(string template)
        {
            int minTemplateLength = 8; int maxTemplateLength = 10;
            if ((DateTemplate.Length < minTemplateLength || DateTemplate.Length > maxTemplateLength) || (!DateTemplate.Contains("dd") || !DateTemplate.Contains("mm") || !DateTemplate.Contains("yyyy")))
            {
                throw new ArgumentException("Формат даты должен состоять из dd, mm, yyyy и разделителя");
            }
            ttExample.SetToolTip(tbDate, template);
            DateTemplate = template;
        }

        public string GetTempate()
        {
            return DateTemplate;
        }

        public void SetToolTipTitle(string toolTipTitle)
        {
            ttExample.ToolTipTitle = toolTipTitle;
        }
        public string GetToolTipTitle()
        {
            return ttExample.ToolTipTitle;
        }
    }
}
