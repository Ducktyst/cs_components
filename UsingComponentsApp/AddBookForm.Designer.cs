
namespace UsingComponentsApp
{
    partial class AddBookForm
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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.tbBookDescr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.cbPrice = new System.Windows.Forms.NumericUpDown();
            this.tbError = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(143, 350);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Принять";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(127, 84);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.ReadOnly = true;
            this.tbBookID.Size = new System.Drawing.Size(255, 20);
            this.tbBookID.TabIndex = 2;
            this.tbBookID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(127, 133);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(255, 20);
            this.tbBookName.TabIndex = 3;
            // 
            // tbBookDescr
            // 
            this.tbBookDescr.Location = new System.Drawing.Point(127, 178);
            this.tbBookDescr.Multiline = true;
            this.tbBookDescr.Name = "tbBookDescr";
            this.tbBookDescr.Size = new System.Drawing.Size(255, 44);
            this.tbBookDescr.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Жанр";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Цена";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(127, 249);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(255, 21);
            this.cbGenre.TabIndex = 12;
            // 
            // cbPrice
            // 
            this.cbPrice.Location = new System.Drawing.Point(127, 300);
            this.cbPrice.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(255, 20);
            this.cbPrice.TabIndex = 13;
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(127, 379);
            this.tbError.Name = "tbError";
            this.tbError.ReadOnly = true;
            this.tbError.Size = new System.Drawing.Size(255, 20);
            this.tbError.TabIndex = 14;
            this.tbError.Text = "Ошибка: <...>";
            this.tbError.TextChanged += new System.EventHandler(this.tbError_TextChanged);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.cbPrice);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBookDescr);
            this.Controls.Add(this.tbBookName);
            this.Controls.Add(this.tbBookID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Name = "AddBookForm";
            this.Text = "Книга ";
            ((System.ComponentModel.ISupportInitialize)(this.cbPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.TextBox tbBookDescr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.NumericUpDown cbPrice;
        private System.Windows.Forms.TextBox tbError;
    }
}