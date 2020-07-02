using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Token
    {
        static private string applicationName;
        static private string apiKey;
        static public string ApplicationName
        {
            get
            {
                return applicationName;
            }
            set
            {
                applicationName = "ISBNBookSearch";
            }
        }
        static public string ApiKey
        {
            get
            {
                return apiKey;

            }
            set
            {
                apiKey = "AIzaSyCAwVmrItZ-t1MEx_rJPtU0oOgoc6TLia4";
            }
        }
    }
    //kelas ini digunakan mencari buku berdasaarkan isbn dari api  
    class BookSearch
    {
        public static async Task<Volume> SearchISBN(string isbn)
        {
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
                ApplicationName = Token.ApplicationName,
                ApiKey = Token.ApiKey,
            });
    }
}
