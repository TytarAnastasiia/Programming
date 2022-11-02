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
            this.tabPage_Rectangles = new System.Windows.Forms.TabPage();
            this.label_rectHeight = new System.Windows.Forms.Label();
            this.textBox_rectHeight = new System.Windows.Forms.TextBox();
            this.label_rectWidth = new System.Windows.Forms.Label();
            this.textBox_rectWidth = new System.Windows.Forms.TextBox();
            this.label_rectY = new System.Windows.Forms.Label();
            this.textBox_rectY = new System.Windows.Forms.TextBox();
            this.label_rectX = new System.Windows.Forms.Label();
            this.textBox_rectX = new System.Windows.Forms.TextBox();
            this.label_rectId = new System.Windows.Forms.Label();
            this.textBox_rectId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_canvas = new System.Windows.Forms.Panel();
            this.button_RemoveRectangle = new System.Windows.Forms.Button();
            this.button_AddRectangle = new System.Windows.Forms.Button();
            this.label_rectangles = new System.Windows.Forms.Label();
            this.listBox_rectanglesToShow = new System.Windows.Forms.ListBox();
            this.tabControl_Enums.SuspendLayout();
            this.tabPage_Rectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Enums
            // 
            this.tabControl_Enums.Controls.Add(this.tabPage_Rectangles);
            this.tabControl_Enums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Enums.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Enums.Name = "tabControl_Enums";
            this.tabControl_Enums.SelectedIndex = 0;
            this.tabControl_Enums.Size = new System.Drawing.Size(1103, 600);
            this.tabControl_Enums.TabIndex = 3;
            // 
            // tabPage_Rectangles
            // 
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
            this.tabPage_Rectangles.Controls.Add(this.panel_canvas);
            this.tabPage_Rectangles.Controls.Add(this.button_RemoveRectangle);
            this.tabPage_Rectangles.Controls.Add(this.button_AddRectangle);
            this.tabPage_Rectangles.Controls.Add(this.label_rectangles);
            this.tabPage_Rectangles.Controls.Add(this.listBox_rectanglesToShow);
            this.tabPage_Rectangles.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Rectangles.Name = "tabPage_Rectangles";
            this.tabPage_Rectangles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Rectangles.Size = new System.Drawing.Size(1095, 567);
            this.tabPage_Rectangles.TabIndex = 2;
            this.tabPage_Rectangles.Text = "Rectangles";
            this.tabPage_Rectangles.UseVisualStyleBackColor = true;
            // 
            // label_rectHeight
            // 
            this.label_rectHeight.AutoSize = true;
            this.label_rectHeight.Location = new System.Drawing.Point(47, 498);
            this.label_rectHeight.Name = "label_rectHeight";
            this.label_rectHeight.Size = new System.Drawing.Size(60, 20);
            this.label_rectHeight.TabIndex = 15;
            this.label_rectHeight.Text = "Height:";
            // 
            // textBox_rectHeight
            // 
            this.textBox_rectHeight.Location = new System.Drawing.Point(118, 492);
            this.textBox_rectHeight.Name = "textBox_rectHeight";
            this.textBox_rectHeight.Size = new System.Drawing.Size(143, 26);
            this.textBox_rectHeight.TabIndex = 14;
            // 
            // label_rectWidth
            // 
            this.label_rectWidth.AutoSize = true;
            this.label_rectWidth.Location = new System.Drawing.Point(47, 466);
            this.label_rectWidth.Name = "label_rectWidth";
            this.label_rectWidth.Size = new System.Drawing.Size(54, 20);
            this.label_rectWidth.TabIndex = 13;
            this.label_rectWidth.Text = "Width:";
            // 
            // textBox_rectWidth
            // 
            this.textBox_rectWidth.Location = new System.Drawing.Point(118, 460);
            this.textBox_rectWidth.Name = "textBox_rectWidth";
            this.textBox_rectWidth.Size = new System.Drawing.Size(143, 26);
            this.textBox_rectWidth.TabIndex = 12;
            this.textBox_rectWidth.TextChanged += new System.EventHandler(this.textBox_rectWidth_TextChanged);
            // 
            // label_rectY
            // 
            this.label_rectY.AutoSize = true;
            this.label_rectY.Location = new System.Drawing.Point(47, 434);
            this.label_rectY.Name = "label_rectY";
            this.label_rectY.Size = new System.Drawing.Size(24, 20);
            this.label_rectY.TabIndex = 11;
            this.label_rectY.Text = "Y:";
            // 
            // textBox_rectY
            // 
            this.textBox_rectY.Location = new System.Drawing.Point(118, 428);
            this.textBox_rectY.Name = "textBox_rectY";
            this.textBox_rectY.Size = new System.Drawing.Size(143, 26);
            this.textBox_rectY.TabIndex = 10;
            this.textBox_rectY.Click += new System.EventHandler(this.textBox_rectY_TextChanged);
            this.textBox_rectY.TextChanged += new System.EventHandler(this.textBox_rectY_TextChanged);
            // 
            // label_rectX
            // 
            this.label_rectX.AutoSize = true;
            this.label_rectX.Location = new System.Drawing.Point(47, 402);
            this.label_rectX.Name = "label_rectX";
            this.label_rectX.Size = new System.Drawing.Size(24, 20);
            this.label_rectX.TabIndex = 9;
            this.label_rectX.Text = "X:";
            // 
            // textBox_rectX
            // 
            this.textBox_rectX.Location = new System.Drawing.Point(118, 396);
            this.textBox_rectX.Name = "textBox_rectX";
            this.textBox_rectX.Size = new System.Drawing.Size(143, 26);
            this.textBox_rectX.TabIndex = 8;
            this.textBox_rectX.Click += new System.EventHandler(this.textBox_rectX_TextChanged);
            this.textBox_rectX.TextChanged += new System.EventHandler(this.textBox_rectX_TextChanged);
            // 
            // label_rectId
            // 
            this.label_rectId.AutoSize = true;
            this.label_rectId.Location = new System.Drawing.Point(47, 370);
            this.label_rectId.Name = "label_rectId";
            this.label_rectId.Size = new System.Drawing.Size(27, 20);
            this.label_rectId.TabIndex = 7;
            this.label_rectId.Text = "Id:";
            // 
            // textBox_rectId
            // 
            this.textBox_rectId.Location = new System.Drawing.Point(118, 364);
            this.textBox_rectId.Name = "textBox_rectId";
            this.textBox_rectId.ReadOnly = true;
            this.textBox_rectId.Size = new System.Drawing.Size(143, 26);
            this.textBox_rectId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // panel_canvas
            // 
            this.panel_canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_canvas.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_canvas.Location = new System.Drawing.Point(504, 3);
            this.panel_canvas.Name = "panel_canvas";
            this.panel_canvas.Size = new System.Drawing.Size(588, 561);
            this.panel_canvas.TabIndex = 4;
            this.panel_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_canvas_Paint_1);
            // 
            // button_RemoveRectangle
            // 
            this.button_RemoveRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RemoveRectangle.Location = new System.Drawing.Point(387, 254);
            this.button_RemoveRectangle.Name = "button_RemoveRectangle";
            this.button_RemoveRectangle.Size = new System.Drawing.Size(75, 32);
            this.button_RemoveRectangle.TabIndex = 3;
            this.button_RemoveRectangle.Text = "x";
            this.button_RemoveRectangle.UseVisualStyleBackColor = true;
            this.button_RemoveRectangle.Click += new System.EventHandler(this.button_RemoveRectangle_Click);
            // 
            // button_AddRectangle
            // 
            this.button_AddRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddRectangle.Location = new System.Drawing.Point(23, 255);
            this.button_AddRectangle.Name = "button_AddRectangle";
            this.button_AddRectangle.Size = new System.Drawing.Size(75, 31);
            this.button_AddRectangle.TabIndex = 2;
            this.button_AddRectangle.Text = "+";
            this.button_AddRectangle.UseVisualStyleBackColor = true;
            this.button_AddRectangle.Click += new System.EventHandler(this.button_AddRectangle_Click);
            // 
            // label_rectangles
            // 
            this.label_rectangles.AutoSize = true;
            this.label_rectangles.Location = new System.Drawing.Point(19, 61);
            this.label_rectangles.Name = "label_rectangles";
            this.label_rectangles.Size = new System.Drawing.Size(94, 20);
            this.label_rectangles.TabIndex = 1;
            this.label_rectangles.Text = "Rectangles:";
            // 
            // listBox_rectanglesToShow
            // 
            this.listBox_rectanglesToShow.FormattingEnabled = true;
            this.listBox_rectanglesToShow.ItemHeight = 20;
            this.listBox_rectanglesToShow.Location = new System.Drawing.Point(23, 84);
            this.listBox_rectanglesToShow.Name = "listBox_rectanglesToShow";
            this.listBox_rectanglesToShow.Size = new System.Drawing.Size(439, 164);
            this.listBox_rectanglesToShow.TabIndex = 0;
            this.listBox_rectanglesToShow.SelectedIndexChanged += new System.EventHandler(this.listBox_rectanglesToShow_SelectedIndexChanged);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_Enums);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(1103, 600);
            this.tabControl_Enums.ResumeLayout(false);
            this.tabPage_Rectangles.ResumeLayout(false);
            this.tabPage_Rectangles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Enums;
        private System.Windows.Forms.TabPage tabPage_Rectangles;
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
        private System.Windows.Forms.Panel panel_canvas;
        private System.Windows.Forms.Button button_RemoveRectangle;
        private System.Windows.Forms.Button button_AddRectangle;
        private System.Windows.Forms.Label label_rectangles;
        private System.Windows.Forms.ListBox listBox_rectanglesToShow;
    }
}
