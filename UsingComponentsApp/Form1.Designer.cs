
namespace UsingComponentsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fillParagraphsExcel = new System.Windows.Forms.Button();
            this.choiceVisualComponent1 = new VisualComponents1.ChoiceVisualComponent();
            this.inputLock1 = new VisualComponents1.InputLock();
            this.lblHeader = new System.Windows.Forms.Label();
            this.templateInput = new VisualComponents1.TemplateInput();
            this.rangeInput1 = new VisualComponents1.RangeInput();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenLibrary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fillParagraphsExcel
            // 
            this.fillParagraphsExcel.Location = new System.Drawing.Point(370, 169);
            this.fillParagraphsExcel.Name = "fillParagraphsExcel";
            this.fillParagraphsExcel.Size = new System.Drawing.Size(154, 38);
            this.fillParagraphsExcel.TabIndex = 0;
            this.fillParagraphsExcel.Text = "Создать эксель";
            this.fillParagraphsExcel.UseVisualStyleBackColor = true;
            this.fillParagraphsExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // choiceVisualComponent1
            // 
            this.choiceVisualComponent1.Location = new System.Drawing.Point(345, 20);
            this.choiceVisualComponent1.Name = "choiceVisualComponent1";
            this.choiceVisualComponent1.NewProp = 0;
            this.choiceVisualComponent1.Size = new System.Drawing.Size(244, 47);
            this.choiceVisualComponent1.TabIndex = 1;
            // 
            // inputLock1
            // 
            this.inputLock1.Location = new System.Drawing.Point(10, 20);
            this.inputLock1.Name = "inputLock1";
            this.inputLock1.SavedValue = null;
            this.inputLock1.Size = new System.Drawing.Size(179, 90);
            this.inputLock1.TabIndex = 2;
            this.inputLock1.Load += new System.EventHandler(this.inputLock1_Load);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(13, 5);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(110, 13);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Ввод с блокировкой";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // templateInput
            // 
            this.templateInput.CurrentDate = new System.DateTime(((long)(0)));
            this.templateInput.Location = new System.Drawing.Point(12, 116);
            this.templateInput.Name = "templateInput";
            this.templateInput.Size = new System.Drawing.Size(159, 73);
            this.templateInput.TabIndex = 4;
            this.templateInput.Value = "";
            // 
            // rangeInput1
            // 
            this.rangeInput1.Location = new System.Drawing.Point(17, 218);
            this.rangeInput1.MaxLength = 100;
            this.rangeInput1.MinLength = 0;
            this.rangeInput1.Name = "rangeInput1";
            this.rangeInput1.Size = new System.Drawing.Size(172, 201);
            this.rangeInput1.TabIndex = 5;
            this.rangeInput1.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ввод даты по шаблону";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ввод по диапазону";
            // 
            // btnOpenLibrary
            // 
            this.btnOpenLibrary.Location = new System.Drawing.Point(472, 354);
            this.btnOpenLibrary.Name = "btnOpenLibrary";
            this.btnOpenLibrary.Size = new System.Drawing.Size(202, 65);
            this.btnOpenLibrary.TabIndex = 8;
            this.btnOpenLibrary.Text = "Открыть библиотеку";
            this.btnOpenLibrary.UseVisualStyleBackColor = true;
            this.btnOpenLibrary.Click += new System.EventHandler(this.btnOpenLibrary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 431);
            this.Controls.Add(this.btnOpenLibrary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rangeInput1);
            this.Controls.Add(this.templateInput);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.inputLock1);
            this.Controls.Add(this.choiceVisualComponent1);
            this.Controls.Add(this.fillParagraphsExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fillParagraphsExcel;
        private VisualComponents1.ChoiceVisualComponent choiceVisualComponent1;
        private VisualComponents1.InputLock inputLock1;
        private System.Windows.Forms.Label lblHeader;
        private VisualComponents1.TemplateInput templateInput;
        private VisualComponents1.RangeInput rangeInput1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenLibrary;
    }
}

