using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Reader : Person
    {
        private string firstName;
        private string lastName;
        public List<Book> books;

        public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.books = new List<Book>();
        }

        public void ViewBook()
        {
            Console.WriteLine($"Książki czytelnika: {base.ToString()}");

            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
