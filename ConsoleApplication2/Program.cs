using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide number cards to play:");
            int maxCards = int.Parse(Console.ReadLine());

            var queue = new  Queue<int>();
            var results = new List<int>();

            //initalizes queue and results
            for (int i = 0; i < maxCards; i++)
            {
                queue.Enqueue(i);
                results.Add(i);
            }

            for (int i = 0; i < maxCards; i++)
            {
                var firstCard = queue.Dequeue();

                if (queue.Count != 0)
                {
                    //send first card to last
                    queue.Enqueue(firstCard);

                    var resultCard = queue.Dequeue();
                    results[resultCard] = i + 1;
                }
                else
                {
                    results[firstCard] = i + 1;
                }
            }

            Console.WriteLine("Arrange Cards in below order and start play");
            
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
