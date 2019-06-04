using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFColors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Properties

        public Color RectangleColor
        {
            get { return (rectangle.Fill as SolidColorBrush).Color; }
            set { (rectangle.Fill as SolidColorBrush).Color = value; }
        }

        #endregion

        bool sliderValueFlag = false;

        public MainWindow()
        {
            InitializeComponent();
            
            //set color and sliders positions
            Color color = Settings.InitializeColor();
            rectangle.Fill = new SolidColorBrush(color);
            sliderR.Value = color.R;
            sliderG.Value = color.G;
            sliderB.Value = color.B;

            sliderValueFlag = true;

            //set window size and position
            WindowParameters windowParameters = Settings.InitializeWindowParameters();
            this.Width = windowParameters.WindowWidth;
            this.Height= windowParameters.WindowHeight;
            this.Left = windowParameters.WindowPositionX;
            this.Top = windowParameters.WindowPositionY;
        }

        private void UpdateColor(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliderValueFlag)
            {
                Color rectColor = Color.FromRgb((byte)sliderR.Value, (byte)sliderG.Value, (byte)sliderB.Value);
                RectangleColor = rectColor;
                Console.WriteLine("Color changed");
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Settings.SaveColor(RectangleColor);
                Settings.SaveWindowParameters(this.Width, this.Height, this.Left, this.Top);
                Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Settings.SaveColor(RectangleColor);
            Settings.SaveWindowParameters(this.Width, this.Height, this.Left, this.Top);
        }
    }
}