using System;
using CsvHelper;

namespace Lab01
{
    class Program
    {
        private static void Main(string[] args)
        {
            Go();
        }

        private static void Go()
        {
            Card[] cards = FileExtensions.GetCards();
            CardHolder[] holders = FileExtensions.GetHolders();

            foreach (var obj in cards )
            {
                foreach (var man in holders)
                {
                    if (obj.id == man.id)
                    {
                        obj.AddObserver(man.Update);
                        obj.AddEvent(man.Event);
                    }
                }
            }

            foreach (var obj in holders)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("____________________________________________");

            cards[0]._money = -100;
            cards[1]._money = -1000;

            foreach (var obj in holders )
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("____________________________________________");

        }

    }
}
