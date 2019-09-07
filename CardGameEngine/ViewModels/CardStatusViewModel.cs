using CardGameEngine.Views.CardsViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CardGameEngine.ViewModels
{
    public class CardStatusViewModel
    {
        public CardStatusViewModel()
        {
            OpenStrongArmorCardViewCommand = new RelayCommand<Window>(OpenStrongArmorCardView);
            OpenStrongDamageCardViewCommand = new RelayCommand<Window>(OpenStrongDamageCardView);
            OpenStrongHealingCardViewCommand = new RelayCommand<Window>(OpenStrongHealingCardView);
            OpenStrongPoisonCardViewCommand = new RelayCommand<Window>(OpenStrongPoisonCardView);
            OpenWeakArmorCardViewCommand = new RelayCommand<Window>(OpenWeakArmorCardView);
            OpenWeakDamageCardViewCommand = new RelayCommand<Window>(OpenWeakDamageCardView);
            OpenWeakHealingCardViewCommand = new RelayCommand<Window>(OpenWeakHealingCardView);
            OpenWeakPoisonCardViewCommand = new RelayCommand<Window>(OpenWeakPoisonCardView);
        }

        public RelayCommand<Window> OpenStrongArmorCardViewCommand { get; set; }
        public RelayCommand<Window> OpenStrongDamageCardViewCommand { get; set; }
        public RelayCommand<Window> OpenStrongHealingCardViewCommand { get; set; }
        public RelayCommand<Window> OpenStrongPoisonCardViewCommand { get; set; }
        public RelayCommand<Window> OpenWeakArmorCardViewCommand { get; set; }
        public RelayCommand<Window> OpenWeakDamageCardViewCommand { get; set; }
        public RelayCommand<Window> OpenWeakHealingCardViewCommand { get; set; }
        public RelayCommand<Window> OpenWeakPoisonCardViewCommand { get; set; }

        private void OpenStrongArmorCardView(Window window)
        {
            StrongArmorCardView strongArmorCardView = new StrongArmorCardView();
            strongArmorCardView.Show();
        }
        private void OpenStrongDamageCardView(Window window)
        {
            StrongDamageCardView strongDamageCardView = new StrongDamageCardView();
            strongDamageCardView.Show();
        }
        private void OpenStrongHealingCardView(Window window)
        {
            StrongHealingCardView strongHealingCardView = new StrongHealingCardView();
            strongHealingCardView.Show();
        }
        private void OpenStrongPoisonCardView(Window window)
        {
            StrongPoisonCardView strongPoisonCardView = new StrongPoisonCardView();
            strongPoisonCardView.Show();
        }
        private void OpenWeakArmorCardView(Window window)
        {
            WeakArmorCardView weakArmorCardView = new WeakArmorCardView();
            weakArmorCardView.Show();
        }
        private void OpenWeakDamageCardView(Window window)
        {
            WeakDamageCardView weakDamageCardView = new WeakDamageCardView();
            weakDamageCardView.Show();
        }
        private void OpenWeakHealingCardView(Window window)
        {
            WeakHealingCardView weakHealingCardView = new WeakHealingCardView();
            weakHealingCardView.Show();
        }
        private void OpenWeakPoisonCardView(Window window)
        {
            WeakPoisonCardView weakPoisonCardView = new WeakPoisonCardView();
            weakPoisonCardView.Show();
        }
    }
}
