using CardGame.Data.Classes.Cards.Strong;
using CardGame.Data.Classes.Cards.Weak;
using CardGame.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameEngine.ViewModels
{
    public class CreateDeckViewModel
    {
        public CreateDeckViewModel()
        {
            Cards = new ObservableCollection<ICard>();
            AddStrongDamageCommand = new RelayCommand<ICard>(AddStrongDamageCard);
            AddStrongArmorCommand = new RelayCommand<ICard>(AddStrongArmorCard);
            AddStrongHealingCommand = new RelayCommand<ICard>(AddStrongHealingCard);
            AddStrongPoisonCommand = new RelayCommand<ICard>(AddStrongPoisonCard);
            AddWeakArmorCommand = new RelayCommand<ICard>(AddWeakArmorCard);
            AddWeakDamageCommand = new RelayCommand<ICard>(AddWeakDamageCard);


        }

        public int CardsNeeded => 40;

        public int CardsAdded => Cards.Count;

        public RelayCommand<ICard> AddStrongDamageCommand { get; set; }
        public RelayCommand<ICard> AddStrongArmorCommand { get; set; }
        public RelayCommand<ICard> AddStrongHealingCommand { get; set; }
        public RelayCommand<ICard> AddStrongPoisonCommand { get; set; }
        public RelayCommand<ICard> AddWeakDamageCommand { get; set; }
        public RelayCommand<ICard> AddWeakArmorCommand { get; set; }
        public RelayCommand<ICard> AddWeakHealingCommand { get; set; }
        public RelayCommand<ICard> AddWeakPoisonCommand { get; set; }


        public ObservableCollection<ICard> Cards { get; set; }

        private void AddStrongDamageCard(ICard card)
        {
            card = new StrongDamageCard("/Images/r6EFKGhexmhp8ajfnpKzCV6b8.png");
            Cards.Add(card);
        }
        private void AddStrongArmorCard(ICard card)
        {
            card = new StrongArmorCard("/Images/StrongArmorImg.png");
            Cards.Add(card);
        }
        private void AddStrongHealingCard(ICard card)
        {
            card = new StrongHealingCard("/Images/StrongHealingImg.png");
            Cards.Add(card);
        }
        private void AddStrongPoisonCard(ICard card)
        {
            card = new StrongPoisonCard("/Images/StrongPoisonImg.png");
            Cards.Add(card);
        }
        private void AddWeakDamageCard(ICard card)
        {
            card = new WeakDamageCard("/Images/WeakDamageImg.png");
            Cards.Add(card);
        }
        private void AddWeakArmorCard(ICard card)
        {
            card = new WeakArmorCard("/Images/WeakArmorImg.png");
            Cards.Add(card);
        }private void AddWeakHealingCard(ICard card)
        {
            card = new WeakHealingCard("/Images/W.png");
            Cards.Add(card);
        }private void AddWeakPoisonCard(ICard card)
        {
            card = new StrongDamageCard("/Images/WeakPoisonImg.png");
            Cards.Add(card);
        }
    }
}
