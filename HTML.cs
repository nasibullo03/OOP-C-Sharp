using System;

namespace OOP_in_C_
{
    class HTML : Information
    {
        public string DateOfCreation { get; set; }

        public string DateOfChange { get; set; }

        public string Size { get; set; }

        public HTML() { }

        public HTML(
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

        public HTML(string Name, string Author, string[] Keywords, string Theme, string Path)
            : base(Name, Author, Keywords, Theme, Path) { }

        public HTML(string Name) : base(Name) { }

        public override void PrintValues()
        {
            string ParameterValue = "";

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Тип файла: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("HTML");

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

            Console.ResetColor();
        }
    }
}
