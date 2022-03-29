using System;
using System.Collections.Generic;
using System.Text;
using unitask043.Exceptions;

namespace unitask043.Models
{
    class Library
    {
        public int BookLimit { get; set; }
        List<Book> Books = new List<Book>();

        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
        }

        public void AddBook(Book book)
        {
            if (Books.Count < BookLimit)
            {
                Books.Add(book);
                return;
            }

            throw new CapacityLimitException("limiti kecdiz");
        }

        public void GetBookById(int? id)
        {
            foreach (var item in Books)
            {
                if (id == item.Id)
                {
                    Console.WriteLine($"Id: {item.Id}\nName: {item.Name}\nAuthorName: {item.AuthorName}\nPageCount: {item.PageCount}\nPrice: {item.Price}\nCount: {item.Count}");
                    return;
                }
            }

            throw new NullReferenceException("Bele bir mehsul yoxdur");
        }

        public void RemoveById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Id gonderin");
            }
            else
            {
                foreach (var item in Books)
                {
                    if(id == item.Id)
                    {
                        Books.Remove(item);
                        return;
                    }
                }
            }

            throw new NotFoundException("Bele bir mehsul yoxdur");

        }


    }

}
