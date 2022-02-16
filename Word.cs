using System;

namespace OOP_in_C_
{
    class Word : Information
    {
        public string DateOfCreation { get; set; }
        public string DateOfChange { get; set; }
        public string Size { get; set; }
        public string Password { get; set; }

        public Word() { }

        public Word(
            string Name,
            string Author,
            String[] Keywords,
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

        public Word(string Name, string Author, string[] Keywords, string Theme, string Path)
            : base(Name, Author, Keywords, Theme, Path) { }

        public Word(string Name) : base(Name) { }

        public override void PrintValues()
        {
            string ParameterValue = "";

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Тип файла: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DOC");

            if (this.DateOfCreation == "")
            {
                ParameterValue = "Не определен!";
            }
            else
            {
                ParameterValue = this.DateOfCreation;
            }

            base.Print("Дата создания: ", ParameterValue);
            ParameterValue = "";

            if (this.DateOfChange == "")
            {
                ParameterValue = "Не определен!";
            }
            else
            {
                ParameterValue = this.DateOfChange;
            }

            base.Print("Дата изменения: ", ParameterValue);
            ParameterValue = "";

            if (this.Size == "")
            {
                ParameterValue = "Не определен!";
            }
            else
            {
                ParameterValue = this.Size;
            }
            base.Print("Размер файла: ", ParameterValue);
            ParameterValue = "";

            if (this.Password == "")
            {
                ParameterValue = "Не существует!";
            }
            else
            {
                ParameterValue = this.Password;
            }

            base.Print("Пароль: ", ParameterValue);

            Console.ResetColor();
        }
    }
}
