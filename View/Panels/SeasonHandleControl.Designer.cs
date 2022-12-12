namespace Programming.View.Panels
{
    partial class SeasonHandleControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.label_chooseSeason = new System.Windows.Forms.Label();
            this.button_go = new System.Windows.Forms.Button();
            this.comboBox_seasons = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 226);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SeasonHandleGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 220);
            this.panel1.TabIndex = 0;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.label_chooseSeason);
            this.SeasonHandleGroupBox.Controls.Add(this.button_go);
            this.SeasonHandleGroupBox.Controls.Add(this.comboBox_seasons);
            this.SeasonHandleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(389, 220);
            this.SeasonHandleGroupBox.TabIndex = 0;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // label_chooseSeason
            // 
            this.label_chooseSeason.AutoSize = true;
            this.label_chooseSeason.Location = new System.Drawing.Point(39, 78);
            this.label_chooseSeason.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_chooseSeason.Name = "label_chooseSeason";
            this.label_chooseSeason.Size = new System.Drawing.Size(83, 13);
            this.label_chooseSeason.TabIndex = 13;
            this.label_chooseSeason.Text = "Choose season:";
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(242, 93);
            this.button_go.Margin = new System.Windows.Forms.Padding(2);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(50, 21);
            this.button_go.TabIndex = 12;
            this.button_go.Text = "Go!";
            this.button_go.UseVisualStyleBackColor = true;
            // 
            // comboBox_seasons
            // 
            this.comboBox_seasons.FormattingEnabled = true;
            this.comboBox_seasons.Location = new System.Drawing.Point(42, 93);
            this.comboBox_seasons.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_seasons.Name = "comboBox_seasons";
            this.comboBox_seasons.Size = new System.Drawing.Size(196, 21);
            this.comboBox_seasons.TabIndex = 11;
            // 
            // SeasonHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SeasonHandleControl";
            this.Size = new System.Drawing.Size(395, 226);
            this.Load += new System.EventHandler(this.SeasonHandleControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.Label label_chooseSeason;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.ComboBox comboBox_seasons;
    }
}
