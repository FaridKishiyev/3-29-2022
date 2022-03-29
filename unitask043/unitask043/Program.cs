using System;
using unitask043.Models;
using unitask043.Exceptions;

namespace unitask043
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Cinayet", 15, "Ilkin",200,2);
            Book book2 = new Book("Kiber tehluke", 13, "Ehmed", 187, 40);
            Book book3 = new Book("Qeddar pisik", 17, "Kamal", 306, 70);

            Library lib1 = new Library(15);
            lib1.AddBook(book1);
            lib1.AddBook(book2);
            lib1.AddBook(book3);

            book3.ShowInfo();

           
            
                
            try
            {
                lib1.RemoveById(5);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            //book3.ShowInfo();
            lib1.GetBookById(1);
        }
    }
}
