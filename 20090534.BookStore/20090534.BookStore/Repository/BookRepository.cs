using _20090534.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20090534.BookStore.Repository
{
    public class BookRepository
    {
        // to get all books from database 
        public List<BookModel> GetAllBooks()
        {
            return DataSource();       
        }
        
        // incase we get the data from datasource then we will take if there is no data related to particular id then we get null
        public BookModel GetBookById(int id)
          {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        // to search books
        public List<BookModel> SearchBook(string title, string authorName)
        {
            /* return DataSource().Where(x => x.Title == title && x.Author == authorName).ToList();*/
            // for mv also if we want to get then we use 
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();


        }
       // in real we get data from database but here we willl get it through some data source
       private List<BookModel> DataSource()
        {
            return new List<BookModel>()
                {
                    new BookModel(){Id=1,Title="MVC",Author="Nitish"},
                    new BookModel(){Id=1,Title="MVC",Author="monika"},
                    new BookModel(){Id=1,Title="c#",Author="Nitish"},
                    new BookModel(){Id=1,Title="java",Author="webgentle"}

                };
        }
    }
} 
