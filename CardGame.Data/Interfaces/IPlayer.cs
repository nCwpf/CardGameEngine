using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Data.Interfaces
{
    public interface IPlayer
    {
        List<ICard> Cards { get; set; }

        int Health { get; set; }

        int Armor { get; set; }

        int Mana { get; set; }
    }
}
