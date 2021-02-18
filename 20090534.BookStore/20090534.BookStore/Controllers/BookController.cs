using _20090534.BookStore.Models;
using _20090534.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20090534.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository=null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public /*List<BookModel>*/ ViewResult GetAllBooks()
        {
           var data= _bookRepository.GetAllBooks();
           return View();
        }

        // to get a book from a list of book in database , suppose we have 5 books we will create a generic method where
        // this actionmethod will work for all the ids
         public BookModel getbook(int id)
        {
            return _bookRepository.GetBookById(id);
         }
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }

    }
}
