
namespace VisualComponents1
{
    partial class InputLock
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.checkBoxLock = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(3, 29);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(170, 20);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBoxLock
            // 
            this.checkBoxLock.AutoSize = true;
            this.checkBoxLock.Location = new System.Drawing.Point(3, 6);
            this.checkBoxLock.Name = "checkBoxLock";
            this.checkBoxLock.Size = new System.Drawing.Size(104, 17);
            this.checkBoxLock.TabIndex = 1;
            this.checkBoxLock.Text = "Заблокировать";
            this.checkBoxLock.UseVisualStyleBackColor = true;
            this.checkBoxLock.CheckedChanged += new System.EventHandler(this.checkBoxLock_CheckedChanged);
            // 
            // InputLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxLock);
            this.Controls.Add(this.textBox);
            this.Name = "InputLock";
            this.Size = new System.Drawing.Size(179, 51);
            this.Load += new System.EventHandler(this.InputLock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox checkBoxLock;
    }
}
