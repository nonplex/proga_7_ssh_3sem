namespace proga_7_ssh_3sem
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.xEdit = new System.Windows.Forms.TextBox();
            this.formula1Radio = new System.Windows.Forms.RadioButton();
            this.formula2Radio = new System.Windows.Forms.RadioButton();
            this.formula3Radio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.doubleResultCheck2 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите x: ";
            // 
            // xEdit
            // 
            this.xEdit.Location = new System.Drawing.Point(130, 3);
            this.xEdit.Name = "xEdit";
            this.xEdit.Size = new System.Drawing.Size(139, 20);
            this.xEdit.TabIndex = 1;
            this.xEdit.TextChanged += new System.EventHandler(this.xEdit_TextChanged);
            // 
            // formula1Radio
            // 
            this.formula1Radio.AutoSize = true;
            this.formula1Radio.Location = new System.Drawing.Point(130, 29);
            this.formula1Radio.Name = "formula1Radio";
            this.formula1Radio.Size = new System.Drawing.Size(117, 17);
            this.formula1Radio.TabIndex = 2;
            this.formula1Radio.TabStop = true;
            this.formula1Radio.Text = "y =[cos(x)]^2,  x<=0";
            this.formula1Radio.UseVisualStyleBackColor = true;
            this.formula1Radio.CheckedChanged += new System.EventHandler(this.formula1Radio_CheckedChanged);
            // 
            // formula2Radio
            // 
            this.formula2Radio.AutoSize = true;
            this.formula2Radio.Location = new System.Drawing.Point(3, 29);
            this.formula2Radio.Name = "formula2Radio";
            this.formula2Radio.Size = new System.Drawing.Size(121, 17);
            this.formula2Radio.TabIndex = 3;
            this.formula2Radio.TabStop = true;
            this.formula2Radio.Text = "y= 2x^3-2,      0<x<1";
            this.formula2Radio.UseVisualStyleBackColor = true;
            this.formula2Radio.CheckedChanged += new System.EventHandler(this.formula2Radio_CheckedChanged);
            // 
            // formula3Radio
            // 
            this.formula3Radio.AutoSize = true;
            this.formula3Radio.Location = new System.Drawing.Point(275, 29);
            this.formula3Radio.Name = "formula3Radio";
            this.formula3Radio.Size = new System.Drawing.Size(129, 17);
            this.formula3Radio.TabIndex = 4;
            this.formula3Radio.TabStop = true;
            this.formula3Radio.Text = "y =(x+1)*(sqrt(x)), x>=1";
            this.formula3Radio.UseVisualStyleBackColor = true;
            this.formula3Radio.CheckedChanged += new System.EventHandler(this.formula3Radio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Получившийся y:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(130, 78);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(130, 52);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Посчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click_1);
            // 
            // doubleResultCheck2
            // 
            this.doubleResultCheck2.AutoSize = true;
            this.doubleResultCheck2.Location = new System.Drawing.Point(3, 52);
            this.doubleResultCheck2.Name = "doubleResultCheck2";
            this.doubleResultCheck2.Size = new System.Drawing.Size(76, 17);
            this.doubleResultCheck2.TabIndex = 9;
            this.doubleResultCheck2.Text = "Удвоение";
            this.doubleResultCheck2.UseVisualStyleBackColor = true;
            this.doubleResultCheck2.CheckedChanged += new System.EventHandler(this.doubleResultCheck2_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.xEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.formula2Radio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.formula1Radio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.formula3Radio, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.doubleResultCheck2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.calculateButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(233, 161);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 100);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xEdit;
        private System.Windows.Forms.RadioButton formula1Radio;
        private System.Windows.Forms.RadioButton formula2Radio;
        private System.Windows.Forms.RadioButton formula3Radio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.CheckBox doubleResultCheck2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

