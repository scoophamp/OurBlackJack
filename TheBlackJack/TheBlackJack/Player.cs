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
        Amount amount = new Amount();

        public void CurrentAmount()
        {
            amount._myAmount = 100;
        }
        List<string> PlayerCard;
    }
}
