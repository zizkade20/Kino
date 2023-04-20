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

namespace WpfApp3
{
    /// <summary>
    /// Interakční logika pro Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        public void PrintJson(string when)
        {
            var path = @"../../../diar.json";

            // získání dat z jsonu
            string json = File.ReadAllText(path);
            // deserializace dat z jsonu do listu
            // var dataList = JsonConvert.DeserializeObject<List<Window2>>(json);


        }
    }
}
