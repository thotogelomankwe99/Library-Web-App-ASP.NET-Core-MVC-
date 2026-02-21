using Microsoft.AspNetCore.Mvc;
using Library_Web_App_ASP.NET_Core_MVC_.Models;

namespace Library_Web_App_ASP.NET_Core_MVC_.Controllers
{
    public class LibraryController: Controller
    {
        private static Library myLibrary = new Library();

        public IActionResult Index()
        {
            return View(myLibrary);
        }

        [HttpPost]
        public IActionResult AddBook(string title, string author)
        {
            myLibrary.AddBook(new Book { Title = title, Author = author });
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult BorrowBook(string title)
        {
            var book = myLibrary.SearchBook(title);
            if (book != null && !book.IsBorrowed)
                book.Borrow();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ReturnBook(string title)
        {
            var book = myLibrary.SearchBook(title);
            if (book != null && book.IsBorrowed)
                book.Return();
            return RedirectToAction("Index");
        }
    }
}

