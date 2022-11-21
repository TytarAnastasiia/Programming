namespace Programming.View.Panels
{
    partial class RectangleControl
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.CenterYLabel = new System.Windows.Forms.Label();
            this.CenterXLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CenterYTextBox = new System.Windows.Forms.TextBox();
            this.CenterXTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(170, 244);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 13);
            this.IdLabel.TabIndex = 27;
            this.IdLabel.Text = "ID";
            // 
            // CenterYLabel
            // 
            this.CenterYLabel.AutoSize = true;
            this.CenterYLabel.Location = new System.Drawing.Point(170, 200);
            this.CenterYLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CenterYLabel.Name = "CenterYLabel";
            this.CenterYLabel.Size = new System.Drawing.Size(48, 13);
            this.CenterYLabel.TabIndex = 26;
            this.CenterYLabel.Text = "Center Y";
            // 
            // CenterXLabel
            // 
            this.CenterXLabel.AutoSize = true;
            this.CenterXLabel.Location = new System.Drawing.Point(170, 158);
            this.CenterXLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CenterXLabel.Name = "CenterXLabel";
            this.CenterXLabel.Size = new System.Drawing.Size(48, 13);
            this.CenterXLabel.TabIndex = 25;
            this.CenterXLabel.Text = "Center X";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(170, 259);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(91, 20);
            this.IdTextBox.TabIndex = 24;
            // 
            // CenterYTextBox
            // 
            this.CenterYTextBox.Location = new System.Drawing.Point(170, 215);
            this.CenterYTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CenterYTextBox.Name = "CenterYTextBox";
            this.CenterYTextBox.ReadOnly = true;
            this.CenterYTextBox.Size = new System.Drawing.Size(91, 20);
            this.CenterYTextBox.TabIndex = 23;
            // 
            // CenterXTextBox
            // 
            this.CenterXTextBox.Location = new System.Drawing.Point(170, 173);
            this.CenterXTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CenterXTextBox.Name = "CenterXTextBox";
            this.CenterXTextBox.ReadOnly = true;
            this.CenterXTextBox.Size = new System.Drawing.Size(91, 20);
            this.CenterXTextBox.TabIndex = 22;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(170, 114);
            this.ColorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(31, 13);
            this.ColorLabel.TabIndex = 21;
            this.ColorLabel.Text = "Color";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(170, 73);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 20;
            this.WidthLabel.Text = "Width";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(20, 212);
            this.FindButton.Margin = new System.Windows.Forms.Padding(2);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(67, 20);
            this.FindButton.TabIndex = 19;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(170, 32);
            this.LengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(40, 13);
            this.LengthLabel.TabIndex = 18;
            this.LengthLabel.Text = "Length";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(170, 129);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(91, 20);
            this.ColorTextBox.TabIndex = 17;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.textBox_Color_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(170, 88);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(91, 20);
            this.WidthTextBox.TabIndex = 16;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.textBox_Width_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(170, 47);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(91, 20);
            this.LengthTextBox.TabIndex = 15;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.textBox_Length_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(20, 32);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(105, 160);
            this.RectanglesListBox.TabIndex = 14;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox_Rectangles_SelectedIndexChanged);
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(2, 0);
            this.RectanglesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(55, 13);
            this.RectanglesLabel.TabIndex = 28;
            this.RectanglesLabel.Text = "Retangles";
            // 
            // RectangleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.CenterYLabel);
            this.Controls.Add(this.CenterXLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.CenterYTextBox);
            this.Controls.Add(this.CenterXTextBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.RectanglesListBox);
            this.Name = "RectangleControl";
            this.Size = new System.Drawing.Size(329, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label CenterYLabel;
        private System.Windows.Forms.Label CenterXLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox CenterYTextBox;
        private System.Windows.Forms.TextBox CenterXTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Label RectanglesLabel;
    }
}
