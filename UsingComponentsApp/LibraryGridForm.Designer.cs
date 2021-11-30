
namespace UsingComponentsApp
{
    partial class LibraryGridForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlDataTableTable1 = new WindowsFormsControlLibrary.Data.ControlDataTableTable();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.description,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(43, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 180);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // description
            // 
            this.description.HeaderText = "Описание";
            this.description.Name = "description";
            this.description.Width = 200;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.Width = 120;
            // 
            // controlDataTableTable1
            // 
            this.controlDataTableTable1.Location = new System.Drawing.Point(43, 23);
            this.controlDataTableTable1.Name = "controlDataTableTable1";
            this.controlDataTableTable1.SelectedRowIndex = -1;
            this.controlDataTableTable1.Size = new System.Drawing.Size(566, 150);
            this.controlDataTableTable1.TabIndex = 2;
            this.controlDataTableTable1.Load += new System.EventHandler(this.controlDataTableTable1_Load);
            // 
            // LibraryGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlDataTableTable1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LibraryGridForm";
            this.Text = "Библиотека - Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private WindowsFormsControlLibrary.Data.ControlDataTableTable controlDataTableTable1;
    }
}