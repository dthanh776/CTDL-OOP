using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong2_Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Author[] authors = new Author[2];

            authors[0] = new Author("AAA", "aa@gmail.com");
            authors[1] = new Author("BBB", "bb@gmail.com");

            Book book = new Book("CCC",authors,5.5);
            Console.WriteLine();
            Console.WriteLine(book.toString());
            

            Console.ReadKey();
        }
    }
}
