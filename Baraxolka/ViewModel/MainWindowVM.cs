using Baraxolka.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraxolka.ViewModel
{
    public class MainWindowVM : BaseVM
    {
        private Operativka newOperativka;

        public Operativka NewOperativka
        {
            get => newOperativka;

            set
            {
                newOperativka = value;
                SignalIzmenenia();
            }
        }

            public CommandVM AddOperativka { get; }

        public ObservableCollection<object> Baraxolka { get; set; } = new();

        public MainWindowVM()
        {
            AddOperativka = new CommandVM(() =>
            {
                OperativkaOkno operativkaOkno = new OperativkaOkno(Baraxolka);
                operativkaOkno.ShowDialog();
                Baraxolka.Add(newOperativka);

            });
        }
    }


    
    
}
