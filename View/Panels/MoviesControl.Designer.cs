namespace Programming.View.Panels
{
    partial class MoviesControl
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
            this.label_enumeration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Rating
            // 
            this.label_Rating.AutoSize = true;
            this.label_Rating.Location = new System.Drawing.Point(167, 197);
            this.label_Rating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Rating.Name = "label_Rating";
            this.label_Rating.Size = new System.Drawing.Size(38, 13);
            this.label_Rating.TabIndex = 31;
            this.label_Rating.Text = "Rating";
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Location = new System.Drawing.Point(167, 156);
            this.label_Genre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(36, 13);
            this.label_Genre.TabIndex = 30;
            this.label_Genre.Text = "Genre";
            // 
            // textBox_Rating
            // 
            this.textBox_Rating.Location = new System.Drawing.Point(167, 212);
            this.textBox_Rating.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Rating.Name = "textBox_Rating";
            this.textBox_Rating.Size = new System.Drawing.Size(91, 20);
            this.textBox_Rating.TabIndex = 29;
            this.textBox_Rating.TextChanged += new System.EventHandler(this.textBox_Rating_TextChanged);
            // 
            // textBox_Genre
            // 
            this.textBox_Genre.Location = new System.Drawing.Point(167, 171);
            this.textBox_Genre.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Genre.Name = "textBox_Genre";
            this.textBox_Genre.Size = new System.Drawing.Size(91, 20);
            this.textBox_Genre.TabIndex = 28;
            this.textBox_Genre.TextChanged += new System.EventHandler(this.textBox_Genre_TextChanged);
            // 
            // label_Year
            // 
            this.label_Year.AutoSize = true;
            this.label_Year.Location = new System.Drawing.Point(167, 112);
            this.label_Year.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Year.Name = "label_Year";
            this.label_Year.Size = new System.Drawing.Size(29, 13);
            this.label_Year.TabIndex = 27;
            this.label_Year.Text = "Year";
            // 
            // label_Duration
            // 
            this.label_Duration.AutoSize = true;
            this.label_Duration.Location = new System.Drawing.Point(167, 71);
            this.label_Duration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Duration.Name = "label_Duration";
            this.label_Duration.Size = new System.Drawing.Size(47, 13);
            this.label_Duration.TabIndex = 26;
            this.label_Duration.Text = "Duration";
            // 
            // button_FindMovie
            // 
            this.button_FindMovie.Location = new System.Drawing.Point(19, 211);
            this.button_FindMovie.Margin = new System.Windows.Forms.Padding(2);
            this.button_FindMovie.Name = "button_FindMovie";
            this.button_FindMovie.Size = new System.Drawing.Size(67, 20);
            this.button_FindMovie.TabIndex = 25;
            this.button_FindMovie.Text = "Find";
            this.button_FindMovie.UseVisualStyleBackColor = true;
            this.button_FindMovie.Click += new System.EventHandler(this.button_FindMovie_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(167, 30);
            this.label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 24;
            this.label_Name.Text = "Name";
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(167, 127);
            this.textBox_Year.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(91, 20);
            this.textBox_Year.TabIndex = 23;
            this.textBox_Year.TextChanged += new System.EventHandler(this.textBox_Year_TextChanged);
            // 
            // textBox_Duration
            // 
            this.textBox_Duration.Location = new System.Drawing.Point(167, 86);
            this.textBox_Duration.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Duration.Name = "textBox_Duration";
            this.textBox_Duration.Size = new System.Drawing.Size(91, 20);
            this.textBox_Duration.TabIndex = 22;
            this.textBox_Duration.TextChanged += new System.EventHandler(this.textBox_Duration_TextChanged);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(167, 45);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(91, 20);
            this.textBox_Name.TabIndex = 21;
            // 
            // listBox_Movies
            // 
            this.listBox_Movies.FormattingEnabled = true;
            this.listBox_Movies.Location = new System.Drawing.Point(19, 30);
            this.listBox_Movies.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Movies.Name = "listBox_Movies";
            this.listBox_Movies.Size = new System.Drawing.Size(105, 160);
            this.listBox_Movies.TabIndex = 20;
            this.listBox_Movies.SelectedIndexChanged += new System.EventHandler(this.listBox_Movies_SelectedIndexChanged);
            // 
            // label_enumeration
            // 
            this.label_enumeration.AutoSize = true;
            this.label_enumeration.Location = new System.Drawing.Point(2, 0);
            this.label_enumeration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_enumeration.Name = "label_enumeration";
            this.label_enumeration.Size = new System.Drawing.Size(41, 13);
            this.label_enumeration.TabIndex = 32;
            this.label_enumeration.Text = "Movies";
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_enumeration);
            this.Controls.Add(this.label_Rating);
            this.Controls.Add(this.label_Genre);
            this.Controls.Add(this.textBox_Rating);
            this.Controls.Add(this.textBox_Genre);
            this.Controls.Add(this.label_Year);
            this.Controls.Add(this.label_Duration);
            this.Controls.Add(this.button_FindMovie);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_Year);
            this.Controls.Add(this.textBox_Duration);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.listBox_Movies);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(329, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Rating;
        private System.Windows.Forms.Label label_Genre;
        private System.Windows.Forms.TextBox textBox_Rating;
        private System.Windows.Forms.TextBox textBox_Genre;
        private System.Windows.Forms.Label label_Year;
        private System.Windows.Forms.Label label_Duration;
        private System.Windows.Forms.Button button_FindMovie;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.TextBox textBox_Duration;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ListBox listBox_Movies;
        private System.Windows.Forms.Label label_enumeration;
    }
}
