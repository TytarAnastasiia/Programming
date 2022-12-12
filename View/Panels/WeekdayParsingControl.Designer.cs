namespace Programming.View.Panels
{
    partial class WeekdayParsingControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.label_typeValue = new System.Windows.Forms.Label();
            this.button_ParseDay = new System.Windows.Forms.Button();
            this.textBox_ParsingResult = new System.Windows.Forms.TextBox();
            this.textBox_EnteredDay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 226);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WeekdayParsingGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 222);
            this.panel1.TabIndex = 0;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.label_typeValue);
            this.WeekdayParsingGroupBox.Controls.Add(this.button_ParseDay);
            this.WeekdayParsingGroupBox.Controls.Add(this.textBox_ParsingResult);
            this.WeekdayParsingGroupBox.Controls.Add(this.textBox_EnteredDay);
            this.WeekdayParsingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(391, 222);
            this.WeekdayParsingGroupBox.TabIndex = 0;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // label_typeValue
            // 
            this.label_typeValue.AutoSize = true;
            this.label_typeValue.Location = new System.Drawing.Point(39, 78);
            this.label_typeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_typeValue.Name = "label_typeValue";
            this.label_typeValue.Size = new System.Drawing.Size(115, 13);
            this.label_typeValue.TabIndex = 17;
            this.label_typeValue.Text = "Type value for parsing:";
            // 
            // button_ParseDay
            // 
            this.button_ParseDay.Location = new System.Drawing.Point(259, 93);
            this.button_ParseDay.Margin = new System.Windows.Forms.Padding(2);
            this.button_ParseDay.Name = "button_ParseDay";
            this.button_ParseDay.Size = new System.Drawing.Size(53, 20);
            this.button_ParseDay.TabIndex = 16;
            this.button_ParseDay.Text = "Parse";
            this.button_ParseDay.UseVisualStyleBackColor = true;
            // 
            // textBox_ParsingResult
            // 
            this.textBox_ParsingResult.Location = new System.Drawing.Point(42, 117);
            this.textBox_ParsingResult.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ParsingResult.Name = "textBox_ParsingResult";
            this.textBox_ParsingResult.ReadOnly = true;
            this.textBox_ParsingResult.Size = new System.Drawing.Size(213, 20);
            this.textBox_ParsingResult.TabIndex = 15;
            // 
            // textBox_EnteredDay
            // 
            this.textBox_EnteredDay.Location = new System.Drawing.Point(42, 93);
            this.textBox_EnteredDay.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EnteredDay.Name = "textBox_EnteredDay";
            this.textBox_EnteredDay.Size = new System.Drawing.Size(213, 20);
            this.textBox_EnteredDay.TabIndex = 14;
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(395, 226);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Label label_typeValue;
        private System.Windows.Forms.Button button_ParseDay;
        private System.Windows.Forms.TextBox textBox_ParsingResult;
        private System.Windows.Forms.TextBox textBox_EnteredDay;
    }
}
