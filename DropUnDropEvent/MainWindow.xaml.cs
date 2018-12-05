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

namespace DropUnDropEvent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button mainButton = new Button
            {
                Content = "DropEvent",
                Width = 80,
                Height = 30
            };

            ListBox listBox = new ListBox
            {
                Width = 80,
                Height = 85,
                Visibility = Visibility.Hidden,
                Margin = new Thickness(90, 115, 90, 0),
                HorizontalContentAlignment = HorizontalAlignment.Stretch,
            };

            /*listBox.Items.Add("One");
            listBox.Items.Add("Two");
            listBox.Items.Add("Three");
            listBox.Items.Add("Four");*/

            for (int i = 0;i < 3;i++)
            {
                Button buttonsInList = new Button
                {
                    Content = "Button",
                    BorderBrush = new SolidColorBrush(Colors.Transparent),
                    BorderThickness = new Thickness(0,0,0,0),//border при наведении на кнопку
                    Background = Brushes.White,//цвет внутри кнопки 
                };//единый стиль для кнопок, которые будут в listBox`е

                listBox.Items.Add(buttonsInList);
            }

            mainButton.MouseEnter += button_Drop;
            mainButton.MouseLeave += button_UnDrop;

            listBox.MouseEnter += list_Drop;
            listBox.MouseLeave += list_UnDrop;

            MainGrid.Children.Add(mainButton);
            MainGrid.Children.Add(listBox);

            void button_Drop(object sender, MouseEventArgs e)
            {
                /*if (e.RightButton == MouseButtonState.Pressed)
                {
                    MessageBox.Show("Test");
                }*/
                listBox.Visibility = Visibility.Visible;
            }

            void button_UnDrop(object sender, EventArgs e)
            {
                listBox.Visibility = Visibility.Hidden;
            }

            void list_Drop(object sender, EventArgs e)
            {
                listBox.Visibility = Visibility.Visible;
            }

            void list_UnDrop(object sender, EventArgs e)
            {
                listBox.Visibility = Visibility.Hidden;
            }
        }
    }
}
