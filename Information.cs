using System;

namespace OOP_in_C_ {
  class Information {

    public string name;
    public string author;
    public string[] keywords;
    public string theme;
    public string path;

    public Information(string _name, string _author, string[] _keywords, string _theme, string _path) {
      setValues(_name, _author, _keywords, _theme, _path);
    }

    public Information() {}

    public void setValues(string _name, string _author, string[] _keywords, string _theme, string _path) {
      name = _name;
      author = _author;
      keywords = _keywords;
      theme = _theme;
      path = _path;

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
      Console.WriteLine(name);

      Console.ResetColor();
      Console.Write("Автор: ");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(author);

      Console.ResetColor();
      Console.Write("Ключевые слова:");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(keywordsText);

      Console.ResetColor();
      Console.Write("Тематика: ");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(theme);

      Console.ResetColor();
      Console.Write("Путь к файлу: ");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(path);
      Console.ResetColor();

    }

  }
}