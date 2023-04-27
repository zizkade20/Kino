using Newtonsoft.Json;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Newtonsoft.Json;
using System.IO;

namespace WpfApp3
{
 
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        public void PrintJson(string when)
        {
            var path = @"../../../filmy.json";

            string json = File.ReadAllText(path);
            var dataList = JsonConvert.DeserializeObject<List<Window2>>(json);


        }
    }
}
