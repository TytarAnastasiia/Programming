using Programming.Model;
using System;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RectangleControl : UserControl
    {
        private MyRectangle[] _rectangles;

        private MyRectangle _currentRectangle;

        public RectangleControl()
        {
            InitializeComponent();
            _rectangles = new MyRectangle[5];
            Random rand = new Random();
            Colour randColor;
            for (int i = 0; i < _rectangles.Length; i++)
            {
                randColor = (Colour)rand.Next(0, 6);
                _rectangles[i] = new MyRectangle(rand.NextDouble() * 10,
                    rand.NextDouble() * 10, randColor.ToString(),
                new Point2D(rand.Next(0, 1000), rand.Next(0, 1000)));
            }
            _currentRectangle = _rectangles[0];
            for (int i = 0; i < _rectangles.Length; i++)
            {
                RectanglesListBox.Items.Add("Rectangle " + (i + 1));
            }
            RectanglesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Вывод информации о выделенном прямоуголонике.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_Rectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
                LengthTextBox.Text = Math.Round(_currentRectangle.Length, 2) + "";
                WidthTextBox.Text = Math.Round(_currentRectangle.Width, 2) + "";
                ColorTextBox.Text = _currentRectangle.Color;
                CenterXTextBox.Text = _currentRectangle.Centre.X.ToString();
                CenterYTextBox.Text = _currentRectangle.Centre.Y.ToString();
                IdTextBox.Text = _currentRectangle.Id.ToString();
            }
        }
        
        /// <summary>
        /// Метод поиска прямоугольки с максимальной шириной в массиве.
        /// </summary>
        /// <param name="rectangleArray"></param>
        /// <returns></returns>
        private int FindRectangleWithMaxWidth(MyRectangle[] rectangleArray)
        {
            double max = 0;
            int indexOfMax = 0;
            for (int i = 0; i < rectangleArray.Length; i++)
            {
                if (rectangleArray[i].Width > max)
                {
                    max = rectangleArray[i].Width;
                    indexOfMax = i;
                }
            }
            return indexOfMax;
        }

        /// <summary>
        /// Кнопка Find выводит прямоугольник с максимальной шириной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Find_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        /// <summary>
        /// Возможность задавать прямоугольнику длину с обработкой исключений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Length_TextChanged(object sender, EventArgs e)
        {
            LengthTextBox.BackColor = AppColors.StandartColor;
            if (LengthTextBox.Text != "" && LengthTextBox.Text != null)
            {
                try
                {
                    _currentRectangle.Length = Convert.ToDouble(LengthTextBox.Text);
                }
                catch (Exception exception)
                {
                    LengthTextBox.BackColor = AppColors.NotValidColor;
                    ToolTip tip = new ToolTip();
                    tip.Show(exception.Message, LengthTextBox, 3000);
                }
            }
        }

        /// <summary>
        /// Возможность задавать прямоугольнику ширину с обработкой исключений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Width_TextChanged(object sender, EventArgs e)
        {
            WidthTextBox.BackColor = AppColors.StandartColor;
            if (WidthTextBox.Text != "" && WidthTextBox.Text != null)
            {
                try
                {
                    _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
                }
                catch (Exception exception)
                {
                    WidthTextBox.BackColor = AppColors.NotValidColor;
                    ToolTip tip = new ToolTip();
                    tip.Show(exception.Message, WidthTextBox, 3000);
                }
            }
        }

        /// <summary>
        /// Возможность задавать прямоугольнику цвет с обработкой исключений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Color_TextChanged(object sender, EventArgs e)
        {
            ColorTextBox.BackColor = AppColors.StandartColor;

            try
            {
                _currentRectangle.Color = ColorTextBox.Text;
            }
            catch (Exception exception)
            {
                ColorTextBox.BackColor = AppColors.NotValidColor;
                ToolTip tip = new ToolTip();
                tip.Show(exception.Message, ColorTextBox, 3000);
            }
        }
    }
}
