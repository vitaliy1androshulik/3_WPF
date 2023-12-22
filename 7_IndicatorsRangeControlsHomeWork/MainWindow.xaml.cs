using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _7_IndicatorsRangeControlsHomeWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int difficulty =0;
        private int time = 0;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(time ==0)
            {
                time = 10; 
            }
            else if(time == 1) 
            {
                time = 15;
            }
            else if (time == 2)
            {
                time = 20;
            }
            else if (time == 3)
            {
                time =25;
            }
            else if (time == 4)
            {
                time = 30;
            }
            else if (time == 5)
            {
                time = 60;
            }
            Table table = new Table(difficulty, time);
            this.Close();
            table.Show();
        }

        private void wordSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //diffculty = (int)wordSlider.Value;
            time = (int)timeSlider.Value;
        }

        private void startBtn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void startBtn_PreviewDragEnter(object sender, DragEventArgs e)
        {
            startBtn.Background = new SolidColorBrush(Color.FromRgb(255, 40, 30));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            easyBtn.Background = new SolidColorBrush(Color.FromRgb(47, 78, 245));
            easyBtn.Foreground = new SolidColorBrush(Color.FromRgb(255,255,255));
            mediumBtn.Background = new SolidColorBrush(Colors.Transparent);
            mediumBtn.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            hardBtn.Background= new SolidColorBrush(Colors.Transparent);
            hardBtn.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            difficulty = 0;
        }

        private void mediumBtn_Click(object sender, RoutedEventArgs e)
        {
            mediumBtn.Background = new SolidColorBrush(Color.FromRgb(47, 78, 245));
            mediumBtn.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            easyBtn.Background = new SolidColorBrush(Colors.Transparent);
            easyBtn.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            hardBtn.Background = new SolidColorBrush(Colors.Transparent);
            hardBtn.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            difficulty = 1;
        }

        private void hardBtn_Click(object sender, RoutedEventArgs e)
        {
            hardBtn.Background = new SolidColorBrush(Color.FromRgb(47, 78, 245));
            hardBtn.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            easyBtn.Background = new SolidColorBrush(Colors.Transparent);
            easyBtn.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            mediumBtn.Background = new SolidColorBrush(Colors.Transparent);
            mediumBtn.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            difficulty = 2;
        }
    }
}