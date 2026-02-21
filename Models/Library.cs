using System.Collections.Generic;
namespace Library_Web_App_ASP.NET_Core_MVC_.Models
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();

        public void AddBook(Book book) => Books.Add(book);

        public Book? SearchBook(string title)
        {
            return Books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}
