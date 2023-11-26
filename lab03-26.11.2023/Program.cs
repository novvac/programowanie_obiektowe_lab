using System;

namespace lab3
{
    class Lab3
    {
        static void Main(string[] args)
        {
            Person author = new Person("Stephen", "King", 57);
            Book book1 = new Book("Title of example book", author, "2020-03-05");

            book1.View();
        }
    }
}