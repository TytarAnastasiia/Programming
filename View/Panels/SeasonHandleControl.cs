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

namespace Programming.View.Panels
{
    public partial class SeasonHandleControl : UserControl
    {
        /// <summary>
        /// Инициализация элементов.
        /// </summary>
        public SeasonHandleControl()
        {
            InitializeComponent();
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            this.BackColor = AppColors.StandartColor;
            switch (comboBox_seasons.SelectedItem)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Cолнце!");
                    break;
                case Season.Autumn:
                    this.BackColor = AppColors.AutumnColor;
                    break;
                case Season.Winter:
                    MessageBox.Show("Брррр! Холодно!");
                    break;
                case Season.Spring:
                    this.BackColor = AppColors.SpringColor;
                    break;
            }
        }

        private void SeasonHandleControl_Load(object sender, EventArgs e)
        {
            foreach (var value in Enum.GetValues(typeof(Season)))
            {
                comboBox_seasons.Items.Add(value);
            }
        }
    }
}
