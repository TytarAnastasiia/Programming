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
            this.FlightsListBox = new System.Windows.Forms.ListBox();
            this.SelectedFlightInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox_flightType = new System.Windows.Forms.ComboBox();
            this.textBox_flightDuration = new System.Windows.Forms.TextBox();
            this.dateTimePicker_departureTime = new System.Windows.Forms.DateTimePicker();
            this.FlightTypeLabel = new System.Windows.Forms.Label();
            this.FlightDurationLabel = new System.Windows.Forms.Label();
            this.DepartureTimeLabel = new System.Windows.Forms.Label();
            this.DestinationPointLabel = new System.Windows.Forms.Label();
            this.DeparturePointLabel = new System.Windows.Forms.Label();
            this.textBox_destinationPoint = new System.Windows.Forms.TextBox();
            this.textBox_departurePoint = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SelectedFlightInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlightsListBox
            // 
            this.FlightsListBox.FormattingEnabled = true;
            this.FlightsListBox.Location = new System.Drawing.Point(21, 27);
            this.FlightsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlightsListBox.Name = "FlightsListBox";
            this.FlightsListBox.Size = new System.Drawing.Size(235, 225);
            this.FlightsListBox.TabIndex = 0;
            this.FlightsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox_flights_SelectedIndexChanged);
            // 
            // SelectedFlightInfoGroupBox
            // 
            this.SelectedFlightInfoGroupBox.Controls.Add(this.comboBox_flightType);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.textBox_flightDuration);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.dateTimePicker_departureTime);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.FlightTypeLabel);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.FlightDurationLabel);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.DepartureTimeLabel);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.DestinationPointLabel);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.DeparturePointLabel);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.textBox_destinationPoint);
            this.SelectedFlightInfoGroupBox.Controls.Add(this.textBox_departurePoint);
            this.SelectedFlightInfoGroupBox.Location = new System.Drawing.Point(260, 27);
            this.SelectedFlightInfoGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectedFlightInfoGroupBox.Name = "SelectedFlightInfoGroupBox";
            this.SelectedFlightInfoGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectedFlightInfoGroupBox.Size = new System.Drawing.Size(243, 176);
            this.SelectedFlightInfoGroupBox.TabIndex = 1;
            this.SelectedFlightInfoGroupBox.TabStop = false;
            this.SelectedFlightInfoGroupBox.Text = "Selected Flight";
            // 
            // comboBox_flightType
            // 
            this.comboBox_flightType.FormattingEnabled = true;
            this.comboBox_flightType.Location = new System.Drawing.Point(96, 125);
            this.comboBox_flightType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_flightType.Name = "comboBox_flightType";
            this.comboBox_flightType.Size = new System.Drawing.Size(131, 21);
            this.comboBox_flightType.TabIndex = 9;
            this.comboBox_flightType.SelectedIndexChanged += new System.EventHandler(this.comboBox_flightType_SelectedIndexChanged);
            // 
            // textBox_flightDuration
            // 
            this.textBox_flightDuration.Location = new System.Drawing.Point(96, 105);
            this.textBox_flightDuration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_flightDuration.Name = "textBox_flightDuration";
            this.textBox_flightDuration.Size = new System.Drawing.Size(131, 20);
            this.textBox_flightDuration.TabIndex = 8;
            this.textBox_flightDuration.TextChanged += new System.EventHandler(this.textBox_flightDuration_TextChanged);
            this.textBox_flightDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_departurePoint_KeyPress);
            // 
            // dateTimePicker_departureTime
            // 
            this.dateTimePicker_departureTime.CustomFormat = "d.MM.yyyy HH:mm";
            this.dateTimePicker_departureTime.Location = new System.Drawing.Point(96, 84);
            this.dateTimePicker_departureTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_departureTime.Name = "dateTimePicker_departureTime";
            this.dateTimePicker_departureTime.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker_departureTime.TabIndex = 7;
            this.dateTimePicker_departureTime.ValueChanged += new System.EventHandler(this.dateTimePicker_departureTime_ValueChanged);
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
            // textBox_destinationPoint
            // 
            this.textBox_destinationPoint.Location = new System.Drawing.Point(96, 63);
            this.textBox_destinationPoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_destinationPoint.Name = "textBox_destinationPoint";
            this.textBox_destinationPoint.Size = new System.Drawing.Size(131, 20);
            this.textBox_destinationPoint.TabIndex = 1;
            this.textBox_destinationPoint.TextChanged += new System.EventHandler(this.textBox_destinationPoint_TextChanged);
            this.textBox_destinationPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_departurePoint_KeyPress);
            // 
            // textBox_departurePoint
            // 
            this.textBox_departurePoint.Location = new System.Drawing.Point(96, 42);
            this.textBox_departurePoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_departurePoint.Name = "textBox_departurePoint";
            this.textBox_departurePoint.Size = new System.Drawing.Size(131, 20);
            this.textBox_departurePoint.TabIndex = 0;
            this.textBox_departurePoint.TextChanged += new System.EventHandler(this.textBox_departurePoint_TextChanged);
            this.textBox_departurePoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_departurePoint_KeyPress);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(21, 256);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 19);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button_add_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(129, 256);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 19);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(75, 256);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 19);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(260, 207);
            this.OkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(50, 19);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // FlightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FlightsListBox);
            this.Controls.Add(this.SelectedFlightInfoGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FlightControl";
            this.Size = new System.Drawing.Size(524, 305);
            this.Load += new System.EventHandler(this.FlightControl_Load);
            this.SelectedFlightInfoGroupBox.ResumeLayout(false);
            this.SelectedFlightInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FlightsListBox;
        private System.Windows.Forms.GroupBox SelectedFlightInfoGroupBox;
        private System.Windows.Forms.Label DestinationPointLabel;
        private System.Windows.Forms.Label DeparturePointLabel;
        private System.Windows.Forms.TextBox textBox_destinationPoint;
        private System.Windows.Forms.TextBox textBox_departurePoint;
        private System.Windows.Forms.DateTimePicker dateTimePicker_departureTime;
        private System.Windows.Forms.Label FlightTypeLabel;
        private System.Windows.Forms.Label FlightDurationLabel;
        private System.Windows.Forms.Label DepartureTimeLabel;
        private System.Windows.Forms.ComboBox comboBox_flightType;
        private System.Windows.Forms.TextBox textBox_flightDuration;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button OkButton;
    }
}
