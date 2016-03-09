using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBlackJack
{
    class Dealer
    {
        Amount amount = new Amount();

        List<string> DealerCard;

        public void DealerAmount()
        {
            amount._dealerAmount = 100;
        }
    }
}
