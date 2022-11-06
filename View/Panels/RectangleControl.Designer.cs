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
            this.label_id = new System.Windows.Forms.Label();
            this.label_center_y = new System.Windows.Forms.Label();
            this.label_center_x = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_center_y = new System.Windows.Forms.TextBox();
            this.textBox_center_x = new System.Windows.Forms.TextBox();
            this.label_Color = new System.Windows.Forms.Label();
            this.label_Width = new System.Windows.Forms.Label();
            this.button_Find = new System.Windows.Forms.Button();
            this.label_Length = new System.Windows.Forms.Label();
            this.textBox_Color = new System.Windows.Forms.TextBox();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.textBox_Length = new System.Windows.Forms.TextBox();
            this.listBox_Rectangles = new System.Windows.Forms.ListBox();
            this.label_enumeration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(170, 244);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 27;
            this.label_id.Text = "ID";
            // 
            // label_center_y
            // 
            this.label_center_y.AutoSize = true;
            this.label_center_y.Location = new System.Drawing.Point(170, 200);
            this.label_center_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_center_y.Name = "label_center_y";
            this.label_center_y.Size = new System.Drawing.Size(48, 13);
            this.label_center_y.TabIndex = 26;
            this.label_center_y.Text = "Center Y";
            // 
            // label_center_x
            // 
            this.label_center_x.AutoSize = true;
            this.label_center_x.Location = new System.Drawing.Point(170, 158);
            this.label_center_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_center_x.Name = "label_center_x";
            this.label_center_x.Size = new System.Drawing.Size(48, 13);
            this.label_center_x.TabIndex = 25;
            this.label_center_x.Text = "Center X";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(170, 259);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(91, 20);
            this.textBox_id.TabIndex = 24;
            // 
            // textBox_center_y
            // 
            this.textBox_center_y.Location = new System.Drawing.Point(170, 215);
            this.textBox_center_y.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_center_y.Name = "textBox_center_y";
            this.textBox_center_y.ReadOnly = true;
            this.textBox_center_y.Size = new System.Drawing.Size(91, 20);
            this.textBox_center_y.TabIndex = 23;
            // 
            // textBox_center_x
            // 
            this.textBox_center_x.Location = new System.Drawing.Point(170, 173);
            this.textBox_center_x.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_center_x.Name = "textBox_center_x";
            this.textBox_center_x.ReadOnly = true;
            this.textBox_center_x.Size = new System.Drawing.Size(91, 20);
            this.textBox_center_x.TabIndex = 22;
            // 
            // label_Color
            // 
            this.label_Color.AutoSize = true;
            this.label_Color.Location = new System.Drawing.Point(170, 114);
            this.label_Color.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(31, 13);
            this.label_Color.TabIndex = 21;
            this.label_Color.Text = "Color";
            // 
            // label_Width
            // 
            this.label_Width.AutoSize = true;
            this.label_Width.Location = new System.Drawing.Point(170, 73);
            this.label_Width.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Width.Name = "label_Width";
            this.label_Width.Size = new System.Drawing.Size(35, 13);
            this.label_Width.TabIndex = 20;
            this.label_Width.Text = "Width";
            // 
            // button_Find
            // 
            this.button_Find.Location = new System.Drawing.Point(20, 212);
            this.button_Find.Margin = new System.Windows.Forms.Padding(2);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(67, 20);
            this.button_Find.TabIndex = 19;
            this.button_Find.Text = "Find";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // label_Length
            // 
            this.label_Length.AutoSize = true;
            this.label_Length.Location = new System.Drawing.Point(170, 32);
            this.label_Length.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Length.Name = "label_Length";
            this.label_Length.Size = new System.Drawing.Size(40, 13);
            this.label_Length.TabIndex = 18;
            this.label_Length.Text = "Length";
            // 
            // textBox_Color
            // 
            this.textBox_Color.Location = new System.Drawing.Point(170, 129);
            this.textBox_Color.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Color.Name = "textBox_Color";
            this.textBox_Color.Size = new System.Drawing.Size(91, 20);
            this.textBox_Color.TabIndex = 17;
            this.textBox_Color.TextChanged += new System.EventHandler(this.textBox_Color_TextChanged);
            // 
            // textBox_Width
            // 
            this.textBox_Width.Location = new System.Drawing.Point(170, 88);
            this.textBox_Width.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(91, 20);
            this.textBox_Width.TabIndex = 16;
            this.textBox_Width.TextChanged += new System.EventHandler(this.textBox_Width_TextChanged);
            // 
            // textBox_Length
            // 
            this.textBox_Length.Location = new System.Drawing.Point(170, 47);
            this.textBox_Length.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Length.Name = "textBox_Length";
            this.textBox_Length.Size = new System.Drawing.Size(91, 20);
            this.textBox_Length.TabIndex = 15;
            this.textBox_Length.TextChanged += new System.EventHandler(this.textBox_Length_TextChanged);
            // 
            // listBox_Rectangles
            // 
            this.listBox_Rectangles.FormattingEnabled = true;
            this.listBox_Rectangles.Location = new System.Drawing.Point(20, 32);
            this.listBox_Rectangles.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Rectangles.Name = "listBox_Rectangles";
            this.listBox_Rectangles.Size = new System.Drawing.Size(105, 160);
            this.listBox_Rectangles.TabIndex = 14;
            this.listBox_Rectangles.SelectedIndexChanged += new System.EventHandler(this.listBox_Rectangles_SelectedIndexChanged);
            // 
            // label_enumeration
            // 
            this.label_enumeration.AutoSize = true;
            this.label_enumeration.Location = new System.Drawing.Point(2, 0);
            this.label_enumeration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_enumeration.Name = "label_enumeration";
            this.label_enumeration.Size = new System.Drawing.Size(55, 13);
            this.label_enumeration.TabIndex = 28;
            this.label_enumeration.Text = "Retangles";
            // 
            // RectangleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_enumeration);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_center_y);
            this.Controls.Add(this.label_center_x);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox_center_y);
            this.Controls.Add(this.textBox_center_x);
            this.Controls.Add(this.label_Color);
            this.Controls.Add(this.label_Width);
            this.Controls.Add(this.button_Find);
            this.Controls.Add(this.label_Length);
            this.Controls.Add(this.textBox_Color);
            this.Controls.Add(this.textBox_Width);
            this.Controls.Add(this.textBox_Length);
            this.Controls.Add(this.listBox_Rectangles);
            this.Name = "RectangleControl";
            this.Size = new System.Drawing.Size(329, 290);
            this.Load += new System.EventHandler(this.RectangleControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_center_y;
        private System.Windows.Forms.Label label_center_x;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_center_y;
        private System.Windows.Forms.TextBox textBox_center_x;
        private System.Windows.Forms.Label label_Color;
        private System.Windows.Forms.Label label_Width;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.Label label_Length;
        private System.Windows.Forms.TextBox textBox_Color;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.TextBox textBox_Length;
        private System.Windows.Forms.ListBox listBox_Rectangles;
        private System.Windows.Forms.Label label_enumeration;
    }
}
