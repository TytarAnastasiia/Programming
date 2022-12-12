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
            this.tabPage_Classes = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.moviesControl2 = new Programming.View.Panels.MoviesControl();
            this.rectangleControl2 = new Programming.View.Panels.RectangleControl();
            this.tabPage_Rectangles = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.weekdayParsingControl1 = new Programming.View.Panels.WeekdayParsingControl();
            this.seasonHandleControl1 = new Programming.View.Panels.SeasonHandleControl();
            this.enumerationsControl1 = new Programming.View.Panels.EnumerationsControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.enumerationsControl2 = new Programming.View.Panels.EnumerationsControl();
            this.weekdayParsingControl2 = new Programming.View.Panels.WeekdayParsingControl();
            this.seasonHandleControl2 = new Programming.View.Panels.SeasonHandleControl();
            this.tabControl_Enums.SuspendLayout();
            this.tabPage_Enums.SuspendLayout();
            this.tabPage_Classes.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage_Rectangles.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Enums
            // 
            this.tabControl_Enums.Controls.Add(this.tabPage_Enums);
            this.tabControl_Enums.Controls.Add(this.tabPage_Classes);
            this.tabControl_Enums.Controls.Add(this.tabPage_Rectangles);
            this.tabControl_Enums.Controls.Add(this.tabPage1);
            this.tabControl_Enums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Enums.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Enums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl_Enums.Name = "tabControl_Enums";
            this.tabControl_Enums.SelectedIndex = 0;
            this.tabControl_Enums.Size = new System.Drawing.Size(724, 450);
            this.tabControl_Enums.TabIndex = 2;
            // 
            // tabPage_Enums
            // 
            this.tabPage_Enums.Controls.Add(this.tableLayoutPanel4);
            this.tabPage_Enums.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Enums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Enums.Name = "tabPage_Enums";
            this.tabPage_Enums.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Enums.Size = new System.Drawing.Size(716, 424);
            this.tabPage_Enums.TabIndex = 0;
            this.tabPage_Enums.Text = "Enums";
            this.tabPage_Enums.UseVisualStyleBackColor = true;
            // 
            // tabPage_Classes
            // 
            this.tabPage_Classes.Controls.Add(this.tableLayoutPanel2);
            this.tabPage_Classes.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Classes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Classes.Name = "tabPage_Classes";
            this.tabPage_Classes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Classes.Size = new System.Drawing.Size(716, 424);
            this.tabPage_Classes.TabIndex = 1;
            this.tabPage_Classes.Text = "Classes";
            this.tabPage_Classes.UseVisualStyleBackColor = true;
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
            this.moviesControl2.Location = new System.Drawing.Point(367, 5);
            this.moviesControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.moviesControl2.Name = "moviesControl2";
            this.moviesControl2.Size = new System.Drawing.Size(329, 247);
            this.moviesControl2.TabIndex = 0;
            // 
            // rectangleControl2
            // 
            this.rectangleControl2.Location = new System.Drawing.Point(4, 5);
            this.rectangleControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rectangleControl2.Name = "rectangleControl2";
            this.rectangleControl2.Size = new System.Drawing.Size(355, 313);
            this.rectangleControl2.TabIndex = 1;
            // 
            // tabPage_Rectangles
            // 
            this.tabPage_Rectangles.Controls.Add(this.rectanglesCollisionControl1);
            this.tabPage_Rectangles.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Rectangles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Rectangles.Name = "tabPage_Rectangles";
            this.tabPage_Rectangles.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Rectangles.Size = new System.Drawing.Size(716, 424);
            this.tabPage_Rectangles.TabIndex = 2;
            this.tabPage_Rectangles.Text = "Rectangles";
            this.tabPage_Rectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(2, 4);
            this.rectanglesCollisionControl1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(735, 390);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(716, 424);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.enumerationsControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(712, 420);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.weekdayParsingControl1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.seasonHandleControl1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 212);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(708, 206);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayParsingControl1.Location = new System.Drawing.Point(1, 1);
            this.weekdayParsingControl1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(352, 204);
            this.weekdayParsingControl1.TabIndex = 0;
            // 
            // seasonHandleControl1
            // 
            this.seasonHandleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonHandleControl1.Location = new System.Drawing.Point(355, 1);
            this.seasonHandleControl1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.seasonHandleControl1.Name = "seasonHandleControl1";
            this.seasonHandleControl1.Size = new System.Drawing.Size(352, 204);
            this.seasonHandleControl1.TabIndex = 1;
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.enumerationsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumerationsControl1.Location = new System.Drawing.Point(1, 1);
            this.enumerationsControl1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(710, 208);
            this.enumerationsControl1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.enumerationsControl2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(712, 420);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.weekdayParsingControl2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.seasonHandleControl2, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 213);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(706, 204);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // enumerationsControl2
            // 
            this.enumerationsControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumerationsControl2.Location = new System.Drawing.Point(2, 2);
            this.enumerationsControl2.Margin = new System.Windows.Forms.Padding(2);
            this.enumerationsControl2.Name = "enumerationsControl2";
            this.enumerationsControl2.Size = new System.Drawing.Size(708, 206);
            this.enumerationsControl2.TabIndex = 1;
            // 
            // weekdayParsingControl2
            // 
            this.weekdayParsingControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayParsingControl2.Location = new System.Drawing.Point(2, 2);
            this.weekdayParsingControl2.Margin = new System.Windows.Forms.Padding(2);
            this.weekdayParsingControl2.Name = "weekdayParsingControl2";
            this.weekdayParsingControl2.Size = new System.Drawing.Size(349, 200);
            this.weekdayParsingControl2.TabIndex = 0;
            // 
            // seasonHandleControl2
            // 
            this.seasonHandleControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonHandleControl2.Location = new System.Drawing.Point(355, 2);
            this.seasonHandleControl2.Margin = new System.Windows.Forms.Padding(2);
            this.seasonHandleControl2.Name = "seasonHandleControl2";
            this.seasonHandleControl2.Size = new System.Drawing.Size(349, 200);
            this.seasonHandleControl2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.tabControl_Enums);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabControl_Enums.ResumeLayout(false);
            this.tabPage_Enums.ResumeLayout(false);
            this.tabPage_Classes.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPage_Rectangles.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl_Enums;
        private System.Windows.Forms.TabPage tabPage_Enums;
        private System.Windows.Forms.TabPage tabPage_Classes;
        private System.Windows.Forms.TabPage tabPage_Rectangles;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private View.Panels.MoviesControl moviesControl2;
        private View.Panels.RectangleControl rectangleControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.SeasonHandleControl seasonHandleControl1;
        private View.Panels.EnumerationsControl enumerationsControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private View.Panels.WeekdayParsingControl weekdayParsingControl2;
        private View.Panels.SeasonHandleControl seasonHandleControl2;
        private View.Panels.EnumerationsControl enumerationsControl2;
    }
}

