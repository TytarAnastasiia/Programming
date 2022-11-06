using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming.View.Panels
{
    public partial class MoviesControl : UserControl
    {
        private Movie[] _movies;
        private Movie _currentMovie;
        string[] moviesNames;
        
        public MoviesControl()
        {
            InitializeComponent();
            Random rand = new Random();
            moviesNames = new string[] { "StarTrek", "Mission Impossible", "Ice Age", "The Matrix", "The Man From U.N.C.L.E." };
            _movies = new Movie[moviesNames.Length];
            Genre randGenre;
            for (int i = 0; i < _movies.Length; i++)
            {
                randGenre = (Genre)rand.Next(0, Enum.GetValues(typeof(Genre)).Length);
                _movies[i] = new Movie(moviesNames[i], rand.Next(300), rand.Next(1900, DateTime.Now.Year + 1), randGenre.ToString(), rand.NextDouble() * 10);
            }
        }

        private void MoviesControl_Load(object sender, EventArgs e)
        {
            listBox_Movies.Items.AddRange(moviesNames);
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
        /// Кнопка Find выводит фильм с максимальным рейтингом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_FindMovie_Click(object sender, EventArgs e)
        {
            listBox_Movies.SelectedIndex = FindMovieWithMaxRating(_movies);
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
    }
}
