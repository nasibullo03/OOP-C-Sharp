using System;

namespace OOP_in_C_
{
    class TXT : Information
    {
        public string DateOfCreation { get; set; }

        public string DateOfChange { get; set; }

        public string Size { get; set; }

        public TXT() { }

        public TXT(
            string Name,
            string Author,
            string[] Keywords,
            string Theme,
            string Path,
            string DateOfCreation,
            string DateOfChange,
            string Size
        ) : base(Name, Author, Keywords, Theme, Path)
        {
            this.DateOfCreation = DateOfCreation;
            this.DateOfChange = DateOfChange;
            this.Size = Size;
        }

        public TXT(string Name, string Author, string[] Keywords, string Theme, string Path)
            : base(Name, Author, Keywords, Theme, Path) { }

        public TXT(string Name) : base(Name) { }

        private void Print(string Parameter, string ParameterValue)
        {
            Console.ResetColor();
            Console.Write(Parameter);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ParameterValue);
        }

        public void printValues()
        {
            string ParameterValue = "";

            foreach (string el in base.Keywords)
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
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Тип файла: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("HTML");

            Print("Имя: ", base.Name);
            Print("Автор: ", base.Author);
            Print("Ключевые слова: ", ParameterValue);
            Print("Тематика: ", base.Theme);
            Print("Путь к файлу: ", base.Path);
            ParameterValue = "";

            if (this.DateOfCreation == "")
            {
                ParameterValue = "Не определен!";
            }
            else
            {
                ParameterValue = this.DateOfCreation;
            }

            Print("Дата создания: ", ParameterValue);
            ParameterValue = "";

            if (this.DateOfChange == "")
            {
                ParameterValue = "Не определен!";
            }
            else
            {
                ParameterValue = this.DateOfChange;
            }

            Print("Дата изменения: ", ParameterValue);
            ParameterValue = "";

            if (this.Size == "")
            {
                ParameterValue = "Не определен!";
            }
            else
            {
                ParameterValue = this.Size;
            }
            Print("Размер файла: ", ParameterValue);
            ParameterValue = "";

            Console.ResetColor();
        }
    }
}
