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
    public partial class AddBookForm : Form
    {
        private Book _book;
        public Book Book {
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

            tbBookID.Text = _book.Id.ToString();
            tbBookName.Text =  _book.Name;
            tbBookDescr.Text = _book.Description;

            //cbGenre.Items.AddRange(genres);

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
                // todo: edit book fields
                // return new book
                // replace book in the library
            } else
            {
                _book = new Book(
                    -1,
                    tbBookName.Text,
                    tbBookDescr.Text,
                    cbGenre.Text,
                    Decimal.ToInt32(cbPrice.Value)
                    );
            }
        }
    }
}
