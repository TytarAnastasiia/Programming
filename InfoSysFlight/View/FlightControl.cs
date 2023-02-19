using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfoSysFlight.Enums;
using InfoSysFlight.Model;

namespace InfoSysFlight.View
{
    public partial class FlightControl : UserControl
    {
        private static string FILE_NAME = "flights.txt";

        private List <Flight> _flightList;

        private Flight _currentFlight;

        private bool _isEditClicked;

        private bool _isAddClicked;

        FlightType ftype;

        /// <summary>
        /// Инициализация элементов.
        /// </summary>
        public FlightControl()
        {
            _isEditClicked = false;
            _isAddClicked = false;
            InitializeComponent();
            DepartureTimeDateTimePicker.MinDate = DateTime.Now;
            DepartureTimeDateTimePicker.MaxDate = DateTime.Now.AddYears(1);
            DepartureTimeDateTimePicker.Format = DateTimePickerFormat.Custom;
            foreach (var value in Enum.GetValues(typeof(FlightType)))
            {
                FlightTypeComboBox.Items.Add(value);
            }
            OkButton.Visible = false;

 
            _flightList = new List<Flight> { };

        }



         /// <summary>
         /// Записывает информацию в файл.
         /// </summary>
        public void WriteFlightsToFile()
        {
            FlightSerializer.SaveToFile(_flightList, FILE_NAME);
        }
            
         private void FlightControl_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_NAME))
            {
                try 
                {
                    _flightList = FlightSerializer.LoadFromFile(FILE_NAME);
                }
                catch(Exception exception)
                {
                    MessageBox.Show("Ошибка в формате файла ("+exception.Message+"). Файл будет удалён.");
                    File.Delete(FILE_NAME);
                }
               
            }
            if (_flightList == null)
            {
                _flightList = new List<Flight>();
            }
            SortFlight();
        }


        private void textBox_departurePoint_TextChanged(object sender, EventArgs e)
        {
            if (_currentFlight != null)
            {
                DeparturePointTextBox.BackColor = AppColors.StandartColor;
                try
                {
                    Validator.AssertOnValidText(DeparturePointTextBox.Text);
                    Validator.AssertOnValidLength(DeparturePointTextBox.Text);
                }
                catch (Exception exception)
                {
                    DeparturePointTextBox.BackColor = AppColors.ColorOfError;
                    ToolTip tt = new ToolTip();
                    tt.Show(exception.Message, DeparturePointTextBox, 3000); 
                }
            }
        }

        private void textBox_destinationPoint_TextChanged(object sender, EventArgs e)
        {
            if (_currentFlight != null)
            {
                DestinationPointTextBox.BackColor = AppColors.StandartColor;
                try
                {
                    Validator.AssertOnValidText(DestinationPointTextBox.Text);
                    Validator.AssertOnValidLength(DestinationPointTextBox.Text);
                }
                catch (Exception exception)
                {
                    DestinationPointTextBox.BackColor = AppColors.ColorOfError;
                    ToolTip tt = new ToolTip();
                    tt.Show(exception.Message, DeparturePointTextBox, 3000);
                }
            }
        }

        private void textBox_flightDuration_TextChanged(object sender, EventArgs e)
        {
            if (_currentFlight == null)
            {
                return;
            }

            FlightDurationTextBox.BackColor = AppColors.StandartColor;
            try
            {
                Validator.AssertOnIsNumber(FlightDurationTextBox.Text);
            }
            catch (Exception exception)
            {
                FlightDurationTextBox.BackColor = AppColors.ColorOfError;
                ToolTip tt = new ToolTip();
                tt.Show(exception.Message, DeparturePointTextBox, 3000);
            }
        }

        private void comboBox_flightType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentFlight != null)
            {
                if (FlightTypeComboBox.SelectedIndex != -1)
                {
                    ftype = (FlightType)FlightTypeComboBox.SelectedItem;
                }
            }
        }

        private void listBox_flights_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex != -1)
            {
                _currentFlight = _flightList[FlightsListBox.SelectedIndex];
                ShowFlightInfo();
            }
            else
            {
                _currentFlight = null;
            }
        }

        private void dateTimePicker_departureTime_ValueChanged(object sender, EventArgs e)
        {
            if (_currentFlight != null)
            {
                try
                {
                    Validator.AssertOnValidDate(DepartureTimeDateTimePicker.Value);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("ERROR! '" + exception.ToString() + "' " + exception.StackTrace);
                    MessageBox.Show(exception.Message);
                }
            }
        }

        /// <summary>
        /// Очищает поля.
        /// </summary>
        private void CleanControls()
        {
            DeparturePointTextBox.Text = "";
            DestinationPointTextBox.Text = "";
            FlightDurationTextBox.Text = "";
            FlightTypeComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Выводит информацию о выбранном перелёте.
        /// </summary>
        private void ShowFlightInfo ()
        {
            if (_currentFlight != null)
            {
                DeparturePointTextBox.Text = _currentFlight.DeparturePoint;
                DestinationPointTextBox.Text = _currentFlight.DestinationPoint;
                FlightDurationTextBox.Text = _currentFlight.FlightDuration.ToString();
                FlightTypeComboBox.SelectedItem = _currentFlight.TypeOfFlight;
                if (_currentFlight.DepartureTime >= DepartureTimeDateTimePicker.MinDate)
                    DepartureTimeDateTimePicker.Value = _currentFlight.DepartureTime; 
            } 
            else
            {
                CleanControls();
            }
        }

        private void textBox_departurePoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((_isEditClicked || _isAddClicked))
            {
                return;
            }
            e.Handled = true;
        }

        /// <summary>
        /// Сортирует перелёты.
        /// </summary>
        private void SortFlight()
        {
            _flightList = _flightList.OrderBy(f => f.DepartureTime).ToList();
            int currentIndex = _flightList.IndexOf(_currentFlight);
            if (currentIndex < 0)
            {
                currentIndex = 0;
            }
            FlightsListBox.Items.Clear();
            for(int i = 0; i < _flightList.Count; i++)
            {
                FlightsListBox.Items.Add(_flightList[i].FlightToString());
            }
            if (currentIndex >=0 && currentIndex < FlightsListBox.Items.Count)
            {
                FlightsListBox.SelectedIndex = currentIndex;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!_isAddClicked)
            {
                _isEditClicked = false;
                _isAddClicked = true;
                OkButton.Visible = true;
                AddButton.Enabled = false;
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int flightIndex = FlightsListBox.SelectedIndex;
            _isEditClicked = false;
            _isAddClicked = false;
            OkButton.Visible = false;

            if (flightIndex != -1)
            {
                _flightList.RemoveAt(flightIndex);
                FlightsListBox.Items.RemoveAt(flightIndex);
                FlightsListBox.SelectedIndex = -1;
                _currentFlight = null;
                if (_flightList.Count > 0)
                {
                    FlightsListBox.SelectedIndex = 0;
                    _currentFlight = _flightList[FlightsListBox.SelectedIndex];
                }
                ShowFlightInfo();
            }
            else
            {
                MessageBox.Show("Не выбран объект для удаления");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex != -1)
                _isEditClicked = true;
            else
                MessageBox.Show("Не выбран объект для редактирования");
            OkButton.Visible = _isEditClicked;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
//            if (_isEditClicked || _isAddClicked)
//            {
               try
               {
                    if (_isAddClicked)
                    {
                        _currentFlight = newFlight();
                        _flightList.Add(_currentFlight);
                    }
                    else if (_isEditClicked)
                {
                    updateFlight(_currentFlight);
                }
                    SortFlight();
               }
               catch (Exception exception)
               {
                        MessageBox.Show("Невозможно сохранить с неправильным значением. " + exception.Message);
               }
//            }
            _isEditClicked = false;
            _isAddClicked = false;
            OkButton.Visible = false;
            AddButton.Enabled = true;
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        private Flight newFlight()
        {
            return new Flight(DeparturePointTextBox.Text,
                DestinationPointTextBox.Text,
                DepartureTimeDateTimePicker.Value,
                Convert.ToInt32(FlightDurationTextBox.Text),
                ftype
                );
        }
        private Flight updateFlight(Flight flight)
        {
            flight.DeparturePoint = DeparturePointTextBox.Text;
            flight.DestinationPoint = DestinationPointTextBox.Text;
            flight.DepartureTime = DepartureTimeDateTimePicker.Value;
            flight.FlightDuration = Convert.ToInt32(FlightDurationTextBox.Text);
            flight.TypeOfFlight = ftype;
            return flight;
        }

        private void FlightsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(FlightsListBox.SelectedIndex < 0 && _flightList.Count > 0)
            {
                FlightsListBox.SelectedIndex = 0;
            }
            if (FlightsListBox.SelectedIndex >= 0 && FlightsListBox.SelectedIndex < _flightList.Count)
            {
                _currentFlight = _flightList[FlightsListBox.SelectedIndex];
            }
            ShowFlightInfo();
        }
    }
}
