using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookLibrary
{
    class Book
    {
        public string Name { get; set; }
        public Author Author { get; set; }
        public int Version { get; set; }
        public DateTime DatePublish { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nAuthor: {Author.Name}\nVersion: {Version}\nDate publish: {DatePublish.Date}";
        }
    }
}
