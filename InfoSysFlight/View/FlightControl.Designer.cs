namespace InfoSysFlight.View
{
    partial class FlightControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FlightPanel = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FlightsListBox = new System.Windows.Forms.ListBox();
            this.SelectedFlightInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.FlightTypeComboBox = new System.Windows.Forms.ComboBox();
            this.FlightDurationTextBox = new System.Windows.Forms.TextBox();
            this.DepartureTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FlightTypeLabel = new System.Windows.Forms.Label();
            this.FlightDurationLabel = new System.Windows.Forms.Label();
            this.DepartureTimeLabel = new System.Windows.Forms.Label();
            this.DestinationPointLabel = new System.Windows.Forms.Label();
            this.DeparturePointLabel = new System.Windows.Forms.Label();
            this.DestinationPointTextBox = new System.Windows.Forms.TextBox();
            this.DeparturePointTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.FlightPanel.SuspendLayout();
            this.SelectedFlightInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.FlightPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 305);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FlightPanel
            // 
            this.FlightPanel.Controls.Add(this.OkButton);
            this.FlightPanel.Controls.Add(this.EditButton);
            this.FlightPanel.Controls.Add(this.DeleteButton);
            this.FlightPanel.Controls.Add(this.AddButton);
            this.FlightPanel.Controls.Add(this.FlightsListBox);
            this.FlightPanel.Controls.Add(this.SelectedFlightInfoGroupBox);
            this.FlightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlightPanel.Location = new System.Drawing.Point(3, 3);
            this.FlightPanel.Name = "FlightPanel";
            this.FlightPanel.Size = new System.Drawing.Size(518, 299);
            this.FlightPanel.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Image = ((System.Drawing.Image)(resources.GetObject("OkButton.Image")));
            this.OkButton.Location = new System.Drawing.Point(262, 203);
            this.OkButton.Margin = new System.Windows.Forms.Padding(2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(78, 45);
            this.OkButton.TabIndex = 17;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Location = new System.Drawing.Point(98, 252);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(78, 45);
            this.EditButton.TabIndex = 16;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(180, 252);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(78, 45);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(16, 252);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(78, 45);
            this.AddButton.TabIndex = 14;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FlightsListBox
            // 
            this.FlightsListBox.FormattingEnabled = true;
            this.FlightsListBox.Location = new System.Drawing.Point(16, 23);
            this.FlightsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.FlightsListBox.Name = "FlightsListBox";
            this.FlightsListBox.Size = new System.Drawing.Size(242, 225);
            this.FlightsListBox.TabIndex = 12;
            // 
            // SelectedFlightInfoGroupBox
            // 
            this.SelectedFlightInfoGroupBox.Controls.Add(this.FlightTypeComboBox);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.FlightDurationTextBox);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.DepartureTimeDateTimePicker);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.FlightTypeLabel);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.FlightDurationLabel);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.DepartureTimeLabel);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.DestinationPointLabel);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.DeparturePointLabel);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.DestinationPointTextBox);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.DeparturePointTextBox);
            this.SelectedFlightInfoGroupBox.Location = new System.Drawing.Point(262, 23);
            this.SelectedFlightInfoGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SelectedFlightInfoGroupBox.Name = "SelectedFlightInfoGroupBox";
            this.SelectedFlightInfoGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SelectedFlightInfoGroupBox.Size = new System.Drawing.Size(238, 176);
            this.SelectedFlightInfoGroupBox.TabIndex = 13;
            this.SelectedFlightInfoGroupBox.TabStop = false;
            this.SelectedFlightInfoGroupBox.Text = "Selected Flight";
            // 
            // FlightTypeComboBox
            // 
            this.FlightTypeComboBox.FormattingEnabled = true;
            this.FlightTypeComboBox.Location = new System.Drawing.Point(96, 125);
            this.FlightTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FlightTypeComboBox.Name = "FlightTypeComboBox";
            this.FlightTypeComboBox.Size = new System.Drawing.Size(131, 21);
            this.FlightTypeComboBox.TabIndex = 9;
            // 
            // FlightDurationTextBox
            // 
            this.FlightDurationTextBox.Location = new System.Drawing.Point(96, 105);
            this.FlightDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FlightDurationTextBox.Name = "FlightDurationTextBox";
            this.FlightDurationTextBox.Size = new System.Drawing.Size(131, 20);
            this.FlightDurationTextBox.TabIndex = 8;
            // 
            // DepartureTimeDateTimePicker
            // 
            this.DepartureTimeDateTimePicker.CustomFormat = "d.MM.yyyy HH:mm";
            this.DepartureTimeDateTimePicker.Location = new System.Drawing.Point(96, 84);
            this.DepartureTimeDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DepartureTimeDateTimePicker.Name = "DepartureTimeDateTimePicker";
            this.DepartureTimeDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.DepartureTimeDateTimePicker.TabIndex = 7;
            // 
            // FlightTypeLabel
            // 
            this.FlightTypeLabel.AutoSize = true;
            this.FlightTypeLabel.Location = new System.Drawing.Point(35, 131);
            this.FlightTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FlightTypeLabel.Name = "FlightTypeLabel";
            this.FlightTypeLabel.Size = new System.Drawing.Size(58, 13);
            this.FlightTypeLabel.TabIndex = 6;
            this.FlightTypeLabel.Text = "Flight type:";
            // 
            // FlightDurationLabel
            // 
            this.FlightDurationLabel.AutoSize = true;
            this.FlightDurationLabel.Location = new System.Drawing.Point(16, 109);
            this.FlightDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FlightDurationLabel.Name = "FlightDurationLabel";
            this.FlightDurationLabel.Size = new System.Drawing.Size(76, 13);
            this.FlightDurationLabel.TabIndex = 5;
            this.FlightDurationLabel.Text = "Flight duration:";
            // 
            // DepartureTimeLabel
            // 
            this.DepartureTimeLabel.AutoSize = true;
            this.DepartureTimeLabel.Location = new System.Drawing.Point(13, 87);
            this.DepartureTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DepartureTimeLabel.Name = "DepartureTimeLabel";
            this.DepartureTimeLabel.Size = new System.Drawing.Size(79, 13);
            this.DepartureTimeLabel.TabIndex = 4;
            this.DepartureTimeLabel.Text = "Departure time:";
            // 
            // DestinationPointLabel
            // 
            this.DestinationPointLabel.AutoSize = true;
            this.DestinationPointLabel.Location = new System.Drawing.Point(3, 67);
            this.DestinationPointLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DestinationPointLabel.Name = "DestinationPointLabel";
            this.DestinationPointLabel.Size = new System.Drawing.Size(89, 13);
            this.DestinationPointLabel.TabIndex = 3;
            this.DestinationPointLabel.Text = "Destination point:";
            // 
            // DeparturePointLabel
            // 
            this.DeparturePointLabel.AutoSize = true;
            this.DeparturePointLabel.Location = new System.Drawing.Point(9, 46);
            this.DeparturePointLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeparturePointLabel.Name = "DeparturePointLabel";
            this.DeparturePointLabel.Size = new System.Drawing.Size(83, 13);
            this.DeparturePointLabel.TabIndex = 2;
            this.DeparturePointLabel.Text = "Departure point:";
            // 
            // DestinationPointTextBox
            // 
            this.DestinationPointTextBox.Location = new System.Drawing.Point(96, 63);
            this.DestinationPointTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DestinationPointTextBox.Name = "DestinationPointTextBox";
            this.DestinationPointTextBox.Size = new System.Drawing.Size(131, 20);
            this.DestinationPointTextBox.TabIndex = 1;
            // 
            // DeparturePointTextBox
            // 
            this.DeparturePointTextBox.Location = new System.Drawing.Point(96, 42);
            this.DeparturePointTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DeparturePointTextBox.Name = "DeparturePointTextBox";
            this.DeparturePointTextBox.Size = new System.Drawing.Size(131, 20);
            this.DeparturePointTextBox.TabIndex = 0;
            // 
            // FlightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FlightControl";
            this.Size = new System.Drawing.Size(524, 305);
            this.Load += new System.EventHandler(this.FlightControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.FlightPanel.ResumeLayout(false);
            this.SelectedFlightInfoGroupBox.ResumeLayout(false);
            this.SelectedFlightInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel FlightPanel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox FlightsListBox;
        private System.Windows.Forms.GroupBox SelectedFlightInfoGroupBox;
        private System.Windows.Forms.ComboBox FlightTypeComboBox;
        private System.Windows.Forms.TextBox FlightDurationTextBox;
        private System.Windows.Forms.DateTimePicker DepartureTimeDateTimePicker;
        private System.Windows.Forms.Label FlightTypeLabel;
        private System.Windows.Forms.Label FlightDurationLabel;
        private System.Windows.Forms.Label DepartureTimeLabel;
        private System.Windows.Forms.Label DestinationPointLabel;
        private System.Windows.Forms.Label DeparturePointLabel;
        private System.Windows.Forms.TextBox DestinationPointTextBox;
        private System.Windows.Forms.TextBox DeparturePointTextBox;
    }
}
