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
        LibraryGridForm libGridForm;
        public LibraryForm()
        {
            InitializeComponent();
            Book[] books = new Book[] 
            { 
                new Book(1, "Гарри Поттер и философский камень", "Описание", "Фентези", 700),
                new Book(2, "Возвращение короля", "Джон Рональд Руэл Толкин", "Фентези", 500),
                new Book(3, "Слепень (повести) - Иван Любенко", "…Зимой 1909 года Ставрополю был объявлен ультиматум.", "Детективы", 0),
                new Book(4, "Государь (сборник) - Никколо Макиавелли", "«Цель оправдывает средства» – таков, по Макиавелли, девиз всякой сильной власти.", "История", 600),
                new Book(5, "Изучаем PostgreSQL 10", "Второе издание", "Компьютерная литература", 1200),
                new Book(6, "Мелкие боги", "Терри Пратчетт", "Фентези", 0),
                new Book(7, "Тёмная сторона - Макс Фрай", "5 звезд", "Фентези", 0),
                new Book(8, "Ведьмак. Крещение огнем", "Сапковский Андрей, 1996 год", "Фентези", 0),
            };

            library = new Library(books);

            valuesList.ContextMenuStrip = contextMenuStrip1;

            Redraw();

            //controlDataTableTable1.AddTable(library.BooksList());
        }
        public void Redraw()
        {
            valuesList.SetTemplate("Книга: {Name}. Жанр: {Genre}. Цена: {Price}", '{', '}');
            valuesList.FillList(library.Books);
        }
        private void createWordReport_Click(object sender, EventArgs e)
        {
            if (library == null)
            {
                return;
            }

            library.CreateWordDetailInfoDocument("library_books.docx");
        }

        private void createExcelReport_Click(object sender, EventArgs e)
        {
            if (library == null)
            {
                return;
            }

            library.CreateExcelFreeBookReport("library_books.xlsx");
        }

        private void createPdfReport_Click(object sender, EventArgs e)
        {
            if (library == null)
            {
                return;
            }

            library.CreatePdfFreeBookByGenreDiagram("library_books_diagram.pdf");
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

        private void LibraryForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.A)
            {
                добавитьToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.U)
            {
                изменитьToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.D)
            {
                удалитьToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.S)
            {
                wordToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.T)
            {
                excelToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.C)
            {
                бесплатныеКнигиПоЖанрамВPDFToolStripMenuItem.PerformClick();
            }
        }

        private void openGrid_Click(object sender, EventArgs e)
        {
            if (libGridForm == null)
            {
                libGridForm = new LibraryGridForm();
            }
            if (libGridForm.Visible)
            {
                return;
            }
            libGridForm.Show(this);
            libGridForm.Activate();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm form = new BookForm();
            form.Show(this);
            form.Activate();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idxList = valuesList.GetSelectedElementIndex();
            if (idxList != -1 )
            {
                BookForm bookForm = new BookForm();

                bookForm.FillFields(library.Books[idxList]);
                bookForm.Activate();

                bookForm.Show(this);
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
