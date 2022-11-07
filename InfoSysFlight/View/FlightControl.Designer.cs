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
            this.listBox_flights = new System.Windows.Forms.ListBox();
            this.groupBox_salectedFlightInfo = new System.Windows.Forms.GroupBox();
            this.comboBox_flightType = new System.Windows.Forms.ComboBox();
            this.textBox_flightDuration = new System.Windows.Forms.TextBox();
            this.dateTimePicker_departureTime = new System.Windows.Forms.DateTimePicker();
            this.label_flightType = new System.Windows.Forms.Label();
            this.label_flightDuration = new System.Windows.Forms.Label();
            this.label_departureTime = new System.Windows.Forms.Label();
            this.label_destinationPoint = new System.Windows.Forms.Label();
            this.label_departurePoint = new System.Windows.Forms.Label();
            this.textBox_destinationPoint = new System.Windows.Forms.TextBox();
            this.textBox_departurePoint = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.groupBox_salectedFlightInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_flights
            // 
            this.listBox_flights.FormattingEnabled = true;
            this.listBox_flights.ItemHeight = 20;
            this.listBox_flights.Location = new System.Drawing.Point(32, 41);
            this.listBox_flights.Name = "listBox_flights";
            this.listBox_flights.Size = new System.Drawing.Size(351, 344);
            this.listBox_flights.TabIndex = 0;
            this.listBox_flights.SelectedIndexChanged += new System.EventHandler(this.listBox_flights_SelectedIndexChanged);
            // 
            // groupBox_salectedFlightInfo
            // 
            this.groupBox_salectedFlightInfo.Controls.Add(this.comboBox_flightType);
            this.groupBox_salectedFlightInfo.Controls.Add(this.textBox_flightDuration);
            this.groupBox_salectedFlightInfo.Controls.Add(this.dateTimePicker_departureTime);
            this.groupBox_salectedFlightInfo.Controls.Add(this.label_flightType);
            this.groupBox_salectedFlightInfo.Controls.Add(this.label_flightDuration);
            this.groupBox_salectedFlightInfo.Controls.Add(this.label_departureTime);
            this.groupBox_salectedFlightInfo.Controls.Add(this.label_destinationPoint);
            this.groupBox_salectedFlightInfo.Controls.Add(this.label_departurePoint);
            this.groupBox_salectedFlightInfo.Controls.Add(this.textBox_destinationPoint);
            this.groupBox_salectedFlightInfo.Controls.Add(this.textBox_departurePoint);
            this.groupBox_salectedFlightInfo.Location = new System.Drawing.Point(401, 41);
            this.groupBox_salectedFlightInfo.Name = "groupBox_salectedFlightInfo";
            this.groupBox_salectedFlightInfo.Size = new System.Drawing.Size(365, 270);
            this.groupBox_salectedFlightInfo.TabIndex = 1;
            this.groupBox_salectedFlightInfo.TabStop = false;
            this.groupBox_salectedFlightInfo.Text = "Selected Flight";
            // 
            // comboBox_flightType
            // 
            this.comboBox_flightType.FormattingEnabled = true;
            this.comboBox_flightType.Location = new System.Drawing.Point(144, 193);
            this.comboBox_flightType.Name = "comboBox_flightType";
            this.comboBox_flightType.Size = new System.Drawing.Size(194, 28);
            this.comboBox_flightType.TabIndex = 9;
            this.comboBox_flightType.SelectedIndexChanged += new System.EventHandler(this.comboBox_flightType_SelectedIndexChanged);
            // 
            // textBox_flightDuration
            // 
            this.textBox_flightDuration.Location = new System.Drawing.Point(144, 161);
            this.textBox_flightDuration.Name = "textBox_flightDuration";
            this.textBox_flightDuration.Size = new System.Drawing.Size(194, 26);
            this.textBox_flightDuration.TabIndex = 8;
            this.textBox_flightDuration.TextChanged += new System.EventHandler(this.textBox_flightDuration_TextChanged);
            this.textBox_flightDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_departurePoint_KeyPress);
            // 
            // dateTimePicker_departureTime
            // 
            this.dateTimePicker_departureTime.CustomFormat = "d.MM.yyyy HH:mm";
            this.dateTimePicker_departureTime.Location = new System.Drawing.Point(144, 129);
            this.dateTimePicker_departureTime.Name = "dateTimePicker_departureTime";
            this.dateTimePicker_departureTime.Size = new System.Drawing.Size(194, 26);
            this.dateTimePicker_departureTime.TabIndex = 7;
            this.dateTimePicker_departureTime.ValueChanged += new System.EventHandler(this.dateTimePicker_departureTime_ValueChanged);
            // 
            // label_flightType
            // 
            this.label_flightType.AutoSize = true;
            this.label_flightType.Location = new System.Drawing.Point(52, 201);
            this.label_flightType.Name = "label_flightType";
            this.label_flightType.Size = new System.Drawing.Size(86, 20);
            this.label_flightType.TabIndex = 6;
            this.label_flightType.Text = "Flight type:";
            this.label_flightType.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_flightDuration
            // 
            this.label_flightDuration.AutoSize = true;
            this.label_flightDuration.Location = new System.Drawing.Point(24, 167);
            this.label_flightDuration.Name = "label_flightDuration";
            this.label_flightDuration.Size = new System.Drawing.Size(114, 20);
            this.label_flightDuration.TabIndex = 5;
            this.label_flightDuration.Text = "Flight duration:";
            // 
            // label_departureTime
            // 
            this.label_departureTime.AutoSize = true;
            this.label_departureTime.Location = new System.Drawing.Point(19, 134);
            this.label_departureTime.Name = "label_departureTime";
            this.label_departureTime.Size = new System.Drawing.Size(119, 20);
            this.label_departureTime.TabIndex = 4;
            this.label_departureTime.Text = "Departure time:";
            // 
            // label_destinationPoint
            // 
            this.label_destinationPoint.AutoSize = true;
            this.label_destinationPoint.Location = new System.Drawing.Point(5, 103);
            this.label_destinationPoint.Name = "label_destinationPoint";
            this.label_destinationPoint.Size = new System.Drawing.Size(133, 20);
            this.label_destinationPoint.TabIndex = 3;
            this.label_destinationPoint.Text = "Destination point:";
            this.label_destinationPoint.Click += new System.EventHandler(this.label_destinationPoint_Click);
            // 
            // label_departurePoint
            // 
            this.label_departurePoint.AutoSize = true;
            this.label_departurePoint.Location = new System.Drawing.Point(14, 71);
            this.label_departurePoint.Name = "label_departurePoint";
            this.label_departurePoint.Size = new System.Drawing.Size(124, 20);
            this.label_departurePoint.TabIndex = 2;
            this.label_departurePoint.Text = "Departure point:";
            this.label_departurePoint.Click += new System.EventHandler(this.label_departurePoint_Click);
            // 
            // textBox_destinationPoint
            // 
            this.textBox_destinationPoint.Location = new System.Drawing.Point(144, 97);
            this.textBox_destinationPoint.Name = "textBox_destinationPoint";
            this.textBox_destinationPoint.Size = new System.Drawing.Size(194, 26);
            this.textBox_destinationPoint.TabIndex = 1;
            this.textBox_destinationPoint.TextChanged += new System.EventHandler(this.textBox_destinationPoint_TextChanged);
            this.textBox_destinationPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_departurePoint_KeyPress);
            // 
            // textBox_departurePoint
            // 
            this.textBox_departurePoint.Location = new System.Drawing.Point(144, 65);
            this.textBox_departurePoint.Name = "textBox_departurePoint";
            this.textBox_departurePoint.Size = new System.Drawing.Size(194, 26);
            this.textBox_departurePoint.TabIndex = 0;
            this.textBox_departurePoint.TextChanged += new System.EventHandler(this.textBox_departurePoint_TextChanged);
            this.textBox_departurePoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_departurePoint_KeyPress);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(30, 416);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 29);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(219, 416);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 29);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(124, 416);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 29);
            this.button_edit.TabIndex = 4;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(401, 333);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 29);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // FlightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBox_flights);
            this.Controls.Add(this.groupBox_salectedFlightInfo);
            this.Name = "FlightControl";
            this.Size = new System.Drawing.Size(786, 469);
            this.Load += new System.EventHandler(this.FlightControl_Load);
            this.groupBox_salectedFlightInfo.ResumeLayout(false);
            this.groupBox_salectedFlightInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_flights;
        private System.Windows.Forms.GroupBox groupBox_salectedFlightInfo;
        private System.Windows.Forms.Label label_destinationPoint;
        private System.Windows.Forms.Label label_departurePoint;
        private System.Windows.Forms.TextBox textBox_destinationPoint;
        private System.Windows.Forms.TextBox textBox_departurePoint;
        private System.Windows.Forms.DateTimePicker dateTimePicker_departureTime;
        private System.Windows.Forms.Label label_flightType;
        private System.Windows.Forms.Label label_flightDuration;
        private System.Windows.Forms.Label label_departureTime;
        private System.Windows.Forms.ComboBox comboBox_flightType;
        private System.Windows.Forms.TextBox textBox_flightDuration;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_ok;
    }
}
