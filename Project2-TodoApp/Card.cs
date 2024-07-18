using System.Collections.Generic;

namespace Project2_TodoApp
{
    public class Card
    {
        private string _title;
        private string _content;
        private string _size;
        private string _people;

        public string Title { get => _title; set => _title = value; }
        public string Content { get => _content; set => _content = value; }
        public string Size { get => _size; set => _size = value; }
        public string People { get => _people; set => _people = value; }

        public Card(string title, string content, string size)
        {
            this._title = title;
            this._content = content;
            this._size = size;
        }

        public Card(string title, string content, string size, string people)
        {
            this._people = people;
            this._title = title;
            this._content = content;
            this._size = size;
        }

    }
}