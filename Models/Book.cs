namespace Library_Web_App_ASP.NET_Core_MVC_.Models
{
    public class Book
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public bool IsBorrowed { get; set; } = false;

        public void Borrow() => IsBorrowed = true;

        public void Return() => IsBorrowed = false;
    }

    // Optional: ReferenceBook to show inheritance
    public class ReferenceBook : Book
    {
        public ReferenceBook(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public new void Borrow()
        {
            // Reference books cannot be borrowed
        }
    }
}
