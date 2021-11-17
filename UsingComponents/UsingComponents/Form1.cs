using DocumenLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualComponents1;

namespace UsingComponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] paragraphs = new string[]{ "p1", "p2"};
            //BigDocument.Fill("data.xlsx", "header", paragraphs);
            button1.Enabled = false;
            BigDocument.CreateSpreadsheetWorkbook("data.xlsx", "header", paragraphs);
            MessageBox.Show("Created data.xlsx");
        }
    }
}
