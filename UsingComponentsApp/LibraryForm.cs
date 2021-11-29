using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingComponentsApp
{
    public partial class LibraryForm : Form
    {
        Library library;
        public LibraryForm()
        {
            InitializeComponent();
            Book[] books = new Book[] 
            { 
                new Book(1, "Гарри Поттер и философский камень", "Описание", "Жанр", 700),
                new Book(2, "Возвращение короля", "Джон Рональд Руэл Толкин", "Фентези", 500),
                new Book(3, "Слепень (повести) - Иван Любенко", "…Зимой 1909 года Ставрополю был объявлен ультиматум.", "Детективы", 0),
                new Book(4, "Государь (сборник) - Никколо Макиавелли", "«Цель оправдывает средства» – таков, по Макиавелли, девиз всякой сильной власти.", "История", 600),
                new Book(5, "Изучаем PostgreSQL 10", "Второе издание", "Компьютерная литература", 1200),
                new Book(6, "Мелкие боги", "Терри Пратчетт", "Фентези", 0),
                new Book(7, "Тёмная сторона - Макс Фрай", "5 звезд", "Фентези", 0),
                new Book(8, "Ведьмак. Крещение огнем", "Сапковский Андрей, 1996 год", "Фентези", 0),
            };

            library = new Library(books);

            library.CreatePdfFreeBookByGenreDiagram();
            library.CreateExcelFreeBookReport();

            valuesList.SetTemplate("Книга: {Name}. Жанр: {Genre}. Цена: {Price}" ,  '{', '}');
            valuesList.FillList(books);

            valuesList.ContextMenuStrip = contextMenuStrip1;
            //controlDataTableTable1.AddTable(library.BooksList());
        }

        private void createWordReport_Click(object sender, EventArgs e)
        {
            if (library == null)
            {
                return;
            }

            library.CreateWordDetailInfoDocument("library_books.docx");
        }

        private void valuesList_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (library == null)
            {
                return;
            }

            string filePath;
            saveFileDialog1.Filter = "MS Word(*.docx)|*.docx|All files(*.*)|*.*";
            saveFileDialog1.DefaultExt = "docx";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.FileName = "библиотека.docx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
                library.CreateWordDetailInfoDocument(filePath);
                MessageBox.Show("Файл сохранен");
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
