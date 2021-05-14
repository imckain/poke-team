using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poke_Team.Core;

namespace Poke_Team.MVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand TeamViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public TeamViewModel TeamVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            TeamVM = new TeamViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand((o =>
            {
                CurrentView = HomeVM;
            }));
            
            TeamViewCommand = new RelayCommand((o =>
            {
                CurrentView = TeamVM;
            }));
        }
    }
}
