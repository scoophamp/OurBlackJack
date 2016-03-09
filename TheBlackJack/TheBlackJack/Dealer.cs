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
        Deck deck;
        List<Card> DealerCard;

        public Dealer()
        {
            this.deck = new Deck();
            this.DealerCard = new List<Card>();
        }
        public void DealerAmount()
        {
            amount._dealerAmount = 100;
        }
        public void GetCard()
        {
            
        }
        Random random = new Random();
        public void ShuffleCard(List<Card> _deck)
        {
            Card holder = new Card();


            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 13; x++)
                {
                    int indexNr = random.Next(52);

                    holder = _deck[indexNr];
                    _deck.RemoveAt(indexNr);
                    _deck.Add(holder);


                }
            }
        }
        public void GiveCard()
        {

        }
    }
}
