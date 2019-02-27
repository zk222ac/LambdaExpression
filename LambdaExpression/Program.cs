using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // What is delegate : delegate is a pointer or reference by a method 
            // Func<int , int> --> first one b/w angle bracket is input and last one is output ( return type)
            // Action <int> --> does not return anything but takes zero or more arguments (inputs) 
            // arg => expression 
            //Func<int,int> square = number => number * number;
            //Console.WriteLine(square(5));
            ////Func<int, int> square = GetSquare;
           // Console.WriteLine(GetSquare(5));

            // () => .... No arguments
            // x =>  .... single arguments
            // (x, y) => ... multiple arguments 

            // Factor 
            //const int factor = 5;
            //Func<int, int> multiplier = n => n * factor;
            //Console.WriteLine(multiplier(10));
            //Console.ReadKey();

            var books = new BookRepository().GetBooks();
            var listBook = books.FindAll(b => b.Price < 50);

            //var listBook = books.FindAll(IsCheaperThan100Dollars);
            foreach ( var i in listBook)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        //static int GetSquare(int n)
        //{
        //    return n * n;
        //}

        static bool IsCheaperThan100Dollars(Book book)
        {
            return book.Price < 100;
        }
    }
}
