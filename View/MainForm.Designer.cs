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
            this.tabPage_Rectangles = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.moviesControl2 = new Programming.View.Panels.MoviesControl();
            this.rectangleControl2 = new Programming.View.Panels.RectangleControl();
            this.tabControl_Enums.SuspendLayout();
            this.tabPage_Enums.SuspendLayout();
            this.tabPage_Classes.SuspendLayout();
            this.tabPage_Rectangles.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tabPage_Classes.Controls.Add(this.tableLayoutPanel2);
            this.tabPage_Classes.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Classes.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Classes.Name = "tabPage_Classes";
            this.tabPage_Classes.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Classes.Size = new System.Drawing.Size(733, 393);
            this.tabPage_Classes.TabIndex = 1;
            this.tabPage_Classes.Text = "Classes";
            this.tabPage_Classes.UseVisualStyleBackColor = true;
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
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(2, 4);
            this.rectanglesCollisionControl1.Margin = new System.Windows.Forms.Padding(1);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(735, 390);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.moviesControl2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rectangleControl2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(727, 387);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // moviesControl2
            // 
            this.moviesControl2.Location = new System.Drawing.Point(366, 3);
            this.moviesControl2.Name = "moviesControl2";
            this.moviesControl2.Size = new System.Drawing.Size(329, 247);
            this.moviesControl2.TabIndex = 0;
            // 
            // rectangleControl2
            // 
            this.rectangleControl2.Location = new System.Drawing.Point(3, 3);
            this.rectangleControl2.Name = "rectangleControl2";
            this.rectangleControl2.Size = new System.Drawing.Size(357, 313);
            this.rectangleControl2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 419);
            this.Controls.Add(this.tabControl_Enums);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabControl_Enums.ResumeLayout(false);
            this.tabPage_Enums.ResumeLayout(false);
            this.tabPage_Classes.ResumeLayout(false);
            this.tabPage_Rectangles.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl_Enums;
        private System.Windows.Forms.TabPage tabPage_Enums;
        private System.Windows.Forms.TabPage tabPage_Classes;
        private System.Windows.Forms.TabPage tabPage_Rectangles;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.EnumerationsControl enumerationsControl2;
        private View.Panels.SeasonHandleControl seasonHandleControl2;
        private View.Panels.WeekdayParsingControl weekdayParsingControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private View.Panels.MoviesControl moviesControl2;
        private View.Panels.RectangleControl rectangleControl2;
    }
}

