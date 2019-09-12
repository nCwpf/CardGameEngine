using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Data.Interfaces
{
    public interface IPlayer
    {
        ObservableCollection<ICard> Cards { get; set; }

        int Health { get; set; }

        int Armor { get; set; }

        int Mana { get; set; }

        int TurnsPoisoned { get; set; }
    }
}
