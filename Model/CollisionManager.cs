using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model
{
    static class CollisionManager
    {
        public static bool IsCollision(MyRectangle rectangle1, MyRectangle rectangle2)
        {
            double dx = Math.Abs(rectangle1.Centre.X - rectangle2.Centre.X);
            double dy = Math.Abs(rectangle1.Centre.Y - rectangle2.Centre.Y);
            double widthDifference = 0.5 * (rectangle1.Width + rectangle2.Width);
            double heightDifference = 0.5 * (rectangle1.Length + rectangle2.Length);
            if (dx < widthDifference && dy < heightDifference )
            {
                //MessageBox.Show("collision");
                return true;
            }
            return false;
        }
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dx = Math.Abs(ring1.Center.X - ring2.Center.X);
            double dy = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dx * dx + dy * dy);
            if (c < (ring1.ExternalRadius + ring2.ExternalRadius))
                return true;
            return false;
        }
    }
}
