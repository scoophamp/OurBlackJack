using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBlackJack
{
    class Amount
    {
        private int _myAmount;
        private int _dealerAmount;

        public int MyAmount
        {
            get { return _myAmount; }
            set { _myAmount = value; }
        }
       
        public int DealerAmount
        {
            get { return _dealerAmount; }
            set { _dealerAmount = value; }
        }

        public int Win(int bet)
        {
            bet = bet * 2;
            _myAmount = _myAmount + bet;
            
            return _myAmount;
        }
        public int Loose(int bet)
        {
            _myAmount = _myAmount - bet;
            return _myAmount;
        }
        public int CheckValue()
        {
            _myAmount = _myAmount;
            return _myAmount;
        }

    }
}
