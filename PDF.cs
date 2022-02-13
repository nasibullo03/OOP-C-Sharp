using System;

namespace OOP_in_C_
{
    class PDF : Information
    {

        public string DateOfCreation { get; set; }
        public string DateOfChange { get; set; }
        public string Size { get; set; }
        public string Password { get; set; }

        public PDF() { }
        public PDF(string name, string author, string[] keywords, string theme, string path, string DateOfCreation, string DateOfChange, string Size, string Password)
        : base(name, author, keywords, theme, path)
        {
            this.DateOfCreation = DateOfCreation;
            this.DateOfChange = DateOfChange;
            this.Size = Size;
            this.Password = Password;
        }

        public PDF(string name, string author, string[] keywords, string theme, string path)
        : base(name, author, keywords, theme, path) { }
        public PDF(string name) : base(name) { }

    }
}
