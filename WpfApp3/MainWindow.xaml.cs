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
            int Columns = 7;
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
                    button.Background = Brushes.LightGreen;
                    button.Click += new RoutedEventHandler(button_Click);

                    
                    this.grid.Children.Add(button);
                }
            }

        }
        void button_Click(object sender, RoutedEventArgs e)
        {
            
            
            Button button = sender as Button;
            /*
            if (button.Background == Brushes.LightGreen)
            {
                button.Background = Brushes.Gold;
            } 
            else if (button.Background == Brushes.Gold)
            {
                button.Background = Brushes.LightGreen;
            }
            */

            Window1 window1 = new Window1();
            window1.Show();
            
            /*
            Label stavLabel = new Label();
            stavLabel.Content = "Volno";
            stavLabel.Foreground = Brushes.Green;
            stavLabel.HorizontalAlignment = HorizontalAlignment.Center;
            stavLabel.VerticalAlignment = VerticalAlignment.Top;
            */



        }
       

    }
}
