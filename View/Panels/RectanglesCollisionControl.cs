using System;
using System.Collections.Generic;
using System.Drawing;
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
                int index = RectanglesToShowListBox.SelectedIndex;
                if (textBox_rectY.Text != "" && textBox_rectY.Text != null)
                {
                    try
                    {
                        int z = _currentMyRectangle.Centre.X;
                        int y = Convert.ToInt32(textBox_rectY.Text);
                        int min = (int)_currentMyRectangle.Length / 2;
                        int max = CanvasPanel.Height - min;
                        Validator.AssertValueInRange(y, min, max, "Y центра");
                        _currentMyRectangle.Centre = new Point2D
                            (z, Convert.ToInt32(textBox_rectY.Text));
                        RectanglesToShowListBox.Items[index]
                            = GetRectangleTitle(_currentMyRectangle);
                        DrawRectangle(index);
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                        textBox_rectY.BackColor = AppColors.NotValidColor;
                    }
                    RectanglesToShowListBox.Items[index]
                       = GetRectangleTitle(_currentMyRectangle);
                }
            }
        }

        private void textBox_rectX_TextChanged(object sender, EventArgs e)
        {
            if (_currentMyRectangle != null)
            {
                textBox_rectX.BackColor = Color.White;
                int index = RectanglesToShowListBox.SelectedIndex;
                if (textBox_rectX.Text != "" && textBox_rectX.Text != null)
                {
                    try
                    {
                        int y = _currentMyRectangle.Centre.Y;
                        int x = Convert.ToInt32(textBox_rectX.Text);
                        int min = (int)_currentMyRectangle.Width / 2;
                        int max = CanvasPanel.Width - min;
                        Validator.AssertValueInRange(x, min, max, "X центра");
                        _currentMyRectangle.Centre = new Point2D(x, y);
                        DrawRectangle(index);
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                        textBox_rectX.BackColor = AppColors.NotValidColor;
                    }
                    RectanglesToShowListBox.Items[index]
                        = GetRectangleTitle(_currentMyRectangle);
                }
            }
        }
        
        private void textBox_rectWidth_TextChanged(object sender, EventArgs e)
        {
            if (_currentMyRectangle != null)
            {
                textBox_rectWidth.BackColor = Color.White;
                int index = RectanglesToShowListBox.SelectedIndex;
                if (textBox_rectWidth.Text != "" && textBox_rectWidth.Text != null)
                {
                    try
                    {
                        double w = Convert.ToDouble(textBox_rectWidth.Text);
                        double max = Math.Min(_currentMyRectangle.Centre.X, CanvasPanel.Width - _currentMyRectangle.Centre.X)*2;
                        Validator.AssertValueInRange(w, 1.0d, max, "Ширина прямоугольника");
                        _currentMyRectangle.Width = w;
                        DrawRectangle(index);
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                        textBox_rectWidth.BackColor = AppColors.NotValidColor;
                    }
                    RectanglesToShowListBox.Items[index]
                        = GetRectangleTitle(_currentMyRectangle);
                }
            }
        }
        private void textBox_rectHeight_TextChanged(object sender, EventArgs e)
        {
            if (_currentMyRectangle != null)
            {
                textBox_rectHeight.BackColor = Color.White;
                int index = RectanglesToShowListBox.SelectedIndex;
                if (textBox_rectHeight.Text != "" && textBox_rectHeight.Text != null)
                {
                    try
                    {
                        double h = Convert.ToDouble(textBox_rectHeight.Text);
                        double max = Math.Min(_currentMyRectangle.Centre.Y, CanvasPanel.Height-_currentMyRectangle.Centre.Y)*2;
                        Validator.AssertValueInRange(h, 1.0d, max, "Высота прямоугольника");
                        _currentMyRectangle.Length = h;
                        DrawRectangle(index);
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                        textBox_rectHeight.BackColor = AppColors.NotValidColor;
                    }
                    RectanglesToShowListBox.Items[index]
                        = GetRectangleTitle(_currentMyRectangle);
                }
            }
        }

        private void button_RemoveRectangle_Click(object sender, EventArgs e)
        {
            int index = RectanglesToShowListBox.SelectedIndex;
            if (index != -1)
            {
                _myRectanglesList.RemoveAt(index);
                _rectanglePanels.RemoveAt(index);
                RectanglesToShowListBox.Items.RemoveAt(index);
                CanvasPanel.Controls.RemoveAt(index);
                _currentMyRectangle = null;
                ClearRectangleInfo();
                FindCollisions();
            }
        }

        private void button_AddRectangle_Click(object sender, EventArgs e)
        {
            MyRectangle newRect = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            _myRectanglesList.Add(newRect);
            Panel newPanel = new Panel();
            _rectanglePanels.Add(newPanel);
            CanvasPanel.Controls.Add(newPanel);

            _currentMyRectangle = newRect;
            int i = RectanglesToShowListBox.Items.Add(GetRectangleTitle(_currentMyRectangle));
            RectanglesToShowListBox.SelectedIndex = i;
            DrawRectangle(i);
        }

        private string GetRectangleTitle(MyRectangle rectangle)
        {
            return rectangle.Id + ": " + rectangle.MyRectangleToString()+" - "+rectangle.Color;
        }
        
        private void DrawRectangle(int index)
        {
            MyRectangle r = _myRectanglesList[index];
            Panel p = _rectanglePanels[index];

            p.Width = (int)r.Width;
            p.Height = (int)r.Length;
            p.Location = new System.Drawing.Point(r.VertexA.X, r.VertexA.Y);
            FindCollisions();
        }

        private void listBox_rectanglesToShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesToShowListBox.SelectedIndex != -1)
            {
                _currentMyRectangle = _myRectanglesList[RectanglesToShowListBox.SelectedIndex];
                UpdateRectangleInfo();
            }
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
                _rectanglePanels[i].BackColor = AppColors.GreenRectangle;
                _myRectanglesList[i].Color = "Green";
                RectanglesToShowListBox.Items[i]
                       = GetRectangleTitle(_myRectanglesList[i]);
            }
            for (int i = 0; i < _myRectanglesList.Count; i++)
            {
                for (int j = i+1; j < _myRectanglesList.Count; j++)
                {
                    if (CollisionManager.IsCollision(_myRectanglesList[i], _myRectanglesList[j]))
                    {
                        _myRectanglesList[i].Color = "Red";
                        _myRectanglesList[j].Color = "Red";
                        _rectanglePanels[i].BackColor = AppColors.RedRectangle;
                        _rectanglePanels[j].BackColor = AppColors.RedRectangle;
                        RectanglesToShowListBox.Items[i]
                               = GetRectangleTitle(_myRectanglesList[i]);
                        RectanglesToShowListBox.Items[j]
                               = GetRectangleTitle(_myRectanglesList[j]);
                    }
                }
            }
        }
    }
}
