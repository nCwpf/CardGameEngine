using CardGameEngine.Views;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
namespace CardGameEngine.ViewModels
{
    public class StartMenuForCardGameViewModel
    {

        public StartMenuForCardGameViewModel()
        {
            OpenCreateDeckViewCommand = new RelayCommand<Window>(OpenCreateDeckView);
            OpenCardStatusViewCommand = new RelayCommand<Window>(OpenCardStatusView);
        }

        public RelayCommand<Window> OpenCardStatusViewCommand { get; private set; }

        public RelayCommand<Window> OpenCreateDeckViewCommand { get; private set; }

        

        private void OpenCreateDeckView(Window window)
        {
            CreateDeckView createDeckView = new CreateDeckView();
            createDeckView.Show();
        }

        private void OpenCardStatusView(Window window)
        {
            CardStatusView cardStatusView = new CardStatusView();
            cardStatusView.Show();
        }
    }
}