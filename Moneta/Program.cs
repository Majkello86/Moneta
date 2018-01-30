using System;


namespace Moneta
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("***Witam w symulacji rzutu monetą***");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
          

            string decyzja;
            Console.WriteLine("Aby rzucić monetą nacisnij t lub n aby wyjsc");
            decyzja = Console.ReadLine();
            while (decyzja=="t")
            {
                System.Threading.Thread.Sleep(1500);
                Random randomNumbers = new Random();
                int status = randomNumbers.Next(0, 2);

                if (status == 0)
                {
                    Console.WriteLine("Orzel");
                }
                else { Console.WriteLine("Reszka"); }
                Console.WriteLine("Czy powtórzyć? t/n");
                decyzja = Console.ReadLine();
               

            }

            
        }
    }
}
