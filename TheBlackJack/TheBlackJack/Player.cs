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
        List<string> PlayerCard;
        Amount amount = new Amount();
        Deck deck = new Deck();

        public void CurrentAmount()
        {
            amount._myAmount = 100;
        }
        public void HitANewCard()
        {

        }
        public void Stay()
        {

        }
    }
}
