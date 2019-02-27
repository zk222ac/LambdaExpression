using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
   public class Book
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

        public Book(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Price: {Price}";
        }
    }
}
