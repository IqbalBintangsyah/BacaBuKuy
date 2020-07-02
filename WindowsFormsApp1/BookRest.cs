using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
//kelas yang digunakan untuk mengolah api
//kelas tidak terpakai
namespace WindowsFormsApp1
{
    //AIzaSyCAwVmrItZ-t1MEx_rJPtU0oOgoc6TLia4 <- API KEY
    class BookRest
    {
        private string url;
        private string constUrl = "https://www.googleapis.com/books/v1/volumes?q=";

        public BookRest(string url)
        {
            this.url = url;
        }
        public BookRest()
        {
            url = constUrl;
        }
        public BookResult ObtainResult(string judul)
        {
            BookResult bookResult = new BookResult();
            string customURL = string.Format(url + judul + ":keyes&key=AIzaSyCAwVmrItZ-t1MEx_rJPtU0oOgoc6TLia4");
            var client = new RestClient(customURL);
            var request = new RestRequest(Method.GET);
            var response = client.Execute<List<BookResult>>(new RestRequest());
            bookResult = JsonConvert.DeserializeObject<BookResult>(response.Content);
            return bookResult;
        }
        /*public static BookResult GetBukuList(string judul)
        {
            BookResult returnList = new BookResult();
            string customURL = string.Format("https://www.googleapis.com/books/v1/volumes?q=" + judul);
            var client = new RestClient(customURL);
            client.AddDefaultHeader("key", "AIzaSyCAwVmrItZ-t1MEx_rJPtU0oOgoc6TLia4");
            var response = client.Execute<List<BookResult>>(new RestRequest());
            returnList = JsonConvert.DeserializeObject<BookResult>(response.Content);
            foreach(
            return returnList;
        }*/
        /*public static async Task<Volume> SearchISBN(string isbn)
        {
            Volumes result = await service.Volumes.List(isbn).ExecuteAsync();
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
            });*/

        

    }

    public class BookModel
    {
        public string Id
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public IList<string> Author
        {
            get;
            set;
        }
    }
    public class BookApi
    {
        private readonly BooksService _booksService;
        public BookApi(string apiKey)
        {
            _booksService = new BooksService(new BaseClientService.Initializer()
            {
                ApiKey = apiKey,
                ApplicationName = this.GetType().ToString()
            });
        }
        public List<BookModel> Search(string query)
        {
            var listquery = _booksService.Volumes.List(query);
            listquery.MaxResults = 1;
            var res = listquery.Execute();
            var books = res.Items.Select(b => new BookModel
            {
                Id = b.Id,
                Title = b.VolumeInfo.Title,
                Author = b.VolumeInfo.Authors,
            }).ToList();
            return new List<BookModel>(books);
        }
    }
}
