using System;

namespace OOP_in_C_ {
  class Program {
    static void Main(string[] args) {

      Information file = new Information();
      file.Name = "Идиот или гений?";
      file.Author = "Мелани Митчелл";
      file.Keywords = new string[] {
        "Нейронные сети",
        "Искусственный интеллект"
      };
      file.Theme = "Нейронные сети";
      file.Path = "https://u.to/hkP_Gw";

      Console.Clear();

      file.printValues();

      Console.ReadKey();
    }

  }
}