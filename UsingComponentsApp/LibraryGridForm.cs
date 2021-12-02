using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary.Core;
using WindowsFormsControlLibrary.Data;
using WindowsFormsControlLibrary.Models;

namespace UsingComponentsApp
{
    public partial class LibraryGridForm : Form
    {
        public LibraryGridForm()
        {
            InitializeComponent();

            ControlDataTable controlDataTable = new ControlDataTable();
            DataTableColumnConfig dataTableColumnConfigId = new DataTableColumnConfig();
            dataTableColumnConfigId.ColumnHeader = "Id";

            List<DataTableColumnConfig> columns = new List<DataTableColumnConfig>
            {
                dataTableColumnConfigId
            };
            controlDataTable.LoadColumns(columns);

            controlDataTable.Location = new System.Drawing.Point(43, 23);
            controlDataTable.Size = new System.Drawing.Size(566, 100);
            controlDataTable.Visible = true;
            controlDataTable.Show();

            List<string> values = new List<string> {
                "1", "2"
            };

            controlDataTableTable1.LoadColumns(columns);
            controlDataTableTable1.AddTable(values);

        }

        private void controlDataTable1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void controlDataTableTable1_Load(object sender, EventArgs e)
        {

        }
    }
}
