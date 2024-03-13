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
        private Operativka newOperativka;
        private Processor newProcessor;
        private Videokarta newVideokarta;
        private SetevoiOborydovanie newSetevoiOborydovanie;

        public Operativka NewOperativka
        {
            get => newOperativka;

            set
            {
                newOperativka = value;
                SignalIzmenenia();
            }
        }

        public Processor NewProcessor
        {
            get => newProcessor;

            set
            {
                newProcessor = value;
                SignalIzmenenia();
            }
        }

        public Videokarta NewVideokarta
        {
            get => newVideokarta;

            set
            {
                newVideokarta = value;
                SignalIzmenenia();
            }
        }

        public SetevoiOborydovanie NewSetevoiOborydovanie
        {
            get => newSetevoiOborydovanie;

            set
            {
                newSetevoiOborydovanie = value;
                SignalIzmenenia();
            }
        }



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
                Baraxolka.Add(newOperativka);
                NewOperativka = new Operativka();

            });

            AddProcessor = new CommandVM(() =>
            {
                ProcessorOkno processorOkno = new ProcessorOkno(Baraxolka);
                processorOkno.ShowDialog();
                Baraxolka.Add(newProcessor);
                NewProcessor = new Processor();
            });

            AddVideokarta = new CommandVM(() =>
            {
                VideokartaOkno videokartaOkno = new VideokartaOkno(Baraxolka);
                videokartaOkno.ShowDialog();
                Baraxolka.Add(newVideokarta);
                NewVideokarta = new Videokarta();
            });

            AddSetevoiOborydovanie = new CommandVM(() =>
            {
                SetevoiOborydovanieOkno setevoioborydovanieOkno = new SetevoiOborydovanieOkno(Baraxolka);
                setevoioborydovanieOkno.ShowDialog();
                Baraxolka.Add(newSetevoiOborydovanie);
                NewSetevoiOborydovanie = new SetevoiOborydovanie();
            });

        }
    }


    
    
}
