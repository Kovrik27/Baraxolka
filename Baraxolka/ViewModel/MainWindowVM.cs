using Baraxolka.Model;
using Baraxolka.View;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraxolka.ViewModel
{
    public class MainWindowVM : BaseVM
    {
        



        public CommandVM AddOperativka { get; }
        public CommandVM AddProcessor {  get; }
        public CommandVM AddVideokarta { get; }
        public CommandVM AddSetevoiOborydovanie { get; }

        public ObservableCollection<object> Baraxolka { get; set; } = new();

        public MainWindowVM()
        {
            AddOperativka = new CommandVM(() =>
            {
                OperativkaOkno operativkaOkno = new OperativkaOkno(Baraxolka);
                operativkaOkno.ShowDialog();
                Baraxolka.Add(operativkaOkno.NewOperativka);

            });

            AddProcessor = new CommandVM(() =>
            {
                ProcessorOkno processorOkno = new ProcessorOkno(Baraxolka);
                processorOkno.ShowDialog();
                Baraxolka.Add(processorOkno.NewProcessor);
            });

            AddVideokarta = new CommandVM(() =>
            {
                VideokartaOkno videokartaOkno = new VideokartaOkno(Baraxolka);
                videokartaOkno.ShowDialog();
                Baraxolka.Add(videokartaOkno.NewVideokarta);
            });

            AddSetevoiOborydovanie = new CommandVM(() =>
            {
                SetevoiOborydovanieOkno setevoioborydovanieOkno = new SetevoiOborydovanieOkno(Baraxolka);
                setevoioborydovanieOkno.ShowDialog();
                Baraxolka.Add(setevoioborydovanieOkno.NewSetevoiOborydovanie);
            });

        }
    }


    
    
}
