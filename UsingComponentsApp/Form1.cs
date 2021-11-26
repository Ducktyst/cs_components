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

namespace UsingComponentsApp
{
    public partial class Form1 : Form
    {
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
    }
}
