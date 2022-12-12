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
        private static string FILE_NAME = "flight.txt";

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
            InitializeComponent();
            DepartureTimeDateTimePicker.MinDate = DateTime.Now;
            DepartureTimeDateTimePicker.MaxDate = new DateTime(DateTime.Now.Year+1, DateTime.Now.Month,
                DateTime.Now.Day);
            DepartureTimeDateTimePicker.Format = DateTimePickerFormat.Custom;
            foreach (var value in Enum.GetValues(typeof(FlightType)))
            {
                FlightTypeComboBox.Items.Add(value);
            }
            OkButton.Visible = false;
        }

        /// <summary>
        /// Считывает все файлы и переводит в кодировку UTF8.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <returns></returns>
        private string ReadAllFile(string filePath)
        {
            string result = null;
            FileStream reader = null;
            try
            {
                reader = File.OpenRead(filePath);
                byte[] buffer = new byte[reader.Length];
                reader.Read(buffer, 0, buffer.Length);
                result = Encoding.UTF8.GetString(buffer);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            } finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return result;
        }

        /// <summary>
        /// Считывает информацию из файла и добавляет в листбокс.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        public void ReadFlightsFromFile(string filePath)
        {
            try
            {
                string result = ReadAllFile(filePath);
                string[] flightArray = result.Split("\n".ToCharArray());
                for (int i = 0; i < flightArray.Length; i++)
                {
                    if (flightArray[i].Length == 0) break;
                    try 
                    {
                        Flight fileFlight = ParseFlight(flightArray[i]);
                        _flightList.Add(fileFlight);
                        FlightsListBox.Items.Add(fileFlight.FlightToString());
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("ERROR! " + exception.ToString());
                        MessageBox.Show(exception.Message);
                    }
                }
                
            }
            catch (Exception exception)
            {
                Console.WriteLine("ERROR! " + exception.ToString());
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Разбивает строку на слова.
        /// </summary>
        /// <param name="flightString">Строка, содержащая информацию о перелёте.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private Flight ParseFlight(string flightString)
        {
            string[] words = flightString.Split(';');
            if (words.Length < 4)
            {
                throw new ArgumentException("Некорректная строка полета '" + flightString + "'");
            }
            try
            {
                DateTime date = Convert.ToDateTime(words[2]);
                int duration = Convert.ToInt32(words[3]);
                if (!Enum.TryParse(words[4], out FlightType flightType))
                {
                    throw new ArgumentException("Неправильный тип перелёта '" + words[4] + "'");
                }
                return new Flight(words[0], words[1], date, duration, flightType);
            }
            catch (Exception exception)
            {
                throw new ArgumentException("Неправильная дата '" + words[2] +"' или продолжительность '" + words[3] + "'",exception);
            }
        }

         /// <summary>
         /// Записывает информацию в файл.
         /// </summary>
        public void WriteFlightsToFile()
        {
            FileStream stream = new FileStream(FILE_NAME, FileMode.Create);
            for (int i = 0; i < _flightList.Count; i++)
            {
                byte[] buffer = Encoding.Default.GetBytes(_flightList[i].AllInfoToString() + "\n");
                stream.Write(buffer, 0, buffer.Length);
            }
            stream.Close();
        }
            
         private void FlightControl_Load(object sender, EventArgs e)
        {
            _flightList = new List<Flight>();
            _isEditClicked = false;
            _isAddClicked = false;
            if (File.Exists(FILE_NAME))
            {
                ReadFlightsFromFile(FILE_NAME);
            }
        }

        /// <summary>
        /// Создаёт новый экземпляр класса Flight.
        /// </summary>
        private void CreateFlight()
        {
            _currentFlight = new Flight();
            _flightList.Add(_currentFlight);
            FlightsListBox.SelectedIndex = 
                FlightsListBox.Items.Add(_currentFlight.FlightToString());
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
            FlightsListBox.Items.Clear();
            for(int i = 0; i < _flightList.Count; i++)
            {
                FlightsListBox.Items.Add(_flightList[i].FlightToString());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _isEditClicked = false;
            CreateFlight();
            _isAddClicked = true;
            OkButton.Visible = true;
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
                CleanControls();
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
            if (_isEditClicked || _isAddClicked)
            {
                if (_currentFlight != null)
                {
                    try
                    {
                        _currentFlight.DeparturePoint = DeparturePointTextBox.Text;
                        _currentFlight.DestinationPoint = DestinationPointTextBox.Text;
                        _currentFlight.DepartureTime = DepartureTimeDateTimePicker.Value;
                        _currentFlight.FlightDuration = Convert.ToInt32(FlightDurationTextBox.Text);
                        _currentFlight.TypeOfFlight = ftype;
                        SortFlight();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Невозможно сохранить с неправильным значением. " + exception.Message);
                    }
                }
            }
            _isEditClicked = false;
            _isAddClicked = false;
            OkButton.Visible = false;
        }
    }
}
