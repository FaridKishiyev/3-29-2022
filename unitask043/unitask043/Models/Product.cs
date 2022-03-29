using System;
using System.Collections.Generic;
using System.Text;

namespace unitask043.Models
{
    abstract class Product
    {
        private static int _id;

        public static int _count;

        public static int _totalInCome;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public int TotalInCome { get; set; } = 0;



        public Product(string name,double price,int count)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            Count = count;
        }

        public abstract void Sell();

        public abstract void ShowInfo();


    }
}
