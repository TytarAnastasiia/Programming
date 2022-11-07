using System.Windows.Forms;

namespace InfoSysFlight
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            flightControl1.WriteFlightsToFile("flight.txt");
        }
    }
}
