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
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int Rows = 15;
            int Columns = 10;
            grid.Rows = Rows;
            grid.Columns = Columns;


            for (int y = 0; y < Rows; y++)
            {
                for (int i = 0; i < Columns; i++)
                {
                    Button button = new Button()
                    {
                        Content = string.Format("{0}", i),
                        
                        Tag = i
                    };
                    button.Margin = new Thickness(0, 15, 0, 0);
                    this.grid.Children.Add(button);
                }
            }



        }

   
    }
}
