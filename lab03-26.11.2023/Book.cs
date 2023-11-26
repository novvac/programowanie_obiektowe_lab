using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Book
    {
        private string title { get; set; }
        private Person author { get; set; }
        private string releaseDate { get; set; }

        public Book(string title, Person author, string releaseDate)
        {
            this.title = title;
            this.author = author;
            this.releaseDate = releaseDate;
        }

        public void View()
        {
            Console.Write($"{this.title} - {this.releaseDate} - ");
            author.View();
        }
    }
}
