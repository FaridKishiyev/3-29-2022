using System;
using System.Collections.Generic;
using System.Text;
using unitask043.Exceptions;

namespace unitask043.Models
{
    class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public override void Sell()
        {
            if (Count > 0)
            {
                Count--;
                TotalInCome++;

                return;
            }

            throw new ProductCountIsZeroException("Mehsul bitib.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}\nAuthorName: {AuthorName}\nPageCount: {PageCount}\nPrice: {Price}\nCount: {Count}");
        }

        public Book(string name,double price,string authorName,int pageCount,int count):base(name,price,count)
        {
            AuthorName = authorName;
            PageCount = pageCount;
        }

    }
}
