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
        List <Flight> _flightList;
        Flight _currentFlight;
        bool isEditClicked;
        bool isAddClicked;
        //int currentIndex;
        FlightType ftype;
        bool isSelectedType;

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
            try
            {
                FileStream reader = File.OpenRead(filePath);
                byte[] buffer = new byte[reader.Length];
                reader.Read(buffer, 0, buffer.Length);
                result = Encoding.UTF8.GetString(buffer);
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }

        public void ReadFlightsFromFile(string filePath)
        {
            try
            {
                string result = ReadAllFile(filePath);
                string[] flightArr = result.Split("\n".ToCharArray());
                string[] temp = null;
                int duration = 0;
                DateTime date = DateTime.Now;
                FlightType curType;
                for (int i = 0; i < flightArr.Length; i++)
                {
                    temp = flightArr[i].Split(';');
                    try
                    {
                        date = Convert.ToDateTime(temp[2]);
                        
                        duration = Convert.ToInt32(temp[3]);
                        Flight curFlight = null;
                        if (Enum.TryParse(temp[4], out curType))
                            curFlight = new Flight(temp[0], temp[1], date, duration, curType);
                        else MessageBox.Show("Неправильный тип перелёта");
                        if (curFlight != null)
                        {
                            _flightList.Add(curFlight);
                            listBox_flights.Items.Add(curFlight.FlightToString());
                        }

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /*private void WriteStringToFile2(string filePath, string data)
        {
            FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate);
            byte[] buffer = Encoding.Default.GetBytes(data);
            stream.Write(buffer, 0, buffer.Length);
            stream.Close();
        }*/
        public void WriteFlightsToFile(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Create);
            for (int i = 0; i < _flightList.Count; i++)
            {
                byte[] buffer = Encoding.Default.GetBytes(_flightList[i].AllInfoToString() + "\n");
                stream.Write(buffer, 0, buffer.Length);
                //WriteStringToFile2(filePath, _flightList[i].AllInfoToString());
            }
            stream.Close();
        }
            
        /*private int SelectedOrCreatedFlightIndex()
        {
            int index = -1;
            if (listBox_flights.SelectedIndex == -1)
                index = listBox_flights.Items.Count - 1;
            else index = listBox_flights.SelectedIndex;
            return index;
        }*/

        private void label_destinationPoint_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FlightControl_Load(object sender, EventArgs e)
        {
            _flightList = new List<Flight>();
            isEditClicked = false;
            isAddClicked = false;
            //currentIndex = -1;
            isSelectedType = false;
            ReadFlightsFromFile("flight.txt");
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            isEditClicked = false;
            
            //listBox_flights.SelectedIndex = listBox_flights.Items.Count -1;
            /*if (_currentFlight != null)
            {
                if (_currentFlight.IsAllCompleted())
                {
                    CreateFlight();
                    listBox_flights.SelectedIndex = listBox_flights.Items.Count - 1;
                    //isAddClicked = false;
                }
            }*/
            //else
            //{
                CreateFlight();
                listBox_flights.SelectedIndex = listBox_flights.Items.Count - 1;
                MessageBox.Show("add else");
            //}
            isAddClicked = true;
            button_ok.Visible = true;
            /*if (_currentFlight != null)
            {
                
            }
            else
            {
                
            }*/
        }
        private void CreateFlight ()
        {
            _currentFlight = new Flight();
            _flightList.Add(_currentFlight);
            listBox_flights.Items.Add(_currentFlight.DepartureTime + " " + _currentFlight.DeparturePoint
                + " " + _currentFlight.DestinationPoint);
        }

        private void textBox_departurePoint_TextChanged(object sender, EventArgs e)
        {
            if (_currentFlight != null)// && (isAddClicked || isEditClicked)
            {
                textBox_departurePoint.BackColor = AppColors.StandartColor;
                try
                {
                    if (Validator.AssertOnValidText(textBox_departurePoint.Text) &&
                        Validator.AssertOnValidLength(textBox_departurePoint.Text))
                    {
                        /*_currentFlight.DeparturePoint = textBox_departurePoint.Text;
                        //int index = SelectedOrCreatedFlightIndex();////////
                        listBox_flights.Items[listBox_flights.SelectedIndex] = _currentFlight.FlightToString();*/

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    textBox_departurePoint.BackColor = AppColors.ColorOfError;
                }
            }

        }

        private void textBox_destinationPoint_TextChanged(object sender, EventArgs e)
        {
            if (_currentFlight != null) //&& (isAddClicked || isEditClicked))
            {
                textBox_destinationPoint.BackColor = AppColors.StandartColor;
                try
                {
                    if (Validator.AssertOnValidText(textBox_destinationPoint.Text) &&
                        Validator.AssertOnValidLength(textBox_destinationPoint.Text))
                    {
                        /*_currentFlight.DestinationPoint = textBox_destinationPoint.Text;
                        //int index = SelectedOrCreatedFlightIndex();
                        listBox_flights.Items[listBox_flights.SelectedIndex] = _currentFlight.FlightToString();*/

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    textBox_destinationPoint.BackColor = AppColors.ColorOfError;
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
                    if (Validator.AssertOnIsNumber(textBox_flightDuration.Text))
                    {
                        /*_currentFlight.FlightDuration = Convert.ToInt32(textBox_flightDuration.Text);
                        //int index = SelectedOrCreatedFlightIndex();
                        listBox_flights.Items[listBox_flights.SelectedIndex] = _currentFlight.FlightToString();*/

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    textBox_flightDuration.BackColor = AppColors.ColorOfError;
                }
            }
        }

        private void comboBox_flightType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentFlight != null)
            {
                if (comboBox_flightType.SelectedIndex != -1)
                {
                    //if (Enum.TryParse((string)comboBox_flightType.SelectedValue, out ftype))
                        //_currentFlight.TypeOfFlight = ftype;
                    ftype = (FlightType)comboBox_flightType.SelectedItem;
                    //MessageBox.Show(ftype.ToString());
                    isSelectedType = true;
                }
            }
        }

        private void listBox_flights_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //currentIndex = listBox_flights.SelectedIndex;
            if (listBox_flights.SelectedIndex != -1)
            {
                _currentFlight = _flightList[listBox_flights.SelectedIndex];
                ShowFlightInfo();
            }
            else
            {
                //if (listBox_flights.Items.Count == 0)
                    _currentFlight = null;
                //if (listBox_flights.SelectedItem == null)
                //CleanControls();
            }
            //MessageBox.Show("index");

        }

        private void dateTimePicker_departureTime_ValueChanged(object sender, EventArgs e)
        {
            //if (_currentFlight == null)
             //   _currentFlight = new Flight();

            if (_currentFlight != null)
            {
                try
                {
                    if (Validator.AssertOnValidDate(dateTimePicker_departureTime.Value))
                    {
                        /*_currentFlight.DepartureTime = dateTimePicker_departureTime.Value;
                        //int index = SelectedOrCreatedFlightIndex();
                        listBox_flights.Items[listBox_flights.SelectedIndex] = _currentFlight.FlightToString();*/
                    }
                }
                catch (Exception ex)
                {
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
            //MessageBox.Show("cleaned");
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
                MessageBox.Show("" + _flightList.Count);
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
                    //MessageBox.Show(ftype.ToString() + "tf =" + _currentFlight.TypeOfFlight);
                    _currentFlight.DeparturePoint = textBox_departurePoint.Text;
                    //int index = SelectedOrCreatedFlightIndex();////////

                    _currentFlight.DestinationPoint = textBox_destinationPoint.Text;
                    //int index = SelectedOrCreatedFlightIndex();

                    _currentFlight.DepartureTime = dateTimePicker_departureTime.Value;
                    //int index = SelectedOrCreatedFlightIndex();

                    _currentFlight.FlightDuration = Convert.ToInt32(textBox_flightDuration.Text);
                    //int index = SelectedOrCreatedFlightIndex();
                    _currentFlight.TypeOfFlight = ftype;
                    listBox_flights.Items[listBox_flights.SelectedIndex] = _currentFlight.FlightToString();

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

        private void label_departurePoint_Click(object sender, EventArgs e)
        {

        }
    }
}
