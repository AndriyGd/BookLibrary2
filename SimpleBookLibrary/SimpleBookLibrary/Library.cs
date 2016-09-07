using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookLibrary
{
    class Library
    {
        private readonly List<Book> _books;

        public int CountBook => _books.Count;

        public Library()
        {
            _books = new List<Book>();
        }

        public Book this[int index] => _books[index];

        public void AddBook(Book book)
        {
            _books.Add(book);
        }
    }
}
