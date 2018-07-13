using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private int _numClicks = 0;
        
        public MainWindow()
        {
            InitializeComponent();


            Button btn = new Button();
            btn.Content = "FlipBtn";
            btn.Click  += new RoutedEventHandler(FlipCoin);

        }
        
        
        private void FlipCoin(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int flipValue = rnd.Next(0, 101);

            if(flipValue > 50)
            {
                Heads.Visibility = Visibility.Hidden;
                Tails.Visibility = Visibility.Visible;
            }
            else
            {
                Tails.Visibility = Visibility.Hidden;
                Heads.Visibility = Visibility.Visible;

            }

            _numClicks += 1;
            FlipCount.Text = _numClicks.ToString();


        }
    }
    
}