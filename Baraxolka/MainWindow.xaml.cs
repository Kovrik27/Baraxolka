using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<object> Baraxolka { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();
            //Baraxolka.Add(new Operativka { Name = "Оперативка супер крутая 50DDR", Price = "1000000"});
            DataContext = this;
        }




        private void OperativkaAdd(object sender, RoutedEventArgs e)
        {
            OperativkaOkno operativkaOkno = new OperativkaOkno(Baraxolka);
            operativkaOkno.ShowDialog();
            Baraxolka.Add(operativkaOkno.Operativka);

        }

        private void ProssesorAdd(object sender, RoutedEventArgs e)
        {
            ProcessorOkno processorOkno = new ProcessorOkno(Baraxolka);
            processorOkno.ShowDialog();
            Baraxolka.Add(processorOkno.Processor);
        }

        private void VideokartaAdd(object sender, RoutedEventArgs e)
        {
            VideokartaOkno videokartaOkno = new VideokartaOkno(Baraxolka);
            videokartaOkno.ShowDialog();
            Baraxolka.Add(videokartaOkno.Videokarta);
        }

        private void SetevoiOborydovanieAdd(object sender, RoutedEventArgs e)
        {
            SetevoiOborydovanieOkno setevoiOborydovanieOkno = new SetevoiOborydovanieOkno(Baraxolka);
            setevoiOborydovanieOkno.ShowDialog();
            Baraxolka.Add(setevoiOborydovanieOkno.SetevoiOborydovanie);

        }
    }

}
