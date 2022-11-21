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
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.FindMovieButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(167, 197);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(38, 13);
            this.RatingLabel.TabIndex = 31;
            this.RatingLabel.Text = "Rating";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(167, 156);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 30;
            this.GenreLabel.Text = "Genre";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(167, 212);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(91, 20);
            this.RatingTextBox.TabIndex = 29;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.textBox_Rating_TextChanged);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(167, 171);
            this.GenreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(91, 20);
            this.GenreTextBox.TabIndex = 28;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.textBox_Genre_TextChanged);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(167, 112);
            this.YearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 13);
            this.YearLabel.TabIndex = 27;
            this.YearLabel.Text = "Year";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(167, 71);
            this.DurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(47, 13);
            this.DurationLabel.TabIndex = 26;
            this.DurationLabel.Text = "Duration";
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(19, 211);
            this.FindMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(67, 20);
            this.FindMovieButton.TabIndex = 25;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.button_FindMovie_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(167, 30);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 24;
            this.NameLabel.Text = "Name";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(167, 127);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(91, 20);
            this.YearTextBox.TabIndex = 23;
            this.YearTextBox.TextChanged += new System.EventHandler(this.textBox_Year_TextChanged);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(167, 86);
            this.DurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(91, 20);
            this.DurationTextBox.TabIndex = 22;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.textBox_Duration_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(167, 45);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(91, 20);
            this.NameTextBox.TabIndex = 21;
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Location = new System.Drawing.Point(19, 30);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(105, 160);
            this.MoviesListBox.TabIndex = 20;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox_Movies_SelectedIndexChanged);
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Location = new System.Drawing.Point(2, 0);
            this.MovieLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(41, 13);
            this.MovieLabel.TabIndex = 32;
            this.MovieLabel.Text = "Movies";
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.FindMovieButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.MoviesListBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(329, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Button FindMovieButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Label MovieLabel;
    }
}
