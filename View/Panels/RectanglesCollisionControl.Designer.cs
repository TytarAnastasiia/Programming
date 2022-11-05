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
            this.tabControl_Enums.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_Enums.Name = "tabControl_Enums";
            this.tabControl_Enums.SelectedIndex = 0;
            this.tabControl_Enums.Size = new System.Drawing.Size(735, 390);
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
            this.tabPage_Rectangles.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Rectangles.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Rectangles.Name = "tabPage_Rectangles";
            this.tabPage_Rectangles.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Rectangles.Size = new System.Drawing.Size(727, 364);
            this.tabPage_Rectangles.TabIndex = 2;
            this.tabPage_Rectangles.Text = "Rectangles";
            this.tabPage_Rectangles.UseVisualStyleBackColor = true;
            // 
            // label_rectHeight
            // 
            this.label_rectHeight.AutoSize = true;
            this.label_rectHeight.Location = new System.Drawing.Point(31, 324);
            this.label_rectHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rectHeight.Name = "label_rectHeight";
            this.label_rectHeight.Size = new System.Drawing.Size(41, 13);
            this.label_rectHeight.TabIndex = 15;
            this.label_rectHeight.Text = "Height:";
            // 
            // textBox_rectHeight
            // 
            this.textBox_rectHeight.Location = new System.Drawing.Point(79, 320);
            this.textBox_rectHeight.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_rectHeight.Name = "textBox_rectHeight";
            this.textBox_rectHeight.Size = new System.Drawing.Size(97, 20);
            this.textBox_rectHeight.TabIndex = 14;
            this.textBox_rectHeight.Leave += new System.EventHandler(this.textBox_rectHeight_TextChanged);
            // 
            // label_rectWidth
            // 
            this.label_rectWidth.AutoSize = true;
            this.label_rectWidth.Location = new System.Drawing.Point(31, 303);
            this.label_rectWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rectWidth.Name = "label_rectWidth";
            this.label_rectWidth.Size = new System.Drawing.Size(38, 13);
            this.label_rectWidth.TabIndex = 13;
            this.label_rectWidth.Text = "Width:";
            // 
            // textBox_rectWidth
            // 
            this.textBox_rectWidth.Location = new System.Drawing.Point(79, 299);
            this.textBox_rectWidth.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_rectWidth.Name = "textBox_rectWidth";
            this.textBox_rectWidth.Size = new System.Drawing.Size(97, 20);
            this.textBox_rectWidth.TabIndex = 12;
            this.textBox_rectWidth.Leave += new System.EventHandler(this.textBox_rectWidth_TextChanged);
            // 
            // label_rectY
            // 
            this.label_rectY.AutoSize = true;
            this.label_rectY.Location = new System.Drawing.Point(31, 282);
            this.label_rectY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rectY.Name = "label_rectY";
            this.label_rectY.Size = new System.Drawing.Size(17, 13);
            this.label_rectY.TabIndex = 11;
            this.label_rectY.Text = "Y:";
            // 
            // textBox_rectY
            // 
            this.textBox_rectY.Location = new System.Drawing.Point(79, 278);
            this.textBox_rectY.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_rectY.Name = "textBox_rectY";
            this.textBox_rectY.Size = new System.Drawing.Size(97, 20);
            this.textBox_rectY.TabIndex = 10;
            this.textBox_rectY.Click += new System.EventHandler(this.textBox_rectY_TextChanged);
            this.textBox_rectY.Leave += new System.EventHandler(this.textBox_rectY_TextChanged);
            // 
            // label_rectX
            // 
            this.label_rectX.AutoSize = true;
            this.label_rectX.Location = new System.Drawing.Point(31, 261);
            this.label_rectX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rectX.Name = "label_rectX";
            this.label_rectX.Size = new System.Drawing.Size(17, 13);
            this.label_rectX.TabIndex = 9;
            this.label_rectX.Text = "X:";
            // 
            // textBox_rectX
            // 
            this.textBox_rectX.Location = new System.Drawing.Point(79, 257);
            this.textBox_rectX.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_rectX.Name = "textBox_rectX";
            this.textBox_rectX.Size = new System.Drawing.Size(97, 20);
            this.textBox_rectX.TabIndex = 8;
            this.textBox_rectX.Click += new System.EventHandler(this.textBox_rectX_TextChanged);
            this.textBox_rectX.Leave += new System.EventHandler(this.textBox_rectX_TextChanged);
            // 
            // label_rectId
            // 
            this.label_rectId.AutoSize = true;
            this.label_rectId.Location = new System.Drawing.Point(31, 240);
            this.label_rectId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rectId.Name = "label_rectId";
            this.label_rectId.Size = new System.Drawing.Size(19, 13);
            this.label_rectId.TabIndex = 7;
            this.label_rectId.Text = "Id:";
            // 
            // textBox_rectId
            // 
            this.textBox_rectId.Location = new System.Drawing.Point(79, 237);
            this.textBox_rectId.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_rectId.Name = "textBox_rectId";
            this.textBox_rectId.ReadOnly = true;
            this.textBox_rectId.Size = new System.Drawing.Size(97, 20);
            this.textBox_rectId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // panel_canvas
            // 
            this.panel_canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_canvas.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_canvas.Location = new System.Drawing.Point(332, 2);
            this.panel_canvas.Margin = new System.Windows.Forms.Padding(2);
            this.panel_canvas.Name = "panel_canvas";
            this.panel_canvas.Size = new System.Drawing.Size(393, 360);
            this.panel_canvas.TabIndex = 4;
            this.panel_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_canvas_Paint_1);
            // 
            // button_RemoveRectangle
            // 
            this.button_RemoveRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RemoveRectangle.Location = new System.Drawing.Point(258, 165);
            this.button_RemoveRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.button_RemoveRectangle.Name = "button_RemoveRectangle";
            this.button_RemoveRectangle.Size = new System.Drawing.Size(50, 21);
            this.button_RemoveRectangle.TabIndex = 3;
            this.button_RemoveRectangle.Text = "x";
            this.button_RemoveRectangle.UseVisualStyleBackColor = true;
            this.button_RemoveRectangle.Click += new System.EventHandler(this.button_RemoveRectangle_Click);
            // 
            // button_AddRectangle
            // 
            this.button_AddRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddRectangle.Location = new System.Drawing.Point(15, 166);
            this.button_AddRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddRectangle.Name = "button_AddRectangle";
            this.button_AddRectangle.Size = new System.Drawing.Size(50, 20);
            this.button_AddRectangle.TabIndex = 2;
            this.button_AddRectangle.Text = "+";
            this.button_AddRectangle.UseVisualStyleBackColor = true;
            this.button_AddRectangle.Click += new System.EventHandler(this.button_AddRectangle_Click);
            // 
            // label_rectangles
            // 
            this.label_rectangles.AutoSize = true;
            this.label_rectangles.Location = new System.Drawing.Point(13, 40);
            this.label_rectangles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rectangles.Name = "label_rectangles";
            this.label_rectangles.Size = new System.Drawing.Size(64, 13);
            this.label_rectangles.TabIndex = 1;
            this.label_rectangles.Text = "Rectangles:";
            // 
            // listBox_rectanglesToShow
            // 
            this.listBox_rectanglesToShow.FormattingEnabled = true;
            this.listBox_rectanglesToShow.Location = new System.Drawing.Point(15, 55);
            this.listBox_rectanglesToShow.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_rectanglesToShow.Name = "listBox_rectanglesToShow";
            this.listBox_rectanglesToShow.Size = new System.Drawing.Size(294, 108);
            this.listBox_rectanglesToShow.TabIndex = 0;
            this.listBox_rectanglesToShow.SelectedIndexChanged += new System.EventHandler(this.listBox_rectanglesToShow_SelectedIndexChanged);
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
