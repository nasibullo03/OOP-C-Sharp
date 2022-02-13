using System;

namespace OOP_in_C_ {
    class HTML: Information {
        public string DateOfCreation {
            get;
            set;
        }
        public string DateOfChange {
            get;
            set;
        }
        public string Size {
            get;
            set;
        }
        public HTML() {}
        public HTML(string name, string author, string[] keywords, string theme, string path, string DateOfCreation, string DateOfChange, string Size): base(name, author, keywords, theme, path) {
            this.DateOfCreation = DateOfCreation;
            this.DateOfChange = DateOfChange;
            this.Size = Size;
        }

        public HTML(string name, string author, string[] keywords, string theme, string path): base(name, author, keywords, theme, path) {}
        public HTML(string name): base(name) {}

        private void Print(string parameter, string parameterValue) {
            Console.ResetColor();
            Console.Write(parameter);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(parameterValue);
        }
        public void printValues() {
            string parameterValue = "";

            foreach(string el in base.Keywords) {
                if (parameterValue == "") {
                    parameterValue = el;
                } else {
                    parameterValue += ", " + el;
                }

            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Тип файла: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("HTML");

            Print("Имя: ", base.Name);
            Print("Автор: ", base.Author);
            Print("Ключевые слова: ", parameterValue);
            Print("Тематика: ", base.Theme);
            Print("Путь к файлу: ", base.Path);
            parameterValue = "";

            if (this.DateOfCreation == "") {
                parameterValue = "Не определен!";
            } else {
                parameterValue = this.DateOfCreation;
            }

            Print("Дата создания: ", parameterValue);
            parameterValue = "";

            if (this.DateOfChange == "") {
                parameterValue = "Не определен!";
            } else {
                parameterValue = this.DateOfChange;
            }

            Print("Дата изменения: ", parameterValue);
            parameterValue = "";

            if (this.Size == "") {
                parameterValue = "Не определен!";
            } else {
                parameterValue = this.Size;
            }
            Print("Размер файла: ", parameterValue);
            parameterValue = "";

            Console.ResetColor();

        }
    }
}