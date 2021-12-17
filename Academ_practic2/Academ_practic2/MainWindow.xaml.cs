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
using System.Windows.Threading;

namespace Academ_practic2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Button but1 = new Button();
            but1.Width = but0.Width;
            but1.Height = but0.Height;
            but1.Margin = new Thickness(rand.Next(670), rand.Next(380), 0, 0);
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Color.FromRgb(Convert.ToByte(rand.Next(0, 255)), Convert.ToByte(rand.Next(0, 255)), Convert.ToByte(rand.Next(0, 255)));
            but1.Background = brush;
            but1.MouseMove += but_MouseMove;
            but1.Content = "Click";
            grid.Children.Add(but1);
        }

        private void but_MouseMove(object sender, MouseEventArgs e)
        {
            Button but = sender as Button;
            but.Margin = new Thickness(rand.Next(670), rand.Next(380), 0, 0);
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Color.FromRgb(Convert.ToByte(rand.Next(0, 255)), Convert.ToByte(rand.Next(0, 255)), Convert.ToByte(rand.Next(0, 255)));
            but.Background = brush;
        }        
    }
}
