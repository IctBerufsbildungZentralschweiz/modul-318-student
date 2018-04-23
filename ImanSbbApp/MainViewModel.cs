using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ImanSbbApp
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainViewModel()
        {
            Connections = new ObservableCollection<DisplayConnection>();
            Board = new ObservableCollection<DisplayBoard>();
        }

        public ObservableCollection<DisplayConnection> Connections { get; set; }
        public ObservableCollection<DisplayBoard> Board { get; set; }

    }
}
