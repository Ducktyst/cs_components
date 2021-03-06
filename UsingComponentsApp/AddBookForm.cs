using System;
using System.Windows.Forms;

namespace UsingComponentsApp
{
    public partial class AddBookForm : Form
    {
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
        public AddBookForm()
        {
            InitializeComponent();
            cbGenre.Items.AddRange(genres);
        }

        public void FillFields(Book book)
        {
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
    }
}
