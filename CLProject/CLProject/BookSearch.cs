using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLProject
{
    public static class BookSearch
    {
        public static BooksService service = new BooksService(new BaseClientService.Initializer)
        {
            ApplicationName = "ISBNBookSearch";
            ApiKey = "AIzaSyBqpPwjvFuErq4UOaA1Z2o0fIkKkCi0miU";
        }

        public static async Task<Volume> SearchISBN(string isbn)
        {
            Console.WriteLine("Executing a book search request...");

            var result = await service.Volumes.List(isbn).ExecuteAsync();

            if (result != null && result.Items != null)
            {
                var item = result.Items.FirstOrDefault();

                return item;
            }

            return null;
        }
    }
}
