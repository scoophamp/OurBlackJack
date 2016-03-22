using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBlackJack
{
    class Player
    {
        
        public int _PlayerBet { get; set; }
        public int _PlayerAmount { get; set; }
        public List<Card> PlayerCard {get; set; }
      
        Deck deck = new Deck();

       public Player()
        {
            this._PlayerAmount = 100;
            this.PlayerCard = new List<Card>();
        }
        public Player(List<Card> deck)
        {
            this.PlayerCard = deck;
        }
        public void AddCard(Card card)
        {
            
            PlayerCard.Add(card);
        }
        public void Stay()
        {
            foreach (var item in PlayerCard)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("PlayerCard: " + item);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void PrintPlayerCard()
        {
            foreach (var item in PlayerCard)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("PlayerCard: "+item);
                Console.ForegroundColor = ConsoleColor.White;


            }
        }
    }
}
