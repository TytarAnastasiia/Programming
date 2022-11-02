using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    static class RectangleFactory
    {
        public static MyRectangle Randomize(int maxWidth, int maxHeight)
        {
            Random rand = new Random();
            int width = rand.Next(1, maxWidth/2);
            int height = rand.Next(1, maxHeight/2);
            return new MyRectangle(height, width, "Green",
                new Point2D(rand.Next(maxWidth - width / 2),
                rand.Next(maxHeight - height / 2)));
        }

    }
}
