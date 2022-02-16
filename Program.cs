using System;
using System.Collections.Generic;

namespace OOP_in_C_
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<PDF> PDF_Format = new List<PDF>();

            Console.Clear();
            PDF_Format.Add(new PDF());
            PDF_Format[0].Name = "Идиот или гений?";
            PDF_Format[0].Author = "Мелани Митчелл";
            PDF_Format[0].Theme = "Нейронные сети";
            PDF_Format[0].Keywords = new string[] { "Нейронные сети", "Искусственный интеллект" };
            PDF_Format[0].Path = "https://u.to/hkP_Gw";
            PDF_Format[0].DateOfCreation = "2022";
            PDF_Format[0].DateOfChange = "";
            PDF_Format[0].Password = "";
            PDF_Format[0].Size = "";
            PDF_Format[0].PrintValues();

            PDF_Format.Add(new PDF());
            PDF_Format[1].Name = "C# 9.0. Карманный справочник";
            PDF_Format[1].Author = "Джозеф Албахари, Бен Албахари";
            PDF_Format[1].Theme = "C# 9.0. Карманный справочник";
            PDF_Format[1].Keywords = new string[] { "C#" };
            PDF_Format[1].Path = "https://u.to/eVoCHA";
            PDF_Format[1].DateOfCreation = "2021";
            PDF_Format[1].DateOfChange = "";
            PDF_Format[1].Password = "";
            PDF_Format[1].Size = "1 Mb";
            PDF_Format[1].PrintValues();

            PDF_Format.Add(new PDF());
            PDF_Format[2].Name = "C# 7.0. Карманный справочник";
            PDF_Format[2].Author = "Джозеф Албахари, Бен Албахари";
            PDF_Format[2].Theme = "C# 9.0. Карманный справочник";
            PDF_Format[2].Keywords = new string[] { "C#" };
            PDF_Format[2].Path = "https://u.to/9GACHA";
            PDF_Format[2].DateOfCreation = "2017";
            PDF_Format[2].DateOfChange = "";
            PDF_Format[2].Password = "";
            PDF_Format[2].Size = "10 Mb";
            PDF_Format[2].PrintValues();

            Console.ReadKey();
        }
    }
}
