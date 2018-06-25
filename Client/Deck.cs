using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Deck
    {
        List<Card> cardDeck = new List<Card>();


        public void generateCardDeck()
        {
            int tempFigure = 1;
            int value = 2;
            String tempNameFigure = "Jack";
            Card card = new Card();
            for (int i = 0; i < 52; i++)
            {
                if (tempFigure <= 10)
                {
                    if (i % 4 == 0)
                    {
                        tempFigure++;
                    }
                    if (i % 4 == 0&& tempFigure<=10)
                    {
                        card = new Card(tempFigure.ToString(), "Clubs", tempFigure);
                    }
                    else if (i % 4 == 1)
                    {
                        card = new Card(tempFigure.ToString(), "Diamonds", tempFigure);
                    }
                    else if (i % 4 == 2)
                    {
                        card = new Card(tempFigure.ToString(), "Hearts", tempFigure);
                    }
                    else if (i % 4 == 3)
                    {
                        card = new Card(tempFigure.ToString(), "Spades", tempFigure);
                    }
                    cardDeck.Add(card);
                }
                else
                {
                    
                          if (i % 4 == 0)
                    {
                        tempFigure++;
                        if(tempFigure==12)
                        {
                            tempNameFigure = "Queen";
                            value = 10;
                        }
                        else if (tempFigure == 13)
                        {
                            tempNameFigure = "King";
                            value = 10;
                        }
                        else if (tempFigure == 14)
                        {
                            tempNameFigure = "As";
                            value = 11;
                        }
                    }
                    if (i % 4 == 0)
                    {
                        card = new Card(tempNameFigure, "Clubs", value);
                    }
                    else if (i % 4 == 1)
                    {
                        card = new Card(tempNameFigure, "Diamonds", value);
                    }
                    else if (i % 4 == 2)
                    {
                        card = new Card(tempNameFigure, "Hearts", value);
                    }
                    else if (i % 4 == 3)
                    {
                        card = new Card(tempNameFigure, "Spades", value);
                    }
                    cardDeck.Add(card);
                }
            }
        }
        public void displayDeck()
        {
            foreach (Card card in cardDeck)
            {
                Console.WriteLine(card.Figure+card.Color+card.Value);
            }
        }
    }
}
