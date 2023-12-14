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
        private int diffculty =0;
        private int time = 0;
        public MainWindow()
        {
            InitializeComponent();
            LabelDifficult.Content = "Easy       Medium       Hard";
            LabelTime.Content = "10   15    20     25    30   60";
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
            Table table = new Table(diffculty, time);
            this.Close();
            table.Show();
        }

        private void wordSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            diffculty = (int)wordSlider.Value;
            time = (int)timeSlider.Value;
        }
    }
}