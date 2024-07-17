using System;
using System.Globalization;
namespace Project1_ContactNumbers
{
    public class ContactModel
    {
        private string name;
        private string surname;
        private int number;

        public int Number { get => number; set => number = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public ContactModel(string name, string surname, int number)
        {
            this.Number = number;
            this.Name = name;
            this.Surname = surname;
        }
    }
}