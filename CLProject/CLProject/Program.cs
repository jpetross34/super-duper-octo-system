using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CLProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\n------------------------------------------------------------------------");

            string isbn = "0071807993";
            var output = BookSearch.SearchISBN(isbn);
            var result = output.Result;

            Console.WriteLine("\n------------------------------------------------------------------------");
            Console.WriteLine("Book Name: \t" + result.VolumeInfo.Title);
            Console.WriteLine("Author: \t" + result.VolumeInfo.Authors.FirstOrDefault());
            Console.WriteLine("Publisher: \t" + result.VolumeInfo.Publisher);
        }
    }
}
