using ExcelTool;
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
 Учет книг в библиотеке. 
По книге хранить следующую информацию:
название, описание, жанр (выпадающий список), стоимость (может
быть бесплатной). 

Выводить в виде дерева (жанр - стоимость - идентификатор - название).

Формировать документ в Excel по
бесплатным книгам (в каждой строке текст с информацией: название
книги и ее описание). 

Формировать отчет в Word с информацией по
всем книгам (шапка: первые столбец и строка).
По столбцу идет заполнение значениями идентификаторов книг. 
В первой строке остальные заголовки: название, жанр, стоимость (если пусто, то
строчкой писать «бесплатная»). 

Круговая диаграмма в Pdf, сколько
бесплатных книг какого жанра.

*/
namespace UsingComponentsApp
{
    public partial class Form1 : Form
    {
        LibraryForm libForm;
        public Form1()
        {
            InitializeComponent();
            templateInput.SetToolTipTitle("31.12.2021");
            templateInput.SetTemplate("dd.mm.yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] paragraphs = new string[]{ "p1", "p2"};
            //BigDocument.Fill("data.xlsx", "header", paragraphs);
            fillParagraphsExcel.Enabled = false;
            BigDocument.CreateSpreadsheetWorkbook("data.xlsx", "header", paragraphs);
            MessageBox.Show("Created data.xlsx");
        }

        private void inputLock1_Load(object sender, EventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenLibrary_Click(object sender, EventArgs e)
        {
            if (libForm is null || libForm.IsDisposed) 
                libForm = new LibraryForm();

            if (libForm.Visible)
                return;

            libForm.Activate();
            libForm.Show(this);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Form1 Keydown");
        }
    }
}
