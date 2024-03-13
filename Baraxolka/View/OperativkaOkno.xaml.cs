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
    /// Логика взаимодействия для OperativkaOkno.xaml
    /// </summary>
    public partial class OperativkaOkno : Window
    {
        public Operativka Operativka { get; set; } = new Operativka();

        public OperativkaOkno(System.Collections.ObjectModel.ObservableCollection<object> baraxolka)
        {
            InitializeComponent();
            DataContext = this;
        }

    }
}

