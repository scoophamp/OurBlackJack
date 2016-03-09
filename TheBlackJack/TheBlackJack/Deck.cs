using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBlackJack
{
    class Deck
    {
        List<Card> _deck = new List<Card>();
        
        public void PrintList()
        {
            foreach (var item in _deck)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }


	}
        
    
}
