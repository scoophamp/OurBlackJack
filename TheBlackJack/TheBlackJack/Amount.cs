using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBlackJack
{
    class Amount
    {
        public int _myAmount { get; set; }
        public int PlayerBet { get; set; }
        public Amount(int playerAmount)
        {
            this._myAmount = playerAmount;
        }

        public int Win(int bet)
        {
            bet = bet * 2;
            _myAmount = _myAmount + bet;

            return _myAmount;
        }
        public int Loose(int bet)
        {

            return _myAmount;
        }
        public string CheckValue()
        {
            
            return string.Format("Your current amount is {0}", _myAmount);
        }

    }
}
