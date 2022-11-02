namespace Programming.View.Panels
{
    partial class EnumerationsControl
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
            this.label_intValue = new System.Windows.Forms.Label();
            this.label_chooseValue = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.label_Enums = new System.Windows.Forms.Label();
            this.textBox_SelectedValue = new System.Windows.Forms.TextBox();
            this.label_enumeration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_intValue
            // 
            this.label_intValue.AutoSize = true;
            this.label_intValue.Location = new System.Drawing.Point(544, 170);
            this.label_intValue.Name = "label_intValue";
            this.label_intValue.Size = new System.Drawing.Size(73, 20);
            this.label_intValue.TabIndex = 11;
            this.label_intValue.Text = "Int value:";
            // 
            // label_chooseValue
            // 
            this.label_chooseValue.AutoSize = true;
            this.label_chooseValue.Location = new System.Drawing.Point(281, 103);
            this.label_chooseValue.Name = "label_chooseValue";
            this.label_chooseValue.Size = new System.Drawing.Size(105, 20);
            this.label_chooseValue.TabIndex = 10;
            this.label_chooseValue.Text = "Choose value";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(75, 126);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(155, 204);
            this.EnumsListBox.TabIndex = 6;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(285, 126);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(155, 204);
            this.ValuesListBox.TabIndex = 7;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // label_Enums
            // 
            this.label_Enums.AutoSize = true;
            this.label_Enums.Location = new System.Drawing.Point(71, 103);
            this.label_Enums.Name = "label_Enums";
            this.label_Enums.Size = new System.Drawing.Size(159, 20);
            this.label_Enums.TabIndex = 9;
            this.label_Enums.Text = "Choose Enumeration";
            // 
            // textBox_SelectedValue
            // 
            this.textBox_SelectedValue.Location = new System.Drawing.Point(548, 193);
            this.textBox_SelectedValue.Name = "textBox_SelectedValue";
            this.textBox_SelectedValue.ReadOnly = true;
            this.textBox_SelectedValue.Size = new System.Drawing.Size(100, 26);
            this.textBox_SelectedValue.TabIndex = 8;
            // 
            // label_enumeration
            // 
            this.label_enumeration.AutoSize = true;
            this.label_enumeration.Location = new System.Drawing.Point(4, 4);
            this.label_enumeration.Name = "label_enumeration";
            this.label_enumeration.Size = new System.Drawing.Size(100, 20);
            this.label_enumeration.TabIndex = 12;
            this.label_enumeration.Text = "Enumeration";
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_enumeration);
            this.Controls.Add(this.label_intValue);
            this.Controls.Add(this.label_chooseValue);
            this.Controls.Add(this.EnumsListBox);
            this.Controls.Add(this.ValuesListBox);
            this.Controls.Add(this.label_Enums);
            this.Controls.Add(this.textBox_SelectedValue);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(768, 459);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_intValue;
        private System.Windows.Forms.Label label_chooseValue;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label label_Enums;
        private System.Windows.Forms.TextBox textBox_SelectedValue;
        private System.Windows.Forms.Label label_enumeration;
    }
}
