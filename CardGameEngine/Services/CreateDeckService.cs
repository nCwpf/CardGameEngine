using CardGame.Data.Classes.Cards.Strong;
using CardGame.Data.Classes.Cards.Weak;
using CardGame.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameEngine.Services
{
    public class CreateDeckService
    {


        public CreateDeckService()
        {
            Deck = new ObservableCollection<ICard>();
            Deck = Suffle();
        }

        public ObservableCollection<ICard> Deck { get; set; }

        private ObservableCollection<ICard> Suffle()
        {
            Random random = new Random();
            int number = 0;
            while (Deck.Count < 40)
             {
                number = random.Next(7);
                 
                 if (number==0)
                 {
                     Deck.Add(new StrongArmorCard("/Images/StrongArmorImg.png"));
                 }
                 else if (number==1)
                 {
                     Deck.Add(new StrongDamageCard("/Images/r6EFKGhexmhp8ajfnpKzCV6b8.png"));
                 }
                 else if (number==2)
                 {
                     Deck.Add(new StrongHealingCard("/Images/StrongHealingImg.png"));
                 }
                 else if (number==3)
                 {
                     Deck.Add(new StrongPoisonCard("/Images/StrongPoisonImg.png"));
                 }
                 else if (number==4)
                 {
                     Deck.Add(new WeakArmorCard("/Images/WeakArmorImg.png"));
                 }
                 else if (number==5)
                 {
                     Deck.Add(new WeakDamageCard("/Images/WeakDamageImg.png"));
                 }
                 else if (number==6)
                 {
                     Deck.Add(new WeakHealingCard("/Images/W.png"));
                 }
                 else
                 {
                     Deck.Add(new WeakPoisonCard("/Images/WeakPoisonImg.png"));
                 }
                number++;
             }
            //while (Deck.Count<40)
            //{
           //     Deck.Add(new StrongArmorCard("/Images/StrongArmorImg.png"));
            //}
            return Deck;
        }
    }
}
