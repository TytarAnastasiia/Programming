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

        /// <summary>
        /// Инициализация элементов.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();
            Random rand = new Random();
            moviesNames = new string[] 
            { "StarTrek", "Mission Impossible", "Ice Age", "The Matrix", "The Man From U.N.C.L.E." };
            _movies = new Movie[moviesNames.Length];
            Genre randGenre;
            for (int i = 0; i < _movies.Length; i++)
            {
                randGenre = (Genre)rand.Next(0, Enum.GetValues(typeof(Genre)).Length);
                _movies[i] = new Movie(moviesNames[i],
                    rand.Next(300), rand.Next(1900, DateTime.Now.Year + 1), randGenre.ToString(), rand.NextDouble() * 10);
            }
            MoviesListBox.Items.AddRange(moviesNames);
        }

        /// <summary>
        /// Метод поиска фильма с максимальным рейтингом в массиве.
        /// </summary>
        /// <param name="movieArray"></param>
        /// <returns></returns>
        private int FindMovieWithMaxRating(Movie[] movieArray)
        {
            double max = 0;
            int indexOfMax = 0;
            for (int i = 0; i < movieArray.Length; i++)
            {
                if (movieArray[i].Rating > max)
                {
                    max = movieArray[i].Rating;
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
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
        
        /// <summary>
        /// Вывод информации о выделенном фильме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_Movies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex != -1)
            {
                _currentMovie = _movies[MoviesListBox.SelectedIndex];
                NameTextBox.Text = _currentMovie.Name;
                DurationTextBox.Text = _currentMovie.Duration.ToString();
                YearTextBox.Text = _currentMovie.Year.ToString();
                GenreTextBox.Text = _currentMovie.Genre;
                RatingTextBox.Text = Math.Round(_currentMovie.Rating, 2).ToString();
            }
        }
        
        /// <summary>
        /// Возможность задавать фильму продолжительность с обработкой исключений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Duration_TextChanged(object sender, EventArgs e)
        {
            DurationTextBox.BackColor = Color.White;
            if (DurationTextBox.Text != "" && DurationTextBox.Text != null)
            {
                try
                {
                    _currentMovie.Duration = Convert.ToInt32(DurationTextBox.Text);
                }
                catch (Exception exception)
                {
                    DurationTextBox.BackColor = AppColors.NotValidColor;
                    ToolTip tip = new ToolTip();
                    tip.Show(exception.Message, DurationTextBox, 3000);
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
            YearTextBox.BackColor = AppColors.StandartColor;
            if (YearTextBox.Text != "" && YearTextBox.Text != null)
            {
                try
                {
                    _currentMovie.Year = Convert.ToInt32(YearTextBox.Text);
                }
                catch (Exception exception)
                {
                    YearTextBox.BackColor = AppColors.NotValidColor;
                    ToolTip tip = new ToolTip();
                    tip.Show(exception.Message, YearTextBox, 3000);
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
            if (MoviesListBox.SelectedIndex != -1)
            {
                GenreTextBox.BackColor = AppColors.StandartColor;

                try
                {
                    _currentMovie.Genre = GenreTextBox.Text;
                }
                catch (Exception exception)
                {
                    GenreTextBox.BackColor = AppColors.NotValidColor;
                    ToolTip tip = new ToolTip();
                    tip.Show(exception.Message, GenreTextBox, 3000);
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
            RatingTextBox.BackColor = Color.White;
            if (RatingTextBox.Text != "" && RatingTextBox.Text != null)
            {
                try
                {
                    _currentMovie.Rating = Convert.ToDouble(RatingTextBox.Text);
                }
                catch (Exception exception)
                {
                    RatingTextBox.BackColor = AppColors.NotValidColor;
                    ToolTip tip = new ToolTip();
                    tip.Show(exception.Message, RatingTextBox, 3000);
                }
            }
        }
    }
}
