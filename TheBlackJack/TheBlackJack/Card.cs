using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBlackJack
{
    class Card
    {
        public List<string> cards = new List<string>();
        //public int _value { get; set; }
        //public string _suit { get; set; }
        public void AddCardToList()
        {
            //U+2665=hjärter
            cards.Add('\u2665' + "2");
            cards.Add('\u2665' + "3");
            cards.Add('\u2665' + "4");
            cards.Add('\u2665' + "5");
            cards.Add('\u2665' + "6");
            cards.Add('\u2665' + "7");
            cards.Add('\u2665' + "8");
            cards.Add('\u2665' + "9");
            cards.Add('\u2665' + "10");
            cards.Add('\u2665' + "J");
            cards.Add('\u2665' + "Q");
            cards.Add('\u2665' + "K");
            //U+2666=ruter
            cards.Add('\u2666' + "2");
            cards.Add('\u2666' + "3");
            cards.Add('\u2666' + "4");
            cards.Add('\u2666' + "5");
            cards.Add('\u2666' + "6");
            cards.Add('\u2666' + "7");
            cards.Add('\u2666' + "8");
            cards.Add('\u2666' + "9");
            cards.Add('\u2666' + "10");
            cards.Add('\u2666' + "J");
            cards.Add('\u2666' + "Q");
            cards.Add('\u2666' + "K");
            //'\u2663'=klöver
            cards.Add('\u2663' + "2");
            cards.Add('\u2663' + "3");
            cards.Add('\u2663' + "4");
            cards.Add('\u2663' + "5");
            cards.Add('\u2663' + "6");
            cards.Add('\u2663' + "7");
            cards.Add('\u2663' + "8");
            cards.Add('\u2663' + "9");
            cards.Add('\u2663' + "10");
            cards.Add('\u2663' + "J");
            cards.Add('\u2663' + "Q");
            cards.Add('\u2663' + "K");
            //U+2660=spader
            cards.Add('\u2660' + "2");
            cards.Add('\u2660' + "3");
            cards.Add('\u2660' + "4");
            cards.Add('\u2660' + "5");
            cards.Add('\u2660' + "6");
            cards.Add('\u2660' + "7");
            cards.Add('\u2660' + "8");
            cards.Add('\u2660' + "9");
            cards.Add('\u2660' + "10");
            cards.Add('\u2660' + "J");
            cards.Add('\u2660' + "Q");
            cards.Add('\u2660' + "K");

            cards.Add('\u2665' + "A");//Hjärter ess
            cards.Add('\u2666' + "A");//Ruter ess
            cards.Add('\u2663' + "A");//Klöver ess
            cards.Add('\u2660' + "A");//Spader ess

        }
    }
}
