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
        Player player = new Player();
        List <Card> deck;
        List<Card> DealerCard;

        public Dealer()
        {
            this.deck = new List<Card>();
            this.DealerCard = new List<Card>();

        }
        public void getDeck(List<Card> cardList)
        {
            foreach (var item in cardList)
            {
                deck.Add(item);
            }
        }
        public void DealerAmount()
        {
            amount._dealerAmount = 100;
        }
        public void GetCard()
        {

            DealerCard.Add(deck[0]);
            deck.RemoveAt(0);
           
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
        public Card GiveAwayCard()
        {
            Card givecard = new Card();
            givecard = deck[0];
            deck.RemoveAt(0);
            return givecard;
        }
    }
}
