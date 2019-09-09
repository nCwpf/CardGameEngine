using CardGame.Data.Interfaces;
using CardGameEngine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameEngine.ViewModels
{
    public class FieldGridViewModel
    {
        private List<ICard> GetCards()
        {
            return CreateDeckService.Deck;
        }
    }
}
