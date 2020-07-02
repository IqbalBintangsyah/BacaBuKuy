using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_PBO
{
    class BookSearch
    {
        public static async Task<Volume> SearchISBN(string isbn)
        {
            Console.WriteLine("Executing a book search request…");
            var result = await service.Volumes.List(isbn).ExecuteAsync();
            if (result != null && result.Items != null)
            {
                var item = result.Items.FirstOrDefault();
                return item;
            }
            return null;
        }
        public static BooksService service = new BooksService(
            new BaseClientService.Initializer
            {
                ApplicationName = "ISBNBookSearch",
                ApiKey = "AIzaSyCAwVmrItZ-t1MEx_rJPtU0oOgoc6TLia4",
            });
    }
}
