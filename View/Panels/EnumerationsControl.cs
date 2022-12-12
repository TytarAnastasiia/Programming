using System;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View.Panels
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EnumerationsControl : UserControl
    {
        /// <summary>
        /// Инициализация элементов.
        /// </summary>
        public EnumerationsControl()
        {
            InitializeComponent();
            string[] allEnums = 
                { "Colour", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" };
            EnumsListBox.Items.AddRange(allEnums);
            EnumsListBox.SelectedIndex = 0;
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedValueTextBox.Text = (int)ValuesListBox.SelectedItem + "";
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedIndex != -1)
            {
                ValuesListBox.Items.Clear();
                switch ((string)EnumsListBox.SelectedItem)
                {
                    case "Colour":
                        foreach (var value in Enum.GetValues(typeof(Colour)))
                        {
                            ValuesListBox.Items.Add((Colour)value);
                        }

                        break;
                    case "EducationForm":
                        foreach (var value in Enum.GetValues(typeof(EducationForm)))
                        {
                            ValuesListBox.Items.Add((EducationForm)value);
                        }

                        break;
                    case "Manufactures":
                        foreach (var value in Enum.GetValues(typeof(Manufactures)))
                        {
                            ValuesListBox.Items.Add((Manufactures)value);
                        }

                        break;
                    case "Genre":
                        foreach (var value in Enum.GetValues(typeof(Genre)))
                        {
                            ValuesListBox.Items.Add((Genre)value);
                        }

                        break;
                    case "Season":
                        foreach (var value in Enum.GetValues(typeof(Season)))
                        {
                            ValuesListBox.Items.Add((Season)value);
                        }

                        break;
                    case "Weekday":
                        foreach (var value in Enum.GetValues(typeof(Weekday)))
                        {
                            ValuesListBox.Items.Add((Weekday)value);
                        }

                        break;

                }
            }
        }
    }
}
