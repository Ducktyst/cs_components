
namespace UsingComponentsApp
{
    partial class LibraryForm
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
            this.components = new System.ComponentModel.Container();
            this.controlDataTableTable1 = new WindowsFormsControlLibrary.Data.ControlDataTableTable();
            this.controlDataTableRow1 = new WindowsFormsControlLibrary.Data.ControlDataTableRow();
            this.controlDataListCell1 = new WindowsFormsControlLibrary.Data.ControlDataListCell();
            this.controlDataList1 = new WindowsFormsControlLibrary.Core.ControlDataList();
            this.createWordReport = new System.Windows.Forms.Button();
            this.valuesList = new VisualComponents1.ValuesList();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бесплатныеКнигиПоЖанрамВPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlDataTableTable1
            // 
            this.controlDataTableTable1.Location = new System.Drawing.Point(344, 188);
            this.controlDataTableTable1.Name = "controlDataTableTable1";
            this.controlDataTableTable1.SelectedRowIndex = -1;
            this.controlDataTableTable1.Size = new System.Drawing.Size(384, 123);
            this.controlDataTableTable1.TabIndex = 1;
            // 
            // controlDataTableRow1
            // 
            this.controlDataTableRow1.Location = new System.Drawing.Point(22, 292);
            this.controlDataTableRow1.Name = "controlDataTableRow1";
            this.controlDataTableRow1.SelectedRowIndex = -1;
            this.controlDataTableRow1.Size = new System.Drawing.Size(150, 150);
            this.controlDataTableRow1.TabIndex = 2;
            // 
            // controlDataListCell1
            // 
            this.controlDataListCell1.Location = new System.Drawing.Point(178, 292);
            this.controlDataListCell1.Name = "controlDataListCell1";
            this.controlDataListCell1.SelectedRowIndex = -1;
            this.controlDataListCell1.Size = new System.Drawing.Size(150, 150);
            this.controlDataListCell1.TabIndex = 3;
            // 
            // controlDataList1
            // 
            this.controlDataList1.Location = new System.Drawing.Point(551, 25);
            this.controlDataList1.Name = "controlDataList1";
            this.controlDataList1.SelectedRowIndex = -1;
            this.controlDataList1.Size = new System.Drawing.Size(150, 150);
            this.controlDataList1.TabIndex = 4;
            // 
            // createWordReport
            // 
            this.createWordReport.Location = new System.Drawing.Point(536, 317);
            this.createWordReport.Name = "createWordReport";
            this.createWordReport.Size = new System.Drawing.Size(165, 37);
            this.createWordReport.TabIndex = 5;
            this.createWordReport.Text = "Создать отчет Word";
            this.createWordReport.UseVisualStyleBackColor = true;
            this.createWordReport.Click += new System.EventHandler(this.createWordReport_Click);
            // 
            // valuesList
            // 
            this.valuesList.Location = new System.Drawing.Point(12, 12);
            this.valuesList.Name = "valuesList";
            this.valuesList.Size = new System.Drawing.Size(505, 274);
            this.valuesList.TabIndex = 6;
            this.valuesList.Template = null;
            this.valuesList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.valuesList_MouseClick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // документToolStripMenuItem
            // 
            this.документToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.бесплатныеКнигиПоЖанрамВPDFToolStripMenuItem});
            this.документToolStripMenuItem.Name = "документToolStripMenuItem";
            this.документToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.документToolStripMenuItem.Text = "Документ";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // бесплатныеКнигиПоЖанрамВPDFToolStripMenuItem
            // 
            this.бесплатныеКнигиПоЖанрамВPDFToolStripMenuItem.Name = "бесплатныеКнигиПоЖанрамВPDFToolStripMenuItem";
            this.бесплатныеКнигиПоЖанрамВPDFToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.бесплатныеКнигиПоЖанрамВPDFToolStripMenuItem.Text = "Бесплатные книги по жанрам в PDF";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.документToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valuesList);
            this.Controls.Add(this.createWordReport);
            this.Controls.Add(this.controlDataList1);
            this.Controls.Add(this.controlDataListCell1);
            this.Controls.Add(this.controlDataTableRow1);
            this.Controls.Add(this.controlDataTableTable1);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private WindowsFormsControlLibrary.Data.ControlDataTableTable controlDataTableTable1;
        private WindowsFormsControlLibrary.Data.ControlDataTableRow controlDataTableRow1;
        private WindowsFormsControlLibrary.Data.ControlDataListCell controlDataListCell1;
        private WindowsFormsControlLibrary.Core.ControlDataList controlDataList1;
        private System.Windows.Forms.Button createWordReport;
        private VisualComponents1.ValuesList valuesList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бесплатныеКнигиПоЖанрамВPDFToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}