using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Geometry;
using Programming.View;

namespace Programming
{
    public partial class MainForm : Form
    {
        private MyRectangle[] _rectangles;
        private MyRectangle _currentRectangle;
        //private List<MyRectangle> _myRectanglesList;
        //private List<Panel> _rectanglePanels;
        private Movie[] _movies;
        private Movie _currentMovie;
        string[] moviesNames;
        
        /// <summary>
        /// Производит заполнение информации для массивов прямоугольников и фильмов.
        /// </summary>
        public MainForm()
        {
            // Создаёт элемнты управления на форме.
            InitializeComponent();
            _rectangles = new MyRectangle[5];
            //_myRectanglesList = new List<MyRectangle>();
            //_rectanglePanels = new List<Panel>();
            Random rand = new Random();
            Colour randColor;
            for (int i = 0; i < _rectangles.Length; i++)
            {
                randColor = (Colour)rand.Next(0, 6);
                _rectangles[i] = new MyRectangle(rand.NextDouble() * 10,
                    rand.NextDouble() * 10, randColor.ToString(),
                new Point2D(rand.Next(0, 1000), rand.Next(0, 1000)));
            }  
            moviesNames = new string[] {"StarTrek", "Mission Impossible", "Ice Age", "The Matrix", "The Man From U.N.C.L.E."};
            _movies = new Movie[moviesNames.Length];
            Genre randGenre;
            for (int i = 0; i < _movies.Length; i++)
            {
                randGenre = (Genre)rand.Next(0, Enum.GetValues(typeof (Genre)).Length);
                _movies[i] = new Movie(moviesNames[i], rand.Next(300), rand.Next(1900, DateTime.Now.Year + 1), randGenre.ToString(), rand.NextDouble()*10);
            }
            this.Text = "Programming Demo";
        }

        /// <summary>
        /// Заполнение листбоксов для прямоугольников и фильмов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //listBox_Rectangles.Items.AddRange(_rectangles);
            for (int i = 0; i < _rectangles.Length; i++)
            {
                listBox_Rectangles.Items.Add("Rectangle " + (i+1));
            }
            listBox_Movies.Items.AddRange(moviesNames);
        }

        /// <summary>
        /// Метод поиска прямоугольки с максимальной шириной в массиве.
        /// </summary>
        /// <param name="mass"></param>
        /// <returns></returns>
        private int FindRectangleWithMaxWidth(MyRectangle[] mass)
        {
            double max = 0;
            int indexOfMax = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i].Width > max)
                {
                    max = mass[i].Width;
                    indexOfMax = i;
                }
            }
            return indexOfMax;
        }

        /// <summary>
        /// Метод поиска фильма с максимальным рейтингом в массиве.
        /// </summary>
        /// <param name="mass"></param>
        /// <returns></returns>
        private int FindMovieWithMaxRating(Movie[] mass)
        {
            double max = 0;
            int indexOfMax = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i].Rating > max)
                {
                    max = mass[i].Rating;
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
        /// Кнопка Find выводит фильм с максимальным рейтингом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button_FindMovie_Click(object sender, EventArgs e)
        {
            listBox_Movies.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        /// <summary>
        /// Вывод информации о выделенном прямоуголонике.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_Rectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //проверка, что выделенный объект не пустой
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
            //MessageBox.Show("index");
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
                catch (Exception e1) 
                {
                    MessageBox.Show(e1.Message);
                    textBox_Length.BackColor = AppColors.NotValidColor;
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
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    textBox_Width.BackColor = AppColors.NotValidColor;
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
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                textBox_Color.BackColor = AppColors.NotValidColor;
            }

        }

        /// <summary>
        /// Вывод информации о выделенном фильме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_Movies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Movies.SelectedIndex != -1)
            {
                _currentMovie = _movies[listBox_Movies.SelectedIndex];
                textBox_Name.Text = _currentMovie.Name;
                textBox_Duration.Text = _currentMovie.Duration.ToString();
                textBox_Year.Text = _currentMovie.Year.ToString();
                textBox_Genre.Text = _currentMovie.Genre;
                textBox_Rating.Text = Math.Round(_currentMovie.Rating, 2).ToString();
            }
        }
        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Возможность задавать фильму продолжительность с обработкой исключений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Duration_TextChanged(object sender, EventArgs e)
        {
            textBox_Duration.BackColor = Color.White;
            if (textBox_Duration.Text != "" && textBox_Duration.Text != null)
            {
                try
                {
                    _currentMovie.Duration = Convert.ToInt32(textBox_Duration.Text);
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    textBox_Duration.BackColor = AppColors.NotValidColor;
                }
            }
        }

        /// <summary>
        /// Возможность задавать фильму год выпуска с обработкой исключений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Year_TextChanged(object sender, EventArgs e)
        {
            textBox_Year.BackColor = AppColors.StandartColor;
            if (textBox_Year.Text != "" && textBox_Year.Text != null)
            {
                try
                {
                    _currentMovie.Year = Convert.ToInt32(textBox_Year.Text);
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    textBox_Year.BackColor = AppColors.NotValidColor;
                }
            }
        }

        /// <summary>
        /// Возможность задавать фильму жанр с обработкой исключений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Genre_TextChanged(object sender, EventArgs e)
        {
            if (listBox_Movies.SelectedIndex != -1)
            {
                textBox_Genre.BackColor = AppColors.StandartColor;

                try
                {
                    _currentMovie.Genre = textBox_Genre.Text;
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    textBox_Genre.BackColor = AppColors.NotValidColor;
                }
            }
        }

        /// <summary>
        /// Возможность задавать фильму рейтинг с обработкой исключений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Rating_TextChanged(object sender, EventArgs e)
        {
            textBox_Rating.BackColor = Color.White;
            if (textBox_Rating.Text != "" && textBox_Rating.Text != null)
            {
                try
                {
                    _currentMovie.Rating = Convert.ToDouble(textBox_Rating.Text);
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    textBox_Rating.BackColor = Color.LightPink;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage_Rectangles_Click(object sender, EventArgs e)
        {

        }

        private void textBox_rectX_KeyDown(object sender, KeyEventArgs e)
        { 
            /*if (!String.IsNullOrEmpty(textBox_rectX.Text)  && textBox_rectX.Text != "")
            {
                if (e.KeyData == Keys.Enter)
                {
                    _currentMyRectangle.Centre = new Point2D
                        (Convert.ToInt32(textBox_rectX.Text), _currentMyRectangle.Centre.Y);
                    listBox_rectanglesToShow.Items[listBox_rectanglesToShow.SelectedIndex]
                        = _currentMyRectangle.MyRectangleToString();
                    _rectanglePanels[listBox_rectanglesToShow.SelectedIndex].Location
                        = new Point(_currentMyRectangle.Centre.X, _currentMyRectangle.Centre.Y);
                }
            }*/
        }

        private void textBox_rectX_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != (char)Keys.Enter)
                e.Handled = true;*/
        }

        private void rectanglesCollisionControl1_Load(object sender, EventArgs e)
        {

        }

        private void enumerationsControl1_Load(object sender, EventArgs e)
        {

        }
    }
}

