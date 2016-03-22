using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBlackJack
{
    class Dealer
    {
        
        List <Card> deck;//Dealerns kortlek
        public List<Card> DealerCard { get; set; }//Dealerns hand med kort

        public Dealer()
        {
            this.deck = new List<Card>();
            this.DealerCard = new List<Card>();

        }
        public void SetDeck(List<Card> cardList)//Tar in kortlistan går igenom den och lägger till den i sin deck
        {
            foreach (var item in cardList)
            {
                deck.Add(item);
            }
        }
       
        public void DealerGetCard()//Lägger till första kortet i listan till sin hand och tar sedan bort den
        {

            DealerCard.Add(deck[0]);
            deck.RemoveAt(0);
           
        }
        Random random = new Random();
        public void ShuffleCard(List<Card> _deck)//Tar in listan med alla korten och sedan blandar
        {
            Card holder = new Card();


            for (int y = 0; y < 4; y++)//Går igen dem olika sorterna på korten
            {
                for (int x = 0; x < 13; x++)//Går igenom alla 13 korten i varje sort
                {
                    int indexNr = random.Next(52);

                    holder = _deck[indexNr];//Sätter det slumpvalda kortet till holder
                    _deck.RemoveAt(indexNr);//Tar bort slumpkortet från listan
                    _deck.Add(holder);//Lägger till kortet som holder har igen alltså det slumpvalda kortet


                }
            }
        }
        public Card GiveAwayCard()//Skapar upp ett nytt kort. sätter första kortet i listan till den. Tar bort kortet från listan sen return kortet
        {
            Card givecard = new Card();// Skapar upp ett nytt kort som heter givecard
            givecard = deck[0];//Sätter givecard till det första kortet i listan
            deck.RemoveAt(0);//Tar bort första kortet i listan som alltså är givecard
            return givecard;//Skickar(Returna)givecard till den som använder denna metoden
        }
        public void PrintDealerCard()
        {
            foreach (var item in DealerCard)//Går igenom dealerns hand och skriver ut varje kort den har
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("DealerCard: "+item);
                Console.ForegroundColor = ConsoleColor.White;
                
               
            }
        }
    }
}
