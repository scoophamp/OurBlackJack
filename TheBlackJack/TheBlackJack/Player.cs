using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBlackJack
{
    class Player
    {
        public int _myBet { get; set; }
        public int _MyAmount { get; set; }
        List<string> PlayerCard;
      
        Deck deck = new Deck();

       public Player()
        {
            this._MyAmount = 100;
        }
        public void HitANewCard()
        {

        }
        public void Stay()
        {

        }
    }
}
