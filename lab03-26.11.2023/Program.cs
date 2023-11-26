using System;

namespace lab3
{
    class Lab3
    {
        static void Main(string[] args)
        {
            // Zadanie 1a
            Person author = new Person("Stephen", "King", 57);
            Book book1 = new Book("Title of example book", author, "2020-03-05");

            Console.WriteLine(book1.ToString());

            // Zadanie 1b
            Person author2 = new Person("Jerry", "Smith", 50);

            Book book2 = new Book("The forest 2", author2, "2020-03-05");
            Book book3 = new Book("Humans 2057", author, "2020-03-05");
            Book book4 = new Book("Apollo 11 - The history", author2, "2020-03-05");

            Reader reader1 = new Reader("Morty", "Smitch", 19);
            Reader reader2 = new Reader("John", "Doe", 33);

            reader1.books.Add(book1);
            reader2.books.Add(book2);
            reader2.books.Add(book3);
            reader2.books.Add(book4);

            reader2.ViewBook();
        }
    }
}