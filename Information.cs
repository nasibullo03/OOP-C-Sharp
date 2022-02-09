using System;

namespace OOP_in_C_ {
  class Information {

    public string name;
    public string author;
    public string[] keywords;
    public string theme;
    public string path;

    public Information(string name, string author, string[] keywords, string theme, string path) {
      this.setValues(name, author, keywords, theme, path);
    }

    public Information(string name) => this.name = name;
    public Information() {}

    public void setValues(string name, string author, string[] keywords, string theme, string path) {
      this.name = name;
      this.author = author;
      this.keywords = keywords;
      this.theme = theme;
      this.path = path;

    }

    public void printValues() {
      string keywordsText = "";

      foreach(string el in keywords) {
        if (keywordsText == "") {
          keywordsText = el;
        } else {
          keywordsText += ", " + el;
        }

      }

      Console.Write("Имя: ");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(this.name);

      Console.ResetColor();
      Console.Write("Автор: ");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(this.author);

      Console.ResetColor();
      Console.Write("Ключевые слова:");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(keywordsText);

      Console.ResetColor();
      Console.Write("Тематика: ");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(this.theme);

      Console.ResetColor();
      Console.Write("Путь к файлу: ");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(this.path);
      Console.ResetColor();

    }

  }
}