using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
   public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book("C#" , 34.00M),
                new Book("Java" , 46.00M),
                new Book("Python" , 78.00M),
                new Book("React" , 90.00M),
                new Book("C" , 100.00M),
                new Book("C++" , 203.00M),


            };
        }
    }
}
