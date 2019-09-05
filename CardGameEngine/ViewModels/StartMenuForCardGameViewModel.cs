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
            RelayCommand = new RelayCommand<Window>(Click);
        }

        public event EventHandler CanExecuteChanged;

        private ICommand command;

        public RelayCommand<Window> RelayCommand { get; private set; }

        

        public void Click(Window window)
        {
            FieldGridView fieldGridView = new FieldGridView();
            fieldGridView.Show();
            if (window is StartMenuForCardGameView)
            {
                window.Close();
            }
        }
    }
}