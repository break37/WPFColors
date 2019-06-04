using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFColors
{
    public static class Settings
    {
        public static void SaveColor(Color color)
        {
            Properties.Settings settings = Properties.Settings.Default;
            settings.R = color.R;
            settings.G = color.G;
            settings.B = color.B;
            settings.Save();
        }

        public static void SaveWindowParameters(double width, double height, double x, double y)
        {
            Properties.Settings settings = Properties.Settings.Default;
            settings.WindowWidth = width;
            settings.WindowHeight = height;
            settings.WindowPositionX = x;
            settings.WindowPositionY = y;
            settings.Save();
        }

        public static WindowParameters InitializeWindowParameters()
        {
            Properties.Settings settings = Properties.Settings.Default;
            return new WindowParameters(settings.WindowWidth, settings.WindowHeight, settings.WindowPositionX, settings.WindowPositionY);
        }


        public static void InitializePosition()
        {
            
        }


        public static Color InitializeColor()
        {
            Properties.Settings settings = Properties.Settings.Default;

            //alternative for Color.FromArgb()
            Color color = new Color()
            {
                A = 255,
                R = settings.R,
                G = settings.G,
                B = settings.B
            };

            return color;
        }
    }
}
