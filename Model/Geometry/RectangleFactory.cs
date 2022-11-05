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
            Console.WriteLine("Randomize(" + maxWidth + "," + maxHeight + ")");
            Random rand = new Random();
            int width = rand.Next(1, maxWidth/2);
            int height = rand.Next(1, maxHeight/2);

            int x = rand.Next(width/2, maxWidth-width/2);
            int y = rand.Next(height/2, maxHeight-height/2);
            Console.WriteLine("new Rectangle center(" + x + "," + y + ") size(" + width + "," + height + ")");
            return new MyRectangle(height, width, "Green", new Point2D(x,y));
        }

    }
}
