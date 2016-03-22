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
        private int _dealerAmount { get; set; }

        private int _playerbet;

        public int PlayerBet
        {
            get { return _playerbet; }
            set { _playerbet = value; }
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
            return _myAmount;
        }

    }
}
