using System;

namespace OOP_in_C_
{
	class Information
	{
		public string Name { get; set; }
		public string Author { get; set; }
		public string[] Keywords { get; set; }
		public string Theme { get; set; }
		public string Path { get; set; }

		public Information(string Name, string Author, string[] Keywords, string Theme, string Path)
		{
			this.SetValues(Name, Author, Keywords, Theme, Path);
		}

		public Information(string Name) => this.Name = Name;

		public Information() { }

		public void SetValues(
			string Name,
			string Author,
			string[] Keywords,
			string Theme,
			string Path
		)
		{
			this.Name = Name;
			this.Author = Author;
			this.Keywords = Keywords;
			this.Theme = Theme;
			this.Path = Path;
		}
		
		protected virtual void Print(string Parameter, string ParameterValue)
		{
			Console.ResetColor();
			Console.Write(Parameter);
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine(ParameterValue);
		}

		public virtual void PrintValues()
		{
			string ParameterValue = "";

			foreach (string el in Keywords)
			{
				if (ParameterValue == "")
				{
					ParameterValue = el;
				}
				else
				{
					ParameterValue += ", " + el;
				}
			}
			
			Print("Имя: ", Name);
			Print("Автор: ", Author);
			Print("Ключевые слова: ", ParameterValue);
			Print("Тематика: ", Theme);
			Print("Путь к файлу: ", Path);
			ParameterValue = "";
			
			Console.ResetColor();
		}
	}
}
