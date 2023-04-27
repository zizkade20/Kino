using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
        private static Database _data;
        public static Database Data
        {
            get 
            {
                if(_data == null)
                {
                    _data = new Database("avenger.db3");
                }
                return _data;
            } 
        }
        public Window1(String Hovnajs)
        {
            InitializeComponent();

            /*
            this.Data = Hovnajs;
            string[] pozice = Hovnajs.Split('_');

            SedackaLabel.Content = "řada " + pozice[1] + "  sedadlo " + pozice[2];
            */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // ulozeni do db

            Avenger avenger = new Avenger()
            {
                Name = t1.Text,
                PublicName = t2.Text,
            };
            Data.SaveItemAsync(avenger);
            t1.Text = "";
            t2.Text = "";
            //this.Close();
        }
        
    }
}
