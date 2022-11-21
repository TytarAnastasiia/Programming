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
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.SelectedValueTextBox = new System.Windows.Forms.TextBox();
            this.EnumerationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(363, 110);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(51, 13);
            this.IntValueLabel.TabIndex = 11;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(187, 67);
            this.ChooseValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ChooseValueLabel.TabIndex = 10;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(50, 82);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(105, 134);
            this.EnumsListBox.TabIndex = 6;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(190, 82);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(105, 134);
            this.ValuesListBox.TabIndex = 7;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(47, 67);
            this.EnumsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(108, 13);
            this.EnumsLabel.TabIndex = 9;
            this.EnumsLabel.Text = "Choose Enumeration:";
            // 
            // SelectedValueTextBox
            // 
            this.SelectedValueTextBox.Location = new System.Drawing.Point(365, 125);
            this.SelectedValueTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectedValueTextBox.Name = "SelectedValueTextBox";
            this.SelectedValueTextBox.ReadOnly = true;
            this.SelectedValueTextBox.Size = new System.Drawing.Size(68, 20);
            this.SelectedValueTextBox.TabIndex = 8;
            // 
            // EnumerationLabel
            // 
            this.EnumerationLabel.AutoSize = true;
            this.EnumerationLabel.Location = new System.Drawing.Point(3, 3);
            this.EnumerationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnumerationLabel.Name = "EnumerationLabel";
            this.EnumerationLabel.Size = new System.Drawing.Size(66, 13);
            this.EnumerationLabel.TabIndex = 12;
            this.EnumerationLabel.Text = "Enumeration";
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumerationLabel);
            this.Controls.Add(this.IntValueLabel);
            this.Controls.Add(this.ChooseValueLabel);
            this.Controls.Add(this.EnumsListBox);
            this.Controls.Add(this.ValuesListBox);
            this.Controls.Add(this.EnumsLabel);
            this.Controls.Add(this.SelectedValueTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(512, 298);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label EnumsLabel;
        private System.Windows.Forms.TextBox SelectedValueTextBox;
        private System.Windows.Forms.Label EnumerationLabel;
    }
}
