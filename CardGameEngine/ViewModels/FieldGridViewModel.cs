using CardGame.Data.Classes;
using CardGame.Data.Classes.Abstract;
using CardGame.Data.Classes.Cards.Strong;
using CardGame.Data.Classes.Cards.Weak;
using CardGame.Data.Common;
using CardGame.Data.Interfaces;
using CardGameEngine.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CardGameEngine.ViewModels
{
    public class FieldGridViewModel : INotifyPropertyChanged
    {

        private int turns = 1;

        public int Index = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        public FieldGridViewModel()
        {
            LoadDeckCommand = new RelayCommand<object>(CreateDeck);
            FirstCardCommand = new RelayCommand<object>(PlayerClickFirstCard);
            SecondCardCommand = new RelayCommand<object>(PlayerClickSecondCard);
            ThirdCardCommand = new RelayCommand<object>(PlayerClickThirdCard);
            ForthCardCommand = new RelayCommand<object>(PlayerClickForthCard);
            FifthCardCommand = new RelayCommand<object>(PlayerClickFifthCard);
            Player = new Player(Cards);
            Enemy = new Player(Cards);
            PlayerHealth = Player.Health;
            PlayerArmor = Player.Armor;
            PlayerMana = Player.Mana;
            EnemyArmor = Enemy.Armor;
            EnemyHealth = Enemy.Health;
            EnemyMana = Enemy.Mana;
            CreateDeckService createDeckService = new CreateDeckService();
            var deck = createDeckService.Deck;
            Cards = deck;

        }


        public IPlayer Player { get; set; }

        public IPlayer Enemy { get; set; }

        public int PlayerHealth
        {
            get
            {
                return Player.Health;
            }
            set
            {
                Player.Health = value;
                OnPropertyChanged("PlayerHealth");
            }
        }

        public int PlayerArmor
        {
            get
            {
                return Player.Armor;
            }
            set
            {
                Player.Armor = value;
                OnPropertyChanged("PlayerArmor");
            }
        }

        public int PlayerMana
        {
            get
            {
                return Player.Mana;
            }
            set
            {
                Player.Mana = value;
                OnPropertyChanged("PlayerMana");
            }
        }

        public int EnemyHealth
        {
            get
            {
                return Enemy.Health;
            }
            set
            {
                Enemy.Health = value;
                OnPropertyChanged("EnemyHealth");
            }
        }

        public int EnemyArmor
        {
            get
            {
                return Enemy.Armor;
            }
            set
            {
                Enemy.Armor = value;
                OnPropertyChanged("EnemyArmor");
            }
        }

        public int EnemyMana
        {


            get
            {
                return Enemy.Mana;
            }
            set
            {
                Enemy.Mana = value;
                OnPropertyChanged("EnemyMana");
            }
        }


        public ICard FirstCard
        {
            get
            {
                return Cards[turns - 1];
            }
            set
            {
                Cards[turns - 1] = value;
                OnPropertyChanged("FirstCard");
            }
        }
        public ICard SecondCard
        {
            get
            {
                return Cards[turns];
            }
            set
            {
                Cards[turns] = value;
                OnPropertyChanged("SecondCard");
            }
        }
        public ICard ThirdCard
        {
            get
            {
                return Cards[turns + 1];
            }
            set
            {
                Cards[turns + 1] = value;
                OnPropertyChanged("ThirdCard");
            }
        }
        public ICard ForthCard
        {
            get
            {
                return Cards[turns + 2];
            }
            set
            {
                Cards[turns + 2] = value;
                OnPropertyChanged("ForthCard");
            }
        }

        public ICard FifthCard
        {
            get
            {
                return Cards[turns + 3];
            }
            set
            {
                Cards[turns + 3] = value;
                OnPropertyChanged("FifthCard");
            }
        }


        public RelayCommand<object> LoadDeckCommand { get; set; }
        public RelayCommand<object> FirstCardCommand { get; set; }
        public RelayCommand<object> SecondCardCommand { get; set; }
        public RelayCommand<object> ThirdCardCommand { get; set; }
        public RelayCommand<object> ForthCardCommand { get; set; }
        public RelayCommand<object> FifthCardCommand { get; set; }

        public ObservableCollection<ICard> Cards { get; set; }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void CreateDeck(object data)
        {
            
            
        }

        private void Turn(object data)
        {
        }

        private void PlayerClickFirstCard(object data)
        {
            if (PlayerMana >= FirstCard.Cost)
            {
                PlayerMana -= FirstCard.Cost;
                if (FirstCard is DamageCard)
                {
                    if (EnemyArmor == 0)
                    {
                        EnemyHealth -= FirstCard.PointsOfEffect;
                    }
                    else if (EnemyArmor < FirstCard.PointsOfEffect)
                    {
                        EnemyHealth -= FirstCard.PointsOfEffect - EnemyArmor;
                    }
                    if (EnemyHealth == 0)
                    {
                        MessageBox.Show("Win");
                    }
                }
                else if (FirstCard is ArmorCard)
                {
                    if (PlayerArmor > 100 - FirstCard.PointsOfEffect)
                    {
                        PlayerArmor = 100;
                        return;
                    }
                    PlayerArmor += FirstCard.PointsOfEffect;
                }
                else if (FirstCard is HealingCard)
                {
                    if (PlayerHealth > 100 - FirstCard.PointsOfEffect)
                    {
                        PlayerHealth = 100;
                        return;
                    }
                    PlayerHealth += FirstCard.PointsOfEffect;
                }
                else if (FirstCard is StrongPoisonCard)
                {
                    Enemy.TurnsPoisoned += Constants.Duration;
                }
                else if (FirstCard is WeakPoisonCard)
                {
                    Enemy.TurnsPoisoned += Constants.LowDuration;
                }
            }
        }
        private void PlayerClickSecondCard(object data)
        {
            if (PlayerMana >= SecondCard.Cost)
            {
                PlayerMana -= SecondCard.Cost;
                if (SecondCard is DamageCard)
                {
                    if (EnemyArmor == 0)
                    {
                        EnemyHealth -= SecondCard.PointsOfEffect;
                    }
                    else if (EnemyArmor < SecondCard.PointsOfEffect)
                    {
                        EnemyHealth -= SecondCard.PointsOfEffect - EnemyArmor;
                    }
                    if (EnemyHealth == 0)
                    {
                        MessageBox.Show("Win");
                    }
                }
                else if (SecondCard is ArmorCard)
                {
                    if (PlayerArmor > 100 - FirstCard.PointsOfEffect)
                    {
                        PlayerArmor = 100;
                        return;
                    }
                    PlayerArmor += SecondCard.PointsOfEffect;
                }
                else if (SecondCard is HealingCard)
                {
                    if (PlayerHealth > 100 - SecondCard.PointsOfEffect)
                    {
                        PlayerHealth = 100;
                        return;
                    }
                    PlayerHealth += SecondCard.PointsOfEffect;
                }
                else if (SecondCard is StrongPoisonCard)
                {
                    Enemy.TurnsPoisoned += Constants.Duration;
                }
                else if (SecondCard is WeakPoisonCard)
                {
                    Enemy.TurnsPoisoned += Constants.LowDuration;
                }
            }
        }
        private void PlayerClickThirdCard(object data)
        {
            if (PlayerMana >= ThirdCard.Cost)
            {
                PlayerMana -= ThirdCard.Cost;
                if (ThirdCard is DamageCard)
                {
                    if (EnemyArmor == 0)
                    {
                        EnemyHealth -= ThirdCard.PointsOfEffect;
                    }
                    else if (EnemyArmor < ThirdCard.PointsOfEffect)
                    {
                        EnemyHealth -= ThirdCard.PointsOfEffect - EnemyArmor;
                    }
                    if (EnemyHealth == 0)
                    {
                        MessageBox.Show("Win");
                    }
                }
                else if (ThirdCard is ArmorCard)
                {
                    if (PlayerArmor > 100 - ThirdCard.PointsOfEffect)
                    {
                        PlayerArmor = 100;
                        return;
                    }
                    PlayerArmor += ThirdCard.PointsOfEffect;
                }
                else if (ThirdCard is HealingCard)
                {
                    if (PlayerHealth > 100 - ThirdCard.PointsOfEffect)
                    {
                        PlayerHealth = 100;
                        return;
                    }
                    PlayerHealth += ThirdCard.PointsOfEffect;
                }
                else if (ThirdCard is StrongPoisonCard)
                {
                    Enemy.TurnsPoisoned += Constants.Duration;
                }
                else if (ThirdCard is WeakPoisonCard)
                {
                    Enemy.TurnsPoisoned += Constants.LowDuration;
                }
            }
        }
        private void PlayerClickForthCard(object data)
        {
            if (PlayerMana >= ForthCard.Cost)
            {
                PlayerMana -= ForthCard.Cost;
                if (ForthCard is DamageCard)
                {
                    if (EnemyArmor == 0)
                    {
                        EnemyHealth -= ForthCard.PointsOfEffect;
                    }
                    else if (EnemyArmor < ForthCard.PointsOfEffect)
                    {
                        EnemyHealth -= ForthCard.PointsOfEffect - EnemyArmor;
                    }
                    else
                    {
                        EnemyArmor -= 100;
                    }
                    if (EnemyHealth == 0)
                    {
                        MessageBox.Show("Win");
                    }
                }
                else if (ForthCard is ArmorCard)
                {
                    if (PlayerArmor > 100 - ForthCard.PointsOfEffect)
                    {
                        PlayerArmor = 100;
                        return;
                    }
                    PlayerArmor += ForthCard.PointsOfEffect;
                }
                else if (ForthCard is HealingCard)
                {
                    if (PlayerHealth > 100 - ForthCard.PointsOfEffect)
                    {
                        PlayerHealth = 100;
                        return;
                    }
                    PlayerHealth += ForthCard.PointsOfEffect;
                }
                else if (ForthCard is StrongPoisonCard)
                {
                    Enemy.TurnsPoisoned += Constants.Duration;
                }
                else if (ForthCard is WeakPoisonCard)
                {
                    Enemy.TurnsPoisoned += Constants.LowDuration;
                }
            }
        }
        private void PlayerClickFifthCard(object data)
        {
            if (PlayerMana >= ForthCard.Cost)
            {
                PlayerMana -= ForthCard.Cost;
                if (ForthCard is DamageCard)
                {
                    if (EnemyArmor == 0)
                    {
                        EnemyHealth -= ForthCard.PointsOfEffect;
                    }
                    else if (EnemyArmor < ForthCard.PointsOfEffect)
                    {
                        EnemyHealth -= ForthCard.PointsOfEffect - EnemyArmor;
                    }
                    if (EnemyHealth == 0)
                    {
                        MessageBox.Show("Win");
                    }
                }
                else if (ForthCard is ArmorCard)
                {
                    if (PlayerArmor > 100 - ForthCard.PointsOfEffect)
                    {
                        PlayerArmor = 100;
                        return;
                    }
                    PlayerArmor += ForthCard.PointsOfEffect;
                }
                else if (ForthCard is HealingCard)
                {
                    if (PlayerHealth > 100 - ForthCard.PointsOfEffect)
                    {
                        PlayerHealth = 100;
                        return;
                    }
                    PlayerHealth += ForthCard.PointsOfEffect;
                }
                else if (ForthCard is StrongPoisonCard)
                {
                    Enemy.TurnsPoisoned += Constants.Duration;
                }
                else if (ForthCard is WeakPoisonCard)
                {
                    Enemy.TurnsPoisoned += Constants.LowDuration;
                }
            }
        }
    }
}