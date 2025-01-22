using LibraryManagementSystem.Factory;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Services;

public class LibraryManager
{
    private static LibraryManager instance;
    private static readonly object lockObject = new object();
    private readonly ILibrary library;

    private LibraryManager()
    {
        library = new Library();
    }

    public static LibraryManager Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    instance ??= new LibraryManager();
                }
            }
            return instance;
        }
    }

    public void AddBook(string type, string title, string author, string isbn, int? fileSize = null)
    {
        var book = BookFactory.CreateBook(type, title, author, isbn, fileSize);
        library.AddBook(book);
        Console.WriteLine("Book added successfully!");
    }

    public void RemoveBook(string isbn)
    {
        if (library.RemoveBook(isbn))
        {
            Console.WriteLine("Book removed successfully!");
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }

    public void SearchBook(string title)
    {
        var book = library.SearchBook(title);
        if (book != null)
        {
            Console.WriteLine(book.ToString());
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }

    public void ListAllBooks()
    {
        var books = library.ListAllBooks();
        if (books.Any())
        {
            foreach (var book in books)
            {
                Console.WriteLine("\n" + book.ToString());
            }
        }
        else
        {
            Console.WriteLine("No books in the library!");
        }
    }
}