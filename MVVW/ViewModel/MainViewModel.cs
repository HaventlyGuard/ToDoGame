using menuApp.Core;
using menuApp.MVVW.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuApp.MVVW.ViewModel
{
    internal class MainViewModel : ObserverObject
    {
        public HomeViewModel HomeVM { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged();            
            }
        }



        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            CurrentView = HomeVM;
        }
    }
}
