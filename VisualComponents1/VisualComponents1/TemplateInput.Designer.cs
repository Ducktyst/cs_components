
namespace VisualComponents1
{
    partial class TemplateInput
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
            this.components = new System.ComponentModel.Container();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.ttExample = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(0, 3);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(148, 20);
            this.tbDate.TabIndex = 0;
            this.tbDate.TextChanged += new System.EventHandler(this.tbDate_TextChanged);
            // 
            // ttExample
            // 
            this.ttExample.ToolTipTitle = "Ввод по шаблону даты";
            // 
            // TemplateInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbDate);
            this.Name = "TemplateInput";
            this.Size = new System.Drawing.Size(156, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.ToolTip ttExample;
    }
}
