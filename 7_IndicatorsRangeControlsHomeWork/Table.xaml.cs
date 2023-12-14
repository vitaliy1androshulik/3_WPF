using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _7_IndicatorsRangeControlsHomeWork
{
    /// <summary>
    /// Interaction logic for Table.xaml
    /// </summary>
    public partial class Table : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private int buttonNumber=0;
        private int time = 0;
        private int final = 0;
        private int finalTime = 0;
        public Table()
        {
            InitializeComponent();
        }
        public Table(int dif, int time)
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
            InitializeComponent();
            if (dif == 0)
            {

                this.time = time;
                TimeLabel.Content = time;
                progressBar.Maximum = 9;
                int[] c = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                //UniformGrid uniformGrid = new UniformGrid();

                //uniformGrid.Rows = 3;
                //uniformGrid.Columns = 3;

                TableGrid.Rows = 3;
                TableGrid.Columns = 3;


                var rng = new Random();
                rng.Shuffle(c);
                int i = 0;
                foreach (int number in c)
                {
                    Button button = new Button();
                    button.Content = number;
                    Random r = new Random();
                    button.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(76, 255), (byte)r.Next(76, 255), (byte)r.Next(76, 255)));
                    button.Background.Opacity = 0.6;
                    button.FontSize = 12;
                    button.FontWeight = FontWeights.Bold;
                    button.Click += B_Click;
                    button.Margin = new Thickness(3);
                    button.BorderThickness = new Thickness(0);
                    TableGrid.Children.Add(button);
                }
                final = 9;
            }
            else if (dif == 1)
            {
                this.time = time;
                TimeLabel.Content = time;
                int[] c = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13,14,15,16};
                //UniformGrid uniformGrid = new UniformGrid();
                progressBar.Maximum = 16;
                //uniformGrid.Rows = 3;
                //uniformGrid.Columns = 3;

                TableGrid.Rows = 4;
                TableGrid.Columns = 4;


                var rng = new Random();
                rng.Shuffle(c);
                int i = 0;
                foreach (int number in c)
                {
                    
                    Button button = new Button();
                    button.Content = number;
                    Random r = new Random();
                    button.Background =new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),(byte)r.Next(1, 255), (byte)r.Next(1, 233)));
                    button.Background.Opacity = 0.6;
                    button.FontSize = 12;
                    button.FontWeight = FontWeights.Bold;
                    button.Click += B_Click;
                    button.Margin = new Thickness(3);
                    button.BorderThickness = new Thickness(0);
                    TableGrid.Children.Add(button);
                }
                final = 16;
            }
            else if (dif == 2)
            {
                this.time = time;
                TimeLabel.Content = time;
                int[] c = new int[25] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 ,17,18,19,20,21,22,23,24,25};
                //UniformGrid uniformGrid = new UniformGrid();
                progressBar.Maximum = 25;
                //uniformGrid.Rows = 3;
                //uniformGrid.Columns = 3;

                TableGrid.Rows = 5;
                TableGrid.Columns = 5;


                var rng = new Random();
                rng.Shuffle(c);
                int i = 0;
                foreach (int number in c)
                {
                    Button button = new Button();
                    button.Content = number;
                    Random r = new Random();
                    button.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
                    button.Background.Opacity = 0.6;
                    button.FontSize = 12;
                    button.FontWeight = FontWeights.Bold;
                    button.Click += B_Click;
                    button.Margin = new Thickness(3);
                    button.BorderThickness = new Thickness(0);
                    TableGrid.Children.Add(button);
                }
                final = 25;
            }


        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
                if (time > 0)
                {
                    time--;
                    TimeLabel.Content = time;
                finalTime++;
                }
                else if (time == 0)
                {
                    MessageBoxResult res = MessageBox.Show("You lose!", "Loooooser", MessageBoxButton.OK, MessageBoxImage.Information);
                    if (res == MessageBoxResult.OK)
                    {
                        this.Close();
                    }
                }
            }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            Button clicked = sender as Button;
            int number = (int)clicked.Content;
            if (buttonNumber + 1 == number)
            {
                buttonNumber++;
                clicked.IsEnabled = false;
                progressBar.Value++;

                if((int)clicked.Content==final)
                {
                    timer.Stop();
                    clicked.Content = null;
                    MessageBoxResult res = MessageBox.Show($"Winner, winner, chicken dinner!\nTime : {finalTime} sec.", "Uhhyayaya", MessageBoxButton.OK, MessageBoxImage.Information);
                    
                    if (res == MessageBoxResult.OK)
                    {
                        this.Close();
                    }

                }
                clicked.Content = null;
            }
        }
    }
}
