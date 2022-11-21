namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            this.tabControl_Enums = new System.Windows.Forms.TabControl();
            this.RectanglesToShowListBox = new System.Windows.Forms.ListBox();
            this.label_rectangles = new System.Windows.Forms.Label();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_rectId = new System.Windows.Forms.TextBox();
            this.label_rectId = new System.Windows.Forms.Label();
            this.textBox_rectX = new System.Windows.Forms.TextBox();
            this.label_rectX = new System.Windows.Forms.Label();
            this.textBox_rectY = new System.Windows.Forms.TextBox();
            this.label_rectY = new System.Windows.Forms.Label();
            this.textBox_rectWidth = new System.Windows.Forms.TextBox();
            this.label_rectWidth = new System.Windows.Forms.Label();
            this.textBox_rectHeight = new System.Windows.Forms.TextBox();
            this.label_rectHeight = new System.Windows.Forms.Label();
            this.tabPage_Rectangles = new System.Windows.Forms.TabPage();
            this.IdLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.tabControl_Enums.SuspendLayout();
            this.tabPage_Rectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Enums
            // 
            this.tabControl_Enums.Controls.Add(this.tabPage_Rectangles);
            this.tabControl_Enums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Enums.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Enums.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_Enums.Name = "tabControl_Enums";
            this.tabControl_Enums.SelectedIndex = 0;
            this.tabControl_Enums.Size = new System.Drawing.Size(735, 390);
            this.tabControl_Enums.TabIndex = 3;
            // 
            // RectanglesToShowListBox
            // 
            this.RectanglesToShowListBox.FormattingEnabled = true;
            this.RectanglesToShowListBox.Location = new System.Drawing.Point(15, 55);
            this.RectanglesToShowListBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglesToShowListBox.Name = "RectanglesToShowListBox";
            this.RectanglesToShowListBox.Size = new System.Drawing.Size(294, 108);
            this.RectanglesToShowListBox.TabIndex = 0;
            this.RectanglesToShowListBox.SelectedIndexChanged += new System.EventHandler(this.listBox_rectanglesToShow_SelectedIndexChanged);
            // 
            // label_rectangles
            // 
            this.label_rectangles.AutoSize = true;
            this.label_rectangles.Location = new System.Drawing.Point(13, 40);
            this.label_rectangles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rectangles.Name = "label_rectangles";
            this.label_rectangles.Size = new System.Drawing.Size(0, 13);
            this.label_rectangles.TabIndex = 1;
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Location = new System.Drawing.Point(15, 166);
            this.AddRectangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(50, 20);
            this.AddRectangleButton.TabIndex = 2;
            this.AddRectangleButton.Text = "+";
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.button_AddRectangle_Click);
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(258, 165);
            this.RemoveRectangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(50, 21);
            this.RemoveRectangleButton.TabIndex = 3;
            this.RemoveRectangleButton.Text = "x";
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.button_RemoveRectangle_Click);
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CanvasPanel.Location = new System.Drawing.Point(332, 2);
            this.CanvasPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(393, 360);
            this.CanvasPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // textBox_rectId
            // 
            this.textBox_rectId.Location = new System.Drawing.Point(53, 227);
            this.textBox_rectId.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_rectId.Name = "textBox_rectId";
            this.textBox_rectId.ReadOnly = true;
            this.textBox_rectId.Size = new System.Drawing.Size(97, 20);
            this.textBox_rectId.TabIndex = 6;
            // 
            // label_rectId
            // 
            this.label_rectId.AutoSize = true;
            this.label_rectId.Location = new System.Drawing.Point(19, 229);
            this.label_rectId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rectId.Name = "label_rectId";
            this.label_rectId.Size = new System.Drawing.Size(0, 13);
            this.label_rectId.TabIndex = 7;
            // 
            // textBox_rectX
            // 
            this.textBox_rectX.Location = new System.Drawing.Point(53, 247);
            this.textBox_rectX.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_rectX.Name = "textBox_rectX";
            this.textBox_rectX.Size = new System.Drawing.Size(97, 20);
            this.textBox_rectX.TabIndex = 8;
            this.textBox_rectX.Click += new System.EventHandler(this.textBox_rectX_TextChanged);
            this.textBox_rectX.Leave += new System.EventHandler(this.textBox_rectX_TextChanged);
            // 
            // label_rectX
            // 
            this.label_rectX.AutoSize = true;
            this.label_rectX.Location = new System.Drawing.Point(19, 250);
            this.label_rectX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rectX.Name = "label_rectX";
            this.label_rectX.Size = new System.Drawing.Size(0, 13);
            this.label_rectX.TabIndex = 9;
            // 
            // textBox_rectY
            // 
            this.textBox_rectY.Location = new System.Drawing.Point(53, 268);
            this.textBox_rectY.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_rectY.Name = "textBox_rectY";
            this.textBox_rectY.Size = new System.Drawing.Size(97, 20);
            this.textBox_rectY.TabIndex = 10;
            this.textBox_rectY.Click += new System.EventHandler(this.textBox_rectY_TextChanged);
            this.textBox_rectY.Leave += new System.EventHandler(this.textBox_rectY_TextChanged);
            // 
            // label_rectY
            // 
            this.label_rectY.AutoSize = true;
            this.label_rectY.Location = new System.Drawing.Point(19, 271);
            this.label_rectY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rectY.Name = "label_rectY";
            this.label_rectY.Size = new System.Drawing.Size(0, 13);
            this.label_rectY.TabIndex = 11;
            // 
            // textBox_rectWidth
            // 
            this.textBox_rectWidth.Location = new System.Drawing.Point(53, 289);
            this.textBox_rectWidth.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_rectWidth.Name = "textBox_rectWidth";
            this.textBox_rectWidth.Size = new System.Drawing.Size(97, 20);
            this.textBox_rectWidth.TabIndex = 12;
            this.textBox_rectWidth.Leave += new System.EventHandler(this.textBox_rectWidth_TextChanged);
            // 
            // label_rectWidth
            // 
            this.label_rectWidth.AutoSize = true;
            this.label_rectWidth.Location = new System.Drawing.Point(19, 292);
            this.label_rectWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rectWidth.Name = "label_rectWidth";
            this.label_rectWidth.Size = new System.Drawing.Size(0, 13);
            this.label_rectWidth.TabIndex = 13;
            // 
            // textBox_rectHeight
            // 
            this.textBox_rectHeight.Location = new System.Drawing.Point(53, 310);
            this.textBox_rectHeight.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_rectHeight.Name = "textBox_rectHeight";
            this.textBox_rectHeight.Size = new System.Drawing.Size(97, 20);
            this.textBox_rectHeight.TabIndex = 14;
            this.textBox_rectHeight.Leave += new System.EventHandler(this.textBox_rectHeight_TextChanged);
            // 
            // label_rectHeight
            // 
            this.label_rectHeight.AutoSize = true;
            this.label_rectHeight.Location = new System.Drawing.Point(19, 313);
            this.label_rectHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rectHeight.Name = "label_rectHeight";
            this.label_rectHeight.Size = new System.Drawing.Size(0, 13);
            this.label_rectHeight.TabIndex = 15;
            // 
            // tabPage_Rectangles
            // 
            this.tabPage_Rectangles.Controls.Add(this.SelectedRectangleLabel);
            this.tabPage_Rectangles.Controls.Add(this.HeightLabel);
            this.tabPage_Rectangles.Controls.Add(this.WidthLabel);
            this.tabPage_Rectangles.Controls.Add(this.YLabel);
            this.tabPage_Rectangles.Controls.Add(this.XLabel);
            this.tabPage_Rectangles.Controls.Add(this.IdLabel);
            this.tabPage_Rectangles.Controls.Add(this.label_rectHeight);
            this.tabPage_Rectangles.Controls.Add(this.textBox_rectHeight);
            this.tabPage_Rectangles.Controls.Add(this.label_rectWidth);
            this.tabPage_Rectangles.Controls.Add(this.textBox_rectWidth);
            this.tabPage_Rectangles.Controls.Add(this.label_rectY);
            this.tabPage_Rectangles.Controls.Add(this.textBox_rectY);
            this.tabPage_Rectangles.Controls.Add(this.label_rectX);
            this.tabPage_Rectangles.Controls.Add(this.textBox_rectX);
            this.tabPage_Rectangles.Controls.Add(this.label_rectId);
            this.tabPage_Rectangles.Controls.Add(this.textBox_rectId);
            this.tabPage_Rectangles.Controls.Add(this.label1);
            this.tabPage_Rectangles.Controls.Add(this.CanvasPanel);
            this.tabPage_Rectangles.Controls.Add(this.RemoveRectangleButton);
            this.tabPage_Rectangles.Controls.Add(this.AddRectangleButton);
            this.tabPage_Rectangles.Controls.Add(this.label_rectangles);
            this.tabPage_Rectangles.Controls.Add(this.RectanglesToShowListBox);
            this.tabPage_Rectangles.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Rectangles.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Rectangles.Name = "tabPage_Rectangles";
            this.tabPage_Rectangles.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Rectangles.Size = new System.Drawing.Size(727, 364);
            this.tabPage_Rectangles.TabIndex = 2;
            this.tabPage_Rectangles.Text = "Rectangles";
            this.tabPage_Rectangles.UseVisualStyleBackColor = true;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(13, 229);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 16;
            this.IdLabel.Text = "Id:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(13, 249);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 17;
            this.XLabel.Text = "X:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(13, 270);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 18;
            this.YLabel.Text = "Y:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(13, 292);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 19;
            this.WidthLabel.Text = "Width:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(13, 312);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 20;
            this.HeightLabel.Text = "Height:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(13, 212);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(104, 13);
            this.SelectedRectangleLabel.TabIndex = 21;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_Enums);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(735, 390);
            this.tabControl_Enums.ResumeLayout(false);
            this.tabPage_Rectangles.ResumeLayout(false);
            this.tabPage_Rectangles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Enums;
        private System.Windows.Forms.TabPage tabPage_Rectangles;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label label_rectHeight;
        private System.Windows.Forms.TextBox textBox_rectHeight;
        private System.Windows.Forms.Label label_rectWidth;
        private System.Windows.Forms.TextBox textBox_rectWidth;
        private System.Windows.Forms.Label label_rectY;
        private System.Windows.Forms.TextBox textBox_rectY;
        private System.Windows.Forms.Label label_rectX;
        private System.Windows.Forms.TextBox textBox_rectX;
        private System.Windows.Forms.Label label_rectId;
        private System.Windows.Forms.TextBox textBox_rectId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Label label_rectangles;
        private System.Windows.Forms.ListBox RectanglesToShowListBox;
    }
}
