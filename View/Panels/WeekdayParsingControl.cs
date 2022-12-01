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
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Инициализация элементов.
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void button_ParseDay_Click(object sender, EventArgs e)
        {
            Weekday day;
            if (Enum.TryParse(textBox_EnteredDay.Text, out day))
            {
                textBox_ParsingResult.Text = "Этот день недели (" + 
                    day.ToString() + " = " + (int)day + ") ";
            }
            else textBox_ParsingResult.Text = "Нет такого дня недели";
        }
    }
}
