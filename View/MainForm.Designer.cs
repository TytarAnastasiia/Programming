namespace Programming
{
    partial class MainForm
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
            this.tabControl_Enums = new System.Windows.Forms.TabControl();
            this.tabPage_Enums = new System.Windows.Forms.TabPage();
            this.weekdayParsingControl2 = new Programming.View.Panels.WeekdayParsingControl();
            this.seasonHandleControl2 = new Programming.View.Panels.SeasonHandleControl();
            this.enumerationsControl2 = new Programming.View.Panels.EnumerationsControl();
            this.tabPage_Classes = new System.Windows.Forms.TabPage();
            this.groupBox_Movies = new System.Windows.Forms.GroupBox();
            this.label_Rating = new System.Windows.Forms.Label();
            this.label_Genre = new System.Windows.Forms.Label();
            this.textBox_Rating = new System.Windows.Forms.TextBox();
            this.textBox_Genre = new System.Windows.Forms.TextBox();
            this.label_Year = new System.Windows.Forms.Label();
            this.label_Duration = new System.Windows.Forms.Label();
            this.button_FindMovie = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.textBox_Duration = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.listBox_Movies = new System.Windows.Forms.ListBox();
            this.groupBox_Rectangles = new System.Windows.Forms.GroupBox();
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
            this.tabPage_Rectangles = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.tabControl_Enums.SuspendLayout();
            this.tabPage_Enums.SuspendLayout();
            this.tabPage_Classes.SuspendLayout();
            this.groupBox_Movies.SuspendLayout();
            this.groupBox_Rectangles.SuspendLayout();
            this.tabPage_Rectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Enums
            // 
            this.tabControl_Enums.Controls.Add(this.tabPage_Enums);
            this.tabControl_Enums.Controls.Add(this.tabPage_Classes);
            this.tabControl_Enums.Controls.Add(this.tabPage_Rectangles);
            this.tabControl_Enums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Enums.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Enums.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_Enums.Name = "tabControl_Enums";
            this.tabControl_Enums.SelectedIndex = 0;
            this.tabControl_Enums.Size = new System.Drawing.Size(741, 419);
            this.tabControl_Enums.TabIndex = 2;
            // 
            // tabPage_Enums
            // 
            this.tabPage_Enums.Controls.Add(this.weekdayParsingControl2);
            this.tabPage_Enums.Controls.Add(this.seasonHandleControl2);
            this.tabPage_Enums.Controls.Add(this.enumerationsControl2);
            this.tabPage_Enums.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Enums.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Enums.Name = "tabPage_Enums";
            this.tabPage_Enums.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Enums.Size = new System.Drawing.Size(733, 393);
            this.tabPage_Enums.TabIndex = 0;
            this.tabPage_Enums.Text = "Enums";
            this.tabPage_Enums.UseVisualStyleBackColor = true;
            // 
            // weekdayParsingControl2
            // 
            this.weekdayParsingControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekdayParsingControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.weekdayParsingControl2.Location = new System.Drawing.Point(2, 239);
            this.weekdayParsingControl2.Margin = new System.Windows.Forms.Padding(1);
            this.weekdayParsingControl2.Name = "weekdayParsingControl2";
            this.weekdayParsingControl2.Size = new System.Drawing.Size(343, 152);
            this.weekdayParsingControl2.TabIndex = 9;
            // 
            // seasonHandleControl2
            // 
            this.seasonHandleControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seasonHandleControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.seasonHandleControl2.Location = new System.Drawing.Point(340, 239);
            this.seasonHandleControl2.Margin = new System.Windows.Forms.Padding(1);
            this.seasonHandleControl2.Name = "seasonHandleControl2";
            this.seasonHandleControl2.Size = new System.Drawing.Size(391, 152);
            this.seasonHandleControl2.TabIndex = 8;
            // 
            // enumerationsControl2
            // 
            this.enumerationsControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enumerationsControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.enumerationsControl2.Location = new System.Drawing.Point(2, 2);
            this.enumerationsControl2.Margin = new System.Windows.Forms.Padding(1);
            this.enumerationsControl2.Name = "enumerationsControl2";
            this.enumerationsControl2.Size = new System.Drawing.Size(729, 237);
            this.enumerationsControl2.TabIndex = 7;
            // 
            // tabPage_Classes
            // 
            this.tabPage_Classes.Controls.Add(this.groupBox_Movies);
            this.tabPage_Classes.Controls.Add(this.groupBox_Rectangles);
            this.tabPage_Classes.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Classes.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Classes.Name = "tabPage_Classes";
            this.tabPage_Classes.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Classes.Size = new System.Drawing.Size(733, 393);
            this.tabPage_Classes.TabIndex = 1;
            this.tabPage_Classes.Text = "Classes";
            this.tabPage_Classes.UseVisualStyleBackColor = true;
            // 
            // groupBox_Movies
            // 
            this.groupBox_Movies.Controls.Add(this.label_Rating);
            this.groupBox_Movies.Controls.Add(this.label_Genre);
            this.groupBox_Movies.Controls.Add(this.textBox_Rating);
            this.groupBox_Movies.Controls.Add(this.textBox_Genre);
            this.groupBox_Movies.Controls.Add(this.label_Year);
            this.groupBox_Movies.Controls.Add(this.label_Duration);
            this.groupBox_Movies.Controls.Add(this.button_FindMovie);
            this.groupBox_Movies.Controls.Add(this.label_Name);
            this.groupBox_Movies.Controls.Add(this.textBox_Year);
            this.groupBox_Movies.Controls.Add(this.textBox_Duration);
            this.groupBox_Movies.Controls.Add(this.textBox_Name);
            this.groupBox_Movies.Controls.Add(this.listBox_Movies);
            this.groupBox_Movies.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox_Movies.Location = new System.Drawing.Point(362, 2);
            this.groupBox_Movies.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Movies.Name = "groupBox_Movies";
            this.groupBox_Movies.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Movies.Size = new System.Drawing.Size(369, 389);
            this.groupBox_Movies.TabIndex = 1;
            this.groupBox_Movies.TabStop = false;
            this.groupBox_Movies.Text = "Movies";
            // 
            // label_Rating
            // 
            this.label_Rating.AutoSize = true;
            this.label_Rating.Location = new System.Drawing.Point(187, 205);
            this.label_Rating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Rating.Name = "label_Rating";
            this.label_Rating.Size = new System.Drawing.Size(38, 13);
            this.label_Rating.TabIndex = 19;
            this.label_Rating.Text = "Rating";
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Location = new System.Drawing.Point(187, 164);
            this.label_Genre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(36, 13);
            this.label_Genre.TabIndex = 18;
            this.label_Genre.Text = "Genre";
            // 
            // textBox_Rating
            // 
            this.textBox_Rating.Location = new System.Drawing.Point(187, 220);
            this.textBox_Rating.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Rating.Name = "textBox_Rating";
            this.textBox_Rating.Size = new System.Drawing.Size(91, 20);
            this.textBox_Rating.TabIndex = 17;
            this.textBox_Rating.TextChanged += new System.EventHandler(this.textBox_Rating_TextChanged);
            // 
            // textBox_Genre
            // 
            this.textBox_Genre.Location = new System.Drawing.Point(187, 179);
            this.textBox_Genre.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Genre.Name = "textBox_Genre";
            this.textBox_Genre.Size = new System.Drawing.Size(91, 20);
            this.textBox_Genre.TabIndex = 16;
            this.textBox_Genre.TextChanged += new System.EventHandler(this.textBox_Genre_TextChanged);
            // 
            // label_Year
            // 
            this.label_Year.AutoSize = true;
            this.label_Year.Location = new System.Drawing.Point(187, 120);
            this.label_Year.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Year.Name = "label_Year";
            this.label_Year.Size = new System.Drawing.Size(29, 13);
            this.label_Year.TabIndex = 15;
            this.label_Year.Text = "Year";
            // 
            // label_Duration
            // 
            this.label_Duration.AutoSize = true;
            this.label_Duration.Location = new System.Drawing.Point(187, 79);
            this.label_Duration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Duration.Name = "label_Duration";
            this.label_Duration.Size = new System.Drawing.Size(47, 13);
            this.label_Duration.TabIndex = 14;
            this.label_Duration.Text = "Duration";
            // 
            // button_FindMovie
            // 
            this.button_FindMovie.Location = new System.Drawing.Point(39, 219);
            this.button_FindMovie.Margin = new System.Windows.Forms.Padding(2);
            this.button_FindMovie.Name = "button_FindMovie";
            this.button_FindMovie.Size = new System.Drawing.Size(67, 20);
            this.button_FindMovie.TabIndex = 13;
            this.button_FindMovie.Text = "Find";
            this.button_FindMovie.UseVisualStyleBackColor = true;
            this.button_FindMovie.Click += new System.EventHandler(this.button_FindMovie_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(187, 38);
            this.label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 12;
            this.label_Name.Text = "Name";
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(187, 135);
            this.textBox_Year.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(91, 20);
            this.textBox_Year.TabIndex = 11;
            this.textBox_Year.TextChanged += new System.EventHandler(this.textBox_Year_TextChanged);
            // 
            // textBox_Duration
            // 
            this.textBox_Duration.Location = new System.Drawing.Point(187, 94);
            this.textBox_Duration.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Duration.Name = "textBox_Duration";
            this.textBox_Duration.Size = new System.Drawing.Size(91, 20);
            this.textBox_Duration.TabIndex = 10;
            this.textBox_Duration.TextChanged += new System.EventHandler(this.textBox_Duration_TextChanged);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(187, 53);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(91, 20);
            this.textBox_Name.TabIndex = 9;
            // 
            // listBox_Movies
            // 
            this.listBox_Movies.FormattingEnabled = true;
            this.listBox_Movies.Location = new System.Drawing.Point(39, 38);
            this.listBox_Movies.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Movies.Name = "listBox_Movies";
            this.listBox_Movies.Size = new System.Drawing.Size(105, 160);
            this.listBox_Movies.TabIndex = 8;
            this.listBox_Movies.SelectedIndexChanged += new System.EventHandler(this.listBox_Movies_SelectedIndexChanged);
            // 
            // groupBox_Rectangles
            // 
            this.groupBox_Rectangles.Controls.Add(this.label_id);
            this.groupBox_Rectangles.Controls.Add(this.label_center_y);
            this.groupBox_Rectangles.Controls.Add(this.label_center_x);
            this.groupBox_Rectangles.Controls.Add(this.textBox_id);
            this.groupBox_Rectangles.Controls.Add(this.textBox_center_y);
            this.groupBox_Rectangles.Controls.Add(this.textBox_center_x);
            this.groupBox_Rectangles.Controls.Add(this.label_Color);
            this.groupBox_Rectangles.Controls.Add(this.label_Width);
            this.groupBox_Rectangles.Controls.Add(this.button_Find);
            this.groupBox_Rectangles.Controls.Add(this.label_Length);
            this.groupBox_Rectangles.Controls.Add(this.textBox_Color);
            this.groupBox_Rectangles.Controls.Add(this.textBox_Width);
            this.groupBox_Rectangles.Controls.Add(this.textBox_Length);
            this.groupBox_Rectangles.Controls.Add(this.listBox_Rectangles);
            this.groupBox_Rectangles.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_Rectangles.Location = new System.Drawing.Point(2, 2);
            this.groupBox_Rectangles.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Rectangles.Name = "groupBox_Rectangles";
            this.groupBox_Rectangles.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Rectangles.Size = new System.Drawing.Size(359, 389);
            this.groupBox_Rectangles.TabIndex = 0;
            this.groupBox_Rectangles.TabStop = false;
            this.groupBox_Rectangles.Text = "Rectangles";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(179, 250);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 13;
            this.label_id.Text = "ID";
            // 
            // label_center_y
            // 
            this.label_center_y.AutoSize = true;
            this.label_center_y.Location = new System.Drawing.Point(179, 206);
            this.label_center_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_center_y.Name = "label_center_y";
            this.label_center_y.Size = new System.Drawing.Size(48, 13);
            this.label_center_y.TabIndex = 12;
            this.label_center_y.Text = "Center Y";
            // 
            // label_center_x
            // 
            this.label_center_x.AutoSize = true;
            this.label_center_x.Location = new System.Drawing.Point(179, 164);
            this.label_center_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_center_x.Name = "label_center_x";
            this.label_center_x.Size = new System.Drawing.Size(48, 13);
            this.label_center_x.TabIndex = 11;
            this.label_center_x.Text = "Center X";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(179, 265);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(91, 20);
            this.textBox_id.TabIndex = 10;
            // 
            // textBox_center_y
            // 
            this.textBox_center_y.Location = new System.Drawing.Point(179, 221);
            this.textBox_center_y.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_center_y.Name = "textBox_center_y";
            this.textBox_center_y.ReadOnly = true;
            this.textBox_center_y.Size = new System.Drawing.Size(91, 20);
            this.textBox_center_y.TabIndex = 9;
            // 
            // textBox_center_x
            // 
            this.textBox_center_x.Location = new System.Drawing.Point(179, 179);
            this.textBox_center_x.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_center_x.Name = "textBox_center_x";
            this.textBox_center_x.ReadOnly = true;
            this.textBox_center_x.Size = new System.Drawing.Size(91, 20);
            this.textBox_center_x.TabIndex = 8;
            // 
            // label_Color
            // 
            this.label_Color.AutoSize = true;
            this.label_Color.Location = new System.Drawing.Point(179, 120);
            this.label_Color.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(31, 13);
            this.label_Color.TabIndex = 7;
            this.label_Color.Text = "Color";
            // 
            // label_Width
            // 
            this.label_Width.AutoSize = true;
            this.label_Width.Location = new System.Drawing.Point(179, 79);
            this.label_Width.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Width.Name = "label_Width";
            this.label_Width.Size = new System.Drawing.Size(35, 13);
            this.label_Width.TabIndex = 6;
            this.label_Width.Text = "Width";
            // 
            // button_Find
            // 
            this.button_Find.Location = new System.Drawing.Point(29, 218);
            this.button_Find.Margin = new System.Windows.Forms.Padding(2);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(67, 20);
            this.button_Find.TabIndex = 5;
            this.button_Find.Text = "Find";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // label_Length
            // 
            this.label_Length.AutoSize = true;
            this.label_Length.Location = new System.Drawing.Point(179, 38);
            this.label_Length.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Length.Name = "label_Length";
            this.label_Length.Size = new System.Drawing.Size(40, 13);
            this.label_Length.TabIndex = 4;
            this.label_Length.Text = "Length";
            // 
            // textBox_Color
            // 
            this.textBox_Color.Location = new System.Drawing.Point(179, 135);
            this.textBox_Color.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Color.Name = "textBox_Color";
            this.textBox_Color.Size = new System.Drawing.Size(91, 20);
            this.textBox_Color.TabIndex = 3;
            this.textBox_Color.TextChanged += new System.EventHandler(this.textBox_Color_TextChanged);
            // 
            // textBox_Width
            // 
            this.textBox_Width.Location = new System.Drawing.Point(179, 94);
            this.textBox_Width.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(91, 20);
            this.textBox_Width.TabIndex = 2;
            this.textBox_Width.TextChanged += new System.EventHandler(this.textBox_Width_TextChanged);
            // 
            // textBox_Length
            // 
            this.textBox_Length.Location = new System.Drawing.Point(179, 53);
            this.textBox_Length.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Length.Name = "textBox_Length";
            this.textBox_Length.Size = new System.Drawing.Size(91, 20);
            this.textBox_Length.TabIndex = 1;
            this.textBox_Length.TextChanged += new System.EventHandler(this.textBox_Length_TextChanged);
            // 
            // listBox_Rectangles
            // 
            this.listBox_Rectangles.FormattingEnabled = true;
            this.listBox_Rectangles.Location = new System.Drawing.Point(29, 38);
            this.listBox_Rectangles.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Rectangles.Name = "listBox_Rectangles";
            this.listBox_Rectangles.Size = new System.Drawing.Size(105, 160);
            this.listBox_Rectangles.TabIndex = 0;
            this.listBox_Rectangles.SelectedIndexChanged += new System.EventHandler(this.listBox_Rectangles_SelectedIndexChanged);
            // 
            // tabPage_Rectangles
            // 
            this.tabPage_Rectangles.Controls.Add(this.rectanglesCollisionControl1);
            this.tabPage_Rectangles.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Rectangles.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Rectangles.Name = "tabPage_Rectangles";
            this.tabPage_Rectangles.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Rectangles.Size = new System.Drawing.Size(733, 393);
            this.tabPage_Rectangles.TabIndex = 2;
            this.tabPage_Rectangles.Text = "Rectangles";
            this.tabPage_Rectangles.UseVisualStyleBackColor = true;
            this.tabPage_Rectangles.Click += new System.EventHandler(this.tabPage_Rectangles_Click);
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(2, 4);
            this.rectanglesCollisionControl1.Margin = new System.Windows.Forms.Padding(1);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(735, 390);
            this.rectanglesCollisionControl1.TabIndex = 0;
            this.rectanglesCollisionControl1.Load += new System.EventHandler(this.rectanglesCollisionControl1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 419);
            this.Controls.Add(this.tabControl_Enums);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl_Enums.ResumeLayout(false);
            this.tabPage_Enums.ResumeLayout(false);
            this.tabPage_Classes.ResumeLayout(false);
            this.groupBox_Movies.ResumeLayout(false);
            this.groupBox_Movies.PerformLayout();
            this.groupBox_Rectangles.ResumeLayout(false);
            this.groupBox_Rectangles.PerformLayout();
            this.tabPage_Rectangles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl_Enums;
        private System.Windows.Forms.TabPage tabPage_Enums;
        private System.Windows.Forms.TabPage tabPage_Classes;
        private System.Windows.Forms.GroupBox groupBox_Rectangles;
        private System.Windows.Forms.Label label_Length;
        private System.Windows.Forms.TextBox textBox_Color;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.TextBox textBox_Length;
        private System.Windows.Forms.ListBox listBox_Rectangles;
        private System.Windows.Forms.Label label_Color;
        private System.Windows.Forms.Label label_Width;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.GroupBox groupBox_Movies;
        private System.Windows.Forms.Label label_Year;
        private System.Windows.Forms.Label label_Duration;
        private System.Windows.Forms.Button button_FindMovie;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.TextBox textBox_Duration;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ListBox listBox_Movies;
        private System.Windows.Forms.Label label_Rating;
        private System.Windows.Forms.Label label_Genre;
        private System.Windows.Forms.TextBox textBox_Rating;
        private System.Windows.Forms.TextBox textBox_Genre;
        private System.Windows.Forms.TextBox textBox_center_y;
        private System.Windows.Forms.TextBox textBox_center_x;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TabPage tabPage_Rectangles;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_center_y;
        private System.Windows.Forms.Label label_center_x;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.EnumerationsControl enumerationsControl2;
        private View.Panels.SeasonHandleControl seasonHandleControl2;
        private View.Panels.WeekdayParsingControl weekdayParsingControl2;
    }
}

