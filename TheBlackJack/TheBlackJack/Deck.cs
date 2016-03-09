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
        string anothercard;
        Random random = new Random();
        public void ShuffleCard(List<Card>_deck)
        {
            int positionXcard;
            int positionYcard;
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 13; x++)
                {
                    positionXcard = random.Next(52);
                    var card=positionXcard;
                    positionYcard = positionXcard;
                    
                    

                }
            }
        }



	}
        
    
}
