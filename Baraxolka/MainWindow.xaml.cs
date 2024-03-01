using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Baraxolka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<object> Tovari { get; set; } = new();
        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            Tovari.Add(new Operativka { Operativki = new List<Operativka>(new Operativka[] { new Operativka { NameO = "GeForce 9080", } }) });
        }

        public class Videokarta
        {
            public string NameV { get; set; }
            public byte[] ImageV { get; set; }
            public decimal PriceV { get; set; }
        }

        public class Prossesor
        {
            public string NameP { get; set; }
            public byte[] ImageP { get; set; }
            public decimal PriceP { get; set; }
        }

        public class Operativka
        {
            public List<Operativka> Operativki { get; set; }
            public string NameO { get; set; }
            public byte[] ImageO { get; set; }
            public decimal PriceO { get; set; }
        }

        public class SSD
        {
            public string NameS { get; set; }
            public byte[] ImageS { get; set; }
            public decimal PriceS { get; set; }
        }

        private void OperativkaAdd(object sender, RoutedEventArgs e)
        {
            {
                OperativkaOkno operativkaOkno = new OperativkaOkno();
                operativkaOkno.ShowDialog();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Operativka)));
            }
        }

        private void ProssesorAdd(object sender, RoutedEventArgs e)
        {

        }

        private void VideokartaAdd(object sender, RoutedEventArgs e)
        {

        }

        private void SSDAdd(object sender, RoutedEventArgs e)
        {

        }
    }

}
