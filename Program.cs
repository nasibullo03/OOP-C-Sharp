using System;

namespace OOP_in_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            PDF book = new PDF();
            book.Name = "Идиот или гений?";
            book.Author = "Мелани Митчелл";
            book.Keywords = new string[] { "Нейронные сети", "Искусственный интеллект" };
            book.Theme = "Нейронные сети";
            book.Path = "https://u.to/hkP_Gw";

            Console.Clear();
            book.printValues();

            Console.ReadKey();
        }
    }
}
