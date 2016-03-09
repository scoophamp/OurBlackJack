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
        public int _dealAmount { get; set; }

        Player player = new Player();

        public int Win()
        {
            _myAmount = player._myBet * 2;

            return _myAmount;
        }
        public int Loose()
        {
            _myAmount = _myAmount - player._myBet;
            return _myAmount;
        }
        public void CheckValue()
        {
            _myAmount = _myAmount;
        }

    }
}
