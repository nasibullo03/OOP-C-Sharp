using System;

namespace OOP_in_C_ {
  class Program {
    static void Main(string[] args) {

      Information file = new Information();
      file.name = "Идиот или гений?";
      file.author = "Мелани Митчелл";
      file.keywords = new string[] { "Нейронные сети", "Искусственный интеллект"};
      file.theme = "Нейронные сети";
      file.path = "https://u.to/hkP_Gw";

      Console.Clear();
      file.printValues();
      
    }

  }
}