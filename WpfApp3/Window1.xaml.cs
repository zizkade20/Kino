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
using System.Windows.Shapes;

namespace WpfApp3
{
    
    public partial class Window1 : Window
    {
        public string Hovnajs { get; set; }
        public Window1(String Hovnajs)
        {
            InitializeComponent();

            this.Hovnajs = Hovnajs;
            string[] pozice = Hovnajs.Split('_');

            SedackaLabel.Content = pozice[0] + pozice[1];
        }
    }
}
