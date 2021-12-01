using AnyDiff;
using AnyDiff.Extensions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UsingComponentsApp
{
    public partial class BookForm : Form
    {

        private Book _initBook;
        private Book _book;
        public Book Book
        {
            get { return _book; }
            set { FillFields(value); }
        }

        private object[] genres = new string[]
        {
                "Фентези",
                "Детективы",
                "История",
                "Компьютерная литература",
        };
        public BookForm()
        {
            InitializeComponent();
            cbGenre.Items.AddRange(genres);
        }

        public void FillFields(Book book)
        {
            _initBook = new Book(book);
            _book = book;

            tbBookID.Text = _book.Id.ToString(); // _book.Id - 1 ???
            tbBookName.Text = _book.Name;
            tbBookDescr.Text = _book.Description;

            cbGenre.Text = _book.Genre;

            cbPrice.Value = _book.Price;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbBookGenre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBookPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbError_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (_book != null)
            {
                // edit book in the library
                _book.Name = tbBookName.Text;
                _book.Description = tbBookDescr.Text;
                _book.Genre = cbGenre.Text;
                _book.Price = Decimal.ToInt32(cbPrice.Value);
            }
            else
            {
                _book = new Book(
                    -1,
                    tbBookName.Text,
                    tbBookDescr.Text,
                    cbGenre.Text,
                    Decimal.ToInt32(cbPrice.Value)
                    );
            }
            LibraryForm parentForm = (LibraryForm)this.Owner;
            if (parentForm != null)
            {
                parentForm.Redraw();
            }
            Close();
        }

        private ICollection<Difference> findChanges()
        {
            return _initBook.Diff(_book, ComparisonOptions.All | ComparisonOptions.IncludeList, x => x.Name, x => x.Description, x => x.Genre, x => x.Price);
        }

        private void BookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы собираетесь закрыть форму редактирования книги. Подтвердить?", "Прекратить редактирование", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RevertChanges();
            }
            else
            {
                e.Cancel = true;
                this.Activate();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ICollection<Difference> diff = findChanges();

            string result = "";
            foreach (var difference in diff)
            {
                result += $"Было: `{difference.LeftValue}`. Стало: `{difference.RightValue}`\n";
            }
                
            MessageBox.Show($"diffs: \n {result}");
            this.Close();
        }

        private void RevertChanges()
        {
            _book.Name = _initBook.Name;
            _book.Description= _initBook.Description;
            _book.Genre = _initBook.Genre;
            _book.Price = _initBook.Price;
        }
    }
}
