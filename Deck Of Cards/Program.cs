using System;

namespace Deck_Of_Cards
{
    class Program
    {
        class card
        {
            private string[] names = new string[52];
            public string this[int index]
            { 
                get { return names[index];       }
                set { names[index] = value;              }
            }
        }
        static void Main(string[] args)
        {
            
            //Declaration done here:
            string title = "temp";

            string[] suitArr = { "Clubs", "Spades", "Diamonds", "Hearts", };

            string[] cardArr = { "Ace", "King", "Queen", "Jack", "10", "9", "8", "7", "6", "5", "4", "3", "2", };

            int z = 0;
            card c = new card(); // array of objects
// create property of each card
            
            for (int x = 0; x < 13; x++)
            {
                title = cardArr[x] + " of temp";
                {}
                for (int y = 0; y < 4; y++)
                {
                    title = title.Replace("temp", suitArr[y]); 
                    c[z] = title;
                    z++;
                    title = title.Replace(suitArr[y], "temp");
                }
            }

            for (int p = 0; p < 52; p++) // print each object
            {
                Console.WriteLine(c[p]);
            }

            Console.ReadLine();
        }
    }
}
