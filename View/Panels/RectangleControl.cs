﻿using Programming.Model;
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
                listBox_Rectangles.Items.Add("Rectangle " + (i + 1));
            }
            listBox_Rectangles.SelectedIndex = 0;
        }

        /// <summary>
        /// Вывод информации о выделенном прямоуголонике.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_Rectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Rectangles.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[listBox_Rectangles.SelectedIndex];
                textBox_Length.Text = Math.Round(_currentRectangle.Length, 2) + "";
                textBox_Width.Text = Math.Round(_currentRectangle.Width, 2) + "";
                textBox_Color.Text = _currentRectangle.Color;
                textBox_center_x.Text = _currentRectangle.Centre.X.ToString();
                textBox_center_y.Text = _currentRectangle.Centre.Y.ToString();
                textBox_id.Text = _currentRectangle.Id.ToString();
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
            listBox_Rectangles.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        /// <summary>
        /// Возможность задавать прямоугольнику длину с обработкой исключений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Length_TextChanged(object sender, EventArgs e)
        {
            textBox_Length.BackColor = AppColors.StandartColor;
            if (textBox_Length.Text != "" && textBox_Length.Text != null)
            {
                try
                {
                    _currentRectangle.Length = Convert.ToDouble(textBox_Length.Text);
                }
                catch (Exception exception)
                {
                    textBox_Length.BackColor = AppColors.NotValidColor;
                    ToolTip tip = new ToolTip();
                    tip.Show(exception.Message, textBox_Length, 3000);
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
            textBox_Width.BackColor = AppColors.StandartColor;
            if (textBox_Width.Text != "" && textBox_Width.Text != null)
            {
                try
                {
                    _currentRectangle.Width = Convert.ToDouble(textBox_Width.Text);
                }
                catch (Exception exception)
                {
                    textBox_Width.BackColor = AppColors.NotValidColor;
                    ToolTip tip = new ToolTip();
                    tip.Show(exception.Message, textBox_Width, 3000);
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
            textBox_Color.BackColor = AppColors.StandartColor;

            try
            {
                _currentRectangle.Color = textBox_Color.Text;
            }
            catch (Exception exception)
            {
                textBox_Color.BackColor = AppColors.NotValidColor;
                ToolTip tip = new ToolTip();
                tip.Show(exception.Message, textBox_Color, 3000);
            }
        }
    }
}
