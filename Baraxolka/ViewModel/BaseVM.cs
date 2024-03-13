using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Baraxolka.ViewModel
{
    public class BaseVM : INotifyPropertyChanged
    {
        protected void SignalIzmenenia ([CallerMemberName] string caller = null)
        {
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
        public event PropertyChangedEventHandler? PropertyChanged;


    }
}
