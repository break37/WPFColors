using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFColors
{
    public class WindowParameters
    {
        public double WindowWidth { get; set; }
        public double WindowHeight { get; set; }
        public double WindowPositionX { get; set; }
        public double WindowPositionY { get; set; }

        public WindowParameters(double width, double height, double x, double y)
        {
            WindowWidth = width;
            WindowHeight = height;
            WindowPositionX = x;
            WindowPositionY = y;
        }
    }
}
