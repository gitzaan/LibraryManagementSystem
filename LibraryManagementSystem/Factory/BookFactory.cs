using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Factory;

public class BookFactory
{
    public static Book CreateBook(string type, string title, string author, string isbn, int? fileSize = null)
    {
        return type.ToLower() switch
        {
            "ebook" => new EBook(title, author, isbn, fileSize ?? 0),
            _ => new Book(title, author, isbn)
        };
    }
}