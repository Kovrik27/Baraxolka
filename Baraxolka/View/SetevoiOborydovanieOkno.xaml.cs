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
using Baraxolka.Model;

namespace Baraxolka
{
    /// <summary>
    /// Логика взаимодействия для SetevoiOborydovanieOkno.xaml
    /// </summary>
    public partial class SetevoiOborydovanieOkno : Window
    {
        public SetevoiOborydovanie SetevoiOborydovanie { get; set; } = new SetevoiOborydovanie();

        public SetevoiOborydovanieOkno(System.Collections.ObjectModel.ObservableCollection<object> baraxolka)
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
