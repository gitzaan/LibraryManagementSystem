using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services;

public class Library : ILibrary
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public bool RemoveBook(string isbn)
    {
        var book = books.FirstOrDefault(b => b.ISBN == isbn);
        if (book != null)
        {
            return books.Remove(book);
        }
        return false;
    }

    public Book SearchBook(string title)
    {
        return books.FirstOrDefault(b => b.Title.ToLower().Contains(title.ToLower()));
    }

    public List<Book> ListAllBooks()
    {
        return books.ToList();
    }
}