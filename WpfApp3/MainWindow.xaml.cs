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

namespace WpfApp3
{
    /*public class Variables {
        int rada;
        int sedadlo;
    }*/
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int Rows = 10;
            int Columns = 5;
            grid.Rows = Rows;
            grid.Columns = Columns;


            for (int y = 1; y <= Rows; y++)
            {
                for (int i = 1; i <= Columns; i++)
                {
                    Button button = new Button()
                    {
                        Content = string.Format("{0}", i),
                        
                        Tag = i
                    };
                    button.Margin = new Thickness(0, 15, 0, 0);
                    button.Background = Brushes.Red;
                    button.Click += new RoutedEventHandler(button_Click);

                    
                    this.grid.Children.Add(button);
                }
            }

        }
        void button_Click(object sender, RoutedEventArgs e)
        {
            /*
             * POP UP
            myPopup.PlacementTarget = sender as UIElement;
            myPopup.IsOpen = true;
            */
            Button button = sender as Button;
            
            if (button.Background == Brushes.Red)
            {
                button.Background = Brushes.LightGreen;
            } 
            else if (button.Background == Brushes.LightGreen)
            {
                button.Background = Brushes.Red;
            }
        }

    }
}
