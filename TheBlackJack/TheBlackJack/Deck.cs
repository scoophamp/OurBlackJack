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


        public Deck()
        {
            this._deck = new List<Card>();
            //U+2665=hjärter
            _deck.Add(new Card('\u2665', "2", 2));
            _deck.Add(new Card('\u2665', "3", 3));
            _deck.Add(new Card('\u2665', "4", 4));
            _deck.Add(new Card('\u2665', "5", 5));
            _deck.Add(new Card('\u2665', "6", 6));
            _deck.Add(new Card('\u2665', "7", 7));
            _deck.Add(new Card('\u2665', "8", 8));
            _deck.Add(new Card('\u2665', "9", 9));
            _deck.Add(new Card('\u2665', "10", 10));
            _deck.Add(new Card('\u2665', "J", 10));
            _deck.Add(new Card('\u2665', "Q", 10));
            _deck.Add(new Card('\u2665', "K", 10));
            //U+2666=ruter
            _deck.Add(new Card('\u2666', "2", 2));
            _deck.Add(new Card('\u2666', "3", 3));
            _deck.Add(new Card('\u2666', "4", 4));
            _deck.Add(new Card('\u2666', "5", 5));
            _deck.Add(new Card('\u2666', "6", 6));
            _deck.Add(new Card('\u2666', "7", 7));
            _deck.Add(new Card('\u2666', "8", 8));
            _deck.Add(new Card('\u2666', "9", 9));
            _deck.Add(new Card('\u2666', "10", 10));
            _deck.Add(new Card('\u2666', "J", 10));
            _deck.Add(new Card('\u2666', "Q", 10));
            _deck.Add(new Card('\u2666', "K", 10));
            //'\u2663'=klöver
            _deck.Add(new Card('\u2663', "2", 2));
            _deck.Add(new Card('\u2663', "3", 3));
            _deck.Add(new Card('\u2663', "4", 4));
            _deck.Add(new Card('\u2663', "5", 5));
            _deck.Add(new Card('\u2663', "6", 6));
            _deck.Add(new Card('\u2663', "7", 7));
            _deck.Add(new Card('\u2663', "8", 8));
            _deck.Add(new Card('\u2663', "9", 9));
            _deck.Add(new Card('\u2663', "10", 10));
            _deck.Add(new Card('\u2663', "J", 10));
            _deck.Add(new Card('\u2663', "Q", 10));
            _deck.Add(new Card('\u2663', "K", 10));
            //U+2660=spader
            _deck.Add(new Card('\u2660', "2", 2));
            _deck.Add(new Card('\u2660', "3", 3));
            _deck.Add(new Card('\u2660', "4", 4));
            _deck.Add(new Card('\u2660', "5", 5));
            _deck.Add(new Card('\u2660', "6", 6));
            _deck.Add(new Card('\u2660', "7", 7));
            _deck.Add(new Card('\u2660', "8", 8));
            _deck.Add(new Card('\u2660', "9", 9));
            _deck.Add(new Card('\u2660', "10", 10));
            _deck.Add(new Card('\u2660', "J", 10));
            _deck.Add(new Card('\u2660', "Q", 10));
            _deck.Add(new Card('\u2660', "K", 10));

            _deck.Add(new Card('\u2665', "A", 11));//Hjärter ess
            _deck.Add(new Card('\u2666', "A", 11));//Ruter ess
            _deck.Add(new Card('\u2663', "A", 11));//Klöver ess
            _deck.Add(new Card('\u2660', "A", 11));//Spader ess
        }
        public List<Card> giveDeck()
        {
            return _deck;
        }




    }


}
