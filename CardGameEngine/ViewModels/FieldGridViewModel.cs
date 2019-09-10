using CardGame.Data.Interfaces;
using CardGameEngine.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CardGameEngine.ViewModels
{
    public class FieldGridViewModel
    {

        public FieldGridViewModel()
        {
            Cards = new ObservableCollection<ICard>();
            Command = new RelayCommand<object>(GetCards);
        }

        public RelayCommand<object> Command { get; set; }

        public ObservableCollection<ICard> Cards { get; set; }

        private void GetCards(object data)
        {
            CreateDeckService createDeckService = new CreateDeckService();
            var deck= createDeckService.Deck;
            foreach (var item in deck)
            {
                Cards.Add(item);
            }
        }
    }
}
