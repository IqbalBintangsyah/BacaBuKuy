using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1_PBO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BookApi bookApi = new BookApi("]");
            Console.WriteLine(bookApi.Search("0071807993", 1, 1));
            Console.ReadLine();*/
            string isbn = "0618001913";
            var output = BookSearch.SearchISBN(isbn);

            Assert.AreEqual(output.Result != null, true);

            var result = output.Result;
            Console.WriteLine("\nBook Name: " + result.VolumeInfo.Title);
            Console.WriteLine("Author: " + result.VolumeInfo.Authors.FirstOrDefault());
            Console.WriteLine("Publisher: " + result.VolumeInfo.Publisher);

        }
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
            public string Subtitle
            {
                get;
                set;
            }
            public string Description
            {
                get;
                set;
            }
            public int? PageCount
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
            public Tuple<int?, List<BookModel>> Search(string query, int offset, int count)
            {
                var listquery = _booksService.Volumes.List(query);
                listquery.MaxResults = count;
                listquery.StartIndex = offset;
                var res = listquery.Execute();
                var books = res.Items.Select(b => new BookModel
                {
                    Id = b.Id,
                    Title = b.VolumeInfo.Title,
                }).ToList();
                return new Tuple<int?, List<BookModel>>(res.TotalItems, books);
            }
        }

}
