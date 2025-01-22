namespace LibraryManagementSystem.Models;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public bool Available { get; set; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Available = true;
    }

    public override string ToString()
    {
        return $"Book: {Title}\nAuthor: {Author}\nISBN: {ISBN}\nAvailable: {Available}";
    }
}