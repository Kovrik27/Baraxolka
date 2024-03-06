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

namespace Baraxolka
{
    /// <summary>
    /// Логика взаимодействия для VideokartaOkno.xaml
    /// </summary>
    public partial class VideokartaOkno : Window
    {
        public Videokarta Videokarta { get; set; } = new Videokarta();

        public VideokartaOkno (System.Collections.ObjectModel.ObservableCollection<object> baraxolka)
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
