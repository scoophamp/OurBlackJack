using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBlackJack
{
    class BlackJackGame
    {
        Card card = new Card();
        Dealer dealer = new Dealer();
        Deck deck = new Deck();
        Player player = new Player();
        Rules rules = new Rules();
        Amount amount = new Amount();
     
        
        public void Meny()
        {
            Console.WriteLine("Welcome to Black Jack");
            Console.WriteLine("You start at " + player._MyAmount + " coins.");
            Console.WriteLine("How much do you wanna bet?");

            player._myBet = int.Parse(Console.ReadLine());
            if (player._myBet > amount._myAmount)
            {
             
            while (true)
            {
                Console.WriteLine("You can't bet more than your amount");
            }
            }
            Console.WriteLine("You've betted " + player._myBet);

            Console.ReadLine();
        }  
}
}
