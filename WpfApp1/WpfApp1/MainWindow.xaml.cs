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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            list1.Background = new SolidColorBrush(Colors.RosyBrown);
        }
       
        
        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (list1.Visibility == Visibility.Visible)
            {
                list1.Visibility = Visibility.Hidden;
            }
            else list1.Visibility = Visibility.Visible;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            videoPopup.IsOpen = true;
            mediaElement.Play();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
            videoPopup.IsOpen = false; 
        }



        public void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StackPanel stack1 = new StackPanel();

            Grid grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition()); 
            grid.ColumnDefinitions.Add(new ColumnDefinition()); 
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            Border border = new Border
            {
                BorderBrush = Brushes.Black,
                BorderThickness = new Thickness(1),
                Padding = new Thickness(3)
            };
             Image img1 = new Image
            {
                Width = 20,
                Height = 20,
                Source = new BitmapImage(new Uri("C:\\Users\\User\\Downloads\\kisspng_no_sy.jpg")),
                Margin = new Thickness(30,1,60,1),
            };
            Grid.SetColumn(img1, 0);

            TextBox textBlock1 = new TextBox
            {
                TextAlignment = TextAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,

                Width= 150,
                MaxHeight = 50,
                MaxWidth = 150,
                TextWrapping = TextWrapping.Wrap,

            };
            border.Child = textBlock1; 

            Grid.SetColumn(border, 1);


            CheckBox check1 = new CheckBox
            {
                Content = "Сделал дело",
                HorizontalAlignment = HorizontalAlignment.Right,
                Margin = new Thickness(230, 1, 130, 1),

            };
            Grid.SetColumn(check1, 2); 

            Button button1 = new Button
            {
                Width = 100,
                Height = 50,
                Content = "Удалить",
                HorizontalAlignment = HorizontalAlignment.Right

            };
            Grid.SetColumn(button1, 2); 


            grid.Children.Add(border);
            grid.Children.Add(img1);
            grid.Children.Add(check1);
            grid.Children.Add(button1);



            stack1.Children.Add(grid);
            list1.Items.Add(stack1);
            check1.Checked += (s, a) =>
            {
                img1.Source = new BitmapImage(new Uri("C:\\Users\\User\\source\\repos\\WpfApp1\\Image\\3d4d824825d6f8b9a2a92958d2cdea8b.png"));
            };
            check1.Unchecked += (s, a) =>
            {
                img1.Source = new BitmapImage(new Uri("C:\\Users\\User\\source\\repos\\WpfApp1\\Image\\kisspng_no_sy.jpg"));
            };
            button1.Click += (s, a) =>
            {
                MessageBoxResult result = MessageBox.Show("Вы хотите продолжить?",
                                                "Подтверждение",
                                                MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(result == MessageBoxResult.Yes)
                {
                    MessageBox.Show("СДЕЛАЛ ДЕЛО, ГУЛЯЙ СМЕЛО");
                    list1.Items.Remove(stack1);
                }
                else
                {
                    MessageBox.Show("ИДИ ДЕЛАЙ ДЕЛА ДОН");
                }
               
            };
        }
    }
}