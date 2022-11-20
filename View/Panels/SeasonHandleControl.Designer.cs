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
            this.label_chooseSeason = new System.Windows.Forms.Label();
            this.button_go = new System.Windows.Forms.Button();
            this.comboBox_seasons = new System.Windows.Forms.ComboBox();
            this.label_SeasonHandle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_chooseSeason
            // 
            this.label_chooseSeason.AutoSize = true;
            this.label_chooseSeason.Location = new System.Drawing.Point(92, 104);
            this.label_chooseSeason.Name = "label_chooseSeason";
            this.label_chooseSeason.Size = new System.Drawing.Size(124, 20);
            this.label_chooseSeason.TabIndex = 5;
            this.label_chooseSeason.Text = "Choose season:";
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(325, 127);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(75, 36);
            this.button_go.TabIndex = 4;
            this.button_go.Text = "Go!";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // comboBox_seasons
            // 
            this.comboBox_seasons.FormattingEnabled = true;
            this.comboBox_seasons.Location = new System.Drawing.Point(96, 132);
            this.comboBox_seasons.Name = "comboBox_seasons";
            this.comboBox_seasons.Size = new System.Drawing.Size(192, 28);
            this.comboBox_seasons.TabIndex = 3;
            // 
            // label_SeasonHandle
            // 
            this.label_SeasonHandle.AutoSize = true;
            this.label_SeasonHandle.Location = new System.Drawing.Point(3, 0);
            this.label_SeasonHandle.Name = "label_SeasonHandle";
            this.label_SeasonHandle.Size = new System.Drawing.Size(119, 20);
            this.label_SeasonHandle.TabIndex = 6;
            this.label_SeasonHandle.Text = "Season Handle";
            // 
            // SeasonHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_SeasonHandle);
            this.Controls.Add(this.label_chooseSeason);
            this.Controls.Add(this.button_go);
            this.Controls.Add(this.comboBox_seasons);
            this.Name = "SeasonHandleControl";
            this.Size = new System.Drawing.Size(592, 347);
            this.Load += new System.EventHandler(this.SeasonHandleControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_chooseSeason;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.ComboBox comboBox_seasons;
        private System.Windows.Forms.Label label_SeasonHandle;
    }
}
