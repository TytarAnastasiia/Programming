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

namespace Programming.View.Panels
{  
    public partial class RectanglesCollisionControl : UserControl
    {
        private MyRectangle _currentMyRectangle;
        private List<Panel> _rectanglePanels;
        private List<MyRectangle> _myRectanglesList;

        public RectanglesCollisionControl()
        {
            InitializeComponent();
            _myRectanglesList = new List<MyRectangle>();
            _rectanglePanels = new List<Panel>();
        }

        private void textBox_rectY_TextChanged(object sender, EventArgs e)
        {
            if (_currentMyRectangle != null)
            {
                textBox_rectY.BackColor = Color.White;
                int index = listBox_rectanglesToShow.SelectedIndex;
                if (textBox_rectY.Text != "" && textBox_rectY.Text != null)
                {
                    try
                    {
                        int z = _currentMyRectangle.Centre.X;
                        _currentMyRectangle.Centre = new Point2D
                            (z, Convert.ToInt32(textBox_rectY.Text));
                        listBox_rectanglesToShow.Items[index]
                            = _currentMyRectangle.Id -5 + ": " + _currentMyRectangle.MyRectangleToString();
                        _rectanglePanels[index].Location
                            = new Point(z, _currentMyRectangle.Centre.Y - (int)(_currentMyRectangle.Length / 2));
                        FindCollisions();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                        textBox_rectY.BackColor = AppColors.NotValidColor;
                    }
                }
            }
        }

        private void textBox_rectX_TextChanged(object sender, EventArgs e)
        {
            if (_currentMyRectangle != null)
            {
                textBox_rectX.BackColor = Color.White;
                if (textBox_rectX.Text != "" && textBox_rectX.Text != null)
                {
                    try
                    {
                        int y = _currentMyRectangle.Centre.Y;
                        _currentMyRectangle.Centre = new Point2D
                            (Convert.ToInt32(textBox_rectX.Text), y);
                        listBox_rectanglesToShow.Items[listBox_rectanglesToShow.SelectedIndex]
                            = _currentMyRectangle.Id - 5 + ": " + _currentMyRectangle.MyRectangleToString();
                        _rectanglePanels[listBox_rectanglesToShow.SelectedIndex].Location
                            = new Point(_currentMyRectangle.Centre.X - (int)(_currentMyRectangle.Width/2), y);
                        FindCollisions();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                        textBox_rectX.BackColor = AppColors.NotValidColor;
                    }
                }
            }
        }

        private void textBox_rectX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox_rectX_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_RemoveRectangle_Click(object sender, EventArgs e)
        {
            int index = listBox_rectanglesToShow.SelectedIndex;
            if (index != -1)
            {
                _myRectanglesList.Remove(_currentMyRectangle);
                listBox_rectanglesToShow.Items.Remove(_currentMyRectangle.Id-5 + ": " + _currentMyRectangle.MyRectangleToString());
                panel_canvas.Controls.RemoveAt(index);
                FindCollisions();
                ClearRectangleInfo();

                //panel_canvas.Controls.RemoveAt(listBox_rectanglesToShow.SelectedIndex);
            }
        }

        private void button_AddRectangle_Click(object sender, EventArgs e)
        {
            MyRectangle newRect = RectangleFactory.Randomize(panel_canvas.Width, panel_canvas.Height);
            _myRectanglesList.Add(newRect);
            listBox_rectanglesToShow.Items.Add(newRect.Id - 5 + ": " + newRect.MyRectangleToString());
            Panel newPanel = new Panel();
            newPanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            newPanel.Width = (int)newRect.Width;
            newPanel.Height = (int)newRect.Length;
            newPanel.Location = new System.Drawing.Point(newRect.Centre.X - (int)(newRect.Width / 2),
                newRect.Centre.Y - (int)(newRect.Length / 2));
            _rectanglePanels.Add(newPanel);
            FindCollisions();
            panel_canvas.Controls.Add(newPanel);
        }

        private void listBox_rectanglesToShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_rectanglesToShow.SelectedIndex != -1)
            {
                _currentMyRectangle = _myRectanglesList[listBox_rectanglesToShow.SelectedIndex];
                UpdateRectangleInfo();
            }
            else
            {
                //ClearRectangleInfo();
                //MessageBox.Show("index");
            }
        }

        private void panel_canvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_rectHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_rectWidth_Click(object sender, EventArgs e)
        {

        }

        private void textBox_rectWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_rectY_Click(object sender, EventArgs e)
        {

        }

        private void textBox_rectY_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label_rectX_Click(object sender, EventArgs e)
        {

        }

        private void textBox_rectX_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label_rectId_Click(object sender, EventArgs e)
        {

        }

        private void textBox_rectId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_rectHeight_Click(object sender, EventArgs e)
        {

        }

        private void button_RemoveRectangle_Click_1(object sender, EventArgs e)
        {

        }

        private void button_AddRectangle_Click_1(object sender, EventArgs e)
        {

        }

        private void label_rectangles_Click(object sender, EventArgs e)
        {

        }

        private void UpdateRectangleInfo()
        {
            if (_currentMyRectangle != null)
            {
                textBox_rectId.Text = _currentMyRectangle.Id.ToString();
                textBox_rectX.Text = _currentMyRectangle.Centre.X.ToString();
                textBox_rectY.Text = _currentMyRectangle.Centre.Y.ToString();
                textBox_rectWidth.Text = _currentMyRectangle.Width.ToString();
                textBox_rectHeight.Text = _currentMyRectangle.Length.ToString();
            }
        }
        private void ClearRectangleInfo()
        {
            textBox_rectId.Text = "";
            textBox_rectX.Text = "";
            textBox_rectY.Text = "";
            textBox_rectWidth.Text = "";
            textBox_rectHeight.Text = "";
        }
        private void FindCollisions()
            {
            for (int i = 0; i < _myRectanglesList.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
                _myRectanglesList[i].Color = "Green";
            }
                for (int i = 0; i < _myRectanglesList.Count; i++)
                {
                    for (int j = i+1; j < _myRectanglesList.Count; j++)
                    {
                        if (i != j)
                        {
                            if (CollisionManager.IsCollision(_myRectanglesList[i], _myRectanglesList[j]))
                            {
                                _myRectanglesList[i].Color = "Red";
                                _myRectanglesList[j].Color = "Red";
                                _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                                _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                            }
                        }
                    }
                }
            }

        private void panel_canvas_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
