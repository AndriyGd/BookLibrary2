using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();

            Book b1 = new Book
            {
                Name = "Lacy Starr",
                Author = new Author { Age = 54, Name = "Isaac Asimow"},
                DatePublish = new DateTime(1956, 9, 23),
                Version = 2
            };

            lib.AddBook(b1);

            for (int i = 0; i < lib.CountBook; i++)
            {
                Console.WriteLine(lib[i]);
            }

            Console.ReadKey();
        }
    }
}
