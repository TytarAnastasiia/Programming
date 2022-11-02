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
            this.label_typeValue = new System.Windows.Forms.Label();
            this.button_ParseDay = new System.Windows.Forms.Button();
            this.textBox_ParsingResult = new System.Windows.Forms.TextBox();
            this.textBox_EnteredDay = new System.Windows.Forms.TextBox();
            this.label_weekdayParsing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_typeValue
            // 
            this.label_typeValue.AutoSize = true;
            this.label_typeValue.Location = new System.Drawing.Point(62, 88);
            this.label_typeValue.Name = "label_typeValue";
            this.label_typeValue.Size = new System.Drawing.Size(167, 20);
            this.label_typeValue.TabIndex = 7;
            this.label_typeValue.Text = "Type value for parsing:";
            // 
            // button_ParseDay
            // 
            this.button_ParseDay.Location = new System.Drawing.Point(378, 131);
            this.button_ParseDay.Name = "button_ParseDay";
            this.button_ParseDay.Size = new System.Drawing.Size(79, 36);
            this.button_ParseDay.TabIndex = 6;
            this.button_ParseDay.Text = "Parse";
            this.button_ParseDay.UseVisualStyleBackColor = true;
            this.button_ParseDay.Click += new System.EventHandler(this.button_ParseDay_Click);
            // 
            // textBox_ParsingResult
            // 
            this.textBox_ParsingResult.Location = new System.Drawing.Point(66, 168);
            this.textBox_ParsingResult.Name = "textBox_ParsingResult";
            this.textBox_ParsingResult.ReadOnly = true;
            this.textBox_ParsingResult.Size = new System.Drawing.Size(286, 26);
            this.textBox_ParsingResult.TabIndex = 5;
            // 
            // textBox_EnteredDay
            // 
            this.textBox_EnteredDay.Location = new System.Drawing.Point(66, 111);
            this.textBox_EnteredDay.Name = "textBox_EnteredDay";
            this.textBox_EnteredDay.Size = new System.Drawing.Size(286, 26);
            this.textBox_EnteredDay.TabIndex = 4;
            // 
            // label_weekdayParsing
            // 
            this.label_weekdayParsing.AutoSize = true;
            this.label_weekdayParsing.Location = new System.Drawing.Point(4, 4);
            this.label_weekdayParsing.Name = "label_weekdayParsing";
            this.label_weekdayParsing.Size = new System.Drawing.Size(132, 20);
            this.label_weekdayParsing.TabIndex = 8;
            this.label_weekdayParsing.Text = "Weekday Parsing";
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_weekdayParsing);
            this.Controls.Add(this.label_typeValue);
            this.Controls.Add(this.button_ParseDay);
            this.Controls.Add(this.textBox_ParsingResult);
            this.Controls.Add(this.textBox_EnteredDay);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(547, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_typeValue;
        private System.Windows.Forms.Button button_ParseDay;
        private System.Windows.Forms.TextBox textBox_ParsingResult;
        private System.Windows.Forms.TextBox textBox_EnteredDay;
        private System.Windows.Forms.Label label_weekdayParsing;
    }
}
