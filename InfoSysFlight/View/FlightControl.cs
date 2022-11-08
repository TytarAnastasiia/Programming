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

        List <Flight> _flightList;
        Flight _currentFlight;
        bool isEditClicked;
        bool isAddClicked;
        FlightType ftype;

        public FlightControl()
        {
            InitializeComponent();
            dateTimePicker_departureTime.MinDate = DateTime.Now;
            dateTimePicker_departureTime.MaxDate = new DateTime(DateTime.Now.Year+1, DateTime.Now.Month,
                DateTime.Now.Day);
            dateTimePicker_departureTime.Format = DateTimePickerFormat.Custom;
            foreach (var value in Enum.GetValues(typeof(FlightType)))
            {
                comboBox_flightType.Items.Add(value);
            }
            button_ok.Visible = false;
        }
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            } finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return result;
        }

        public void ReadFlightsFromFile(string filePath)
        {
            try
            {
                string result = ReadAllFile(filePath);
                string[] flightArr = result.Split("\n".ToCharArray());
                for (int i = 0; i < flightArr.Length; i++)
                {
                    if (flightArr[i].Length == 0) break;
                    try 
                    {
                        Flight f = ParseFlight(flightArr[i]);
                        _flightList.Add(f);
                        listBox_flights.Items.Add(f.FlightToString());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("ERROR! " + e.ToString());
                        MessageBox.Show(e.Message);
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR! " + e.ToString());
                MessageBox.Show(e.Message);
            }
        }

        private Flight ParseFlight(string s)
        {
            string[] w = s.Split(';');
            if (w.Length < 4)
            {
                throw new ArgumentException("Некорректная стока полета '" + s + "'");
            }
            try
            {
                DateTime date = Convert.ToDateTime(w[2]);
                int duration = Convert.ToInt32(w[3]);
                if (!Enum.TryParse(w[4], out FlightType flightType))
                {
                    throw new ArgumentException("Неправильный тип перелёта '" + w[4] + "'");
                }
                return new Flight(w[0], w[1], date, duration, flightType);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Неправильная дата '" + w[2] +"' или продолжительность '" + w[3] + "'",e);
            }
        }

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
            isEditClicked = false;
            isAddClicked = false;
            if (File.Exists(FILE_NAME))
            {
                ReadFlightsFromFile(FILE_NAME);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            isEditClicked = false;
            
            CreateFlight();
            isAddClicked = true;
            button_ok.Visible = true;
        }
        private void CreateFlight ()
        {
            _currentFlight = new Flight();
            _flightList.Add(_currentFlight);
            listBox_flights.SelectedIndex = listBox_flights.Items.Add(_currentFlight.FlightToString());
        }

        private void textBox_departurePoint_TextChanged(object sender, EventArgs e)
        {
            if (_currentFlight != null)
            {
                textBox_departurePoint.BackColor = AppColors.StandartColor;
                try
                {
                    Validator.AssertOnValidText(textBox_departurePoint.Text);
                    Validator.AssertOnValidLength(textBox_departurePoint.Text);
                }
                catch (Exception ex)
                {
                    textBox_departurePoint.BackColor = AppColors.ColorOfError;
                    ToolTip tt = new ToolTip();
                    tt.Show(ex.Message, textBox_departurePoint, 3000); 
                }
            }

        }

        private void textBox_destinationPoint_TextChanged(object sender, EventArgs e)
        {
            if (_currentFlight != null)
            {
                textBox_destinationPoint.BackColor = AppColors.StandartColor;
                try
                {
                    Validator.AssertOnValidText(textBox_destinationPoint.Text);
                    Validator.AssertOnValidLength(textBox_destinationPoint.Text);
                }
                catch (Exception ex)
                {
                    textBox_destinationPoint.BackColor = AppColors.ColorOfError;
                    ToolTip tt = new ToolTip();
                    tt.Show(ex.Message, textBox_departurePoint, 3000);
                }
            }
        }

        private void textBox_flightDuration_TextChanged(object sender, EventArgs e)
        {
            if (_currentFlight != null)
            {
                textBox_flightDuration.BackColor = AppColors.StandartColor;
                try
                {
                    Validator.AssertOnIsNumber(textBox_flightDuration.Text);
                }
                catch (Exception ex)
                {
                    textBox_flightDuration.BackColor = AppColors.ColorOfError;
                    ToolTip tt = new ToolTip();
                    tt.Show(ex.Message, textBox_departurePoint, 3000);
                }
            }
        }

        private void comboBox_flightType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentFlight != null)
            {
                if (comboBox_flightType.SelectedIndex != -1)
                {
                    ftype = (FlightType)comboBox_flightType.SelectedItem;
                }
            }
        }

        private void listBox_flights_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_flights.SelectedIndex != -1)
            {
                _currentFlight = _flightList[listBox_flights.SelectedIndex];
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
                    Validator.AssertOnValidDate(dateTimePicker_departureTime.Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR! '" + ex.ToString() + "' " + ex.StackTrace);
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void CleanControls ()
        {
            textBox_departurePoint.Text = "";
            textBox_destinationPoint.Text = "";
            textBox_flightDuration.Text = "";
            comboBox_flightType.SelectedIndex = -1;
        }
        private void ShowFlightInfo ()
        {
            if (_currentFlight != null)
            {
                textBox_departurePoint.Text = _currentFlight.DeparturePoint;
                textBox_destinationPoint.Text = _currentFlight.DestinationPoint;
                textBox_flightDuration.Text = _currentFlight.FlightDuration.ToString();
                comboBox_flightType.SelectedItem = _currentFlight.TypeOfFlight;
                if (_currentFlight.DepartureTime >= dateTimePicker_departureTime.MinDate)
                    dateTimePicker_departureTime.Value = _currentFlight.DepartureTime; 
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int flightIndex = listBox_flights.SelectedIndex;
            isEditClicked = false;
            isAddClicked = false;
            button_ok.Visible = false;

            if (flightIndex != -1)
            {
                _flightList.RemoveAt(flightIndex);
                listBox_flights.Items.RemoveAt(flightIndex);
                listBox_flights.SelectedIndex = -1;
                CleanControls();
            }
            else
            {
                MessageBox.Show("Не выбран объект для удаления");
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (listBox_flights.SelectedIndex != -1)
                isEditClicked = true;
            else
                MessageBox.Show("Не выбран объект для редактирования");
            button_ok.Visible = isEditClicked;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (isEditClicked || isAddClicked)
            {
                if (_currentFlight != null)
                {
                    try
                    {
                        _currentFlight.DeparturePoint = textBox_departurePoint.Text;
                        _currentFlight.DestinationPoint = textBox_destinationPoint.Text;
                        _currentFlight.DepartureTime = dateTimePicker_departureTime.Value;
                        _currentFlight.FlightDuration = Convert.ToInt32(textBox_flightDuration.Text);
                        _currentFlight.TypeOfFlight = ftype;
                        SortFlight();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Невозможно сохранить с неправильным значением. " + ex.Message);
                    }
                }
            }
            isEditClicked = false;
            isAddClicked = false;
            button_ok.Visible = false;
        }

        private void textBox_departurePoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((isEditClicked || isAddClicked))
            {
                return;
            }
            e.Handled = true;//блокирует ввод символов вне режима редакции и добавления
        }

        private void SortFlight()
        {
            _flightList = _flightList.OrderBy(f => f.DepartureTime).ToList();
            listBox_flights.Items.Clear();
            for(int i = 0; i < _flightList.Count; i++)
            {
                listBox_flights.Items.Add(_flightList[i].FlightToString());
            }
        }
    }
}
