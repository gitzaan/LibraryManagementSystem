using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Interfaces;

public interface ILibrary
{
    void AddBook(Book book);
    bool RemoveBook(string isbn);
    Book SearchBook(string title);
    List<Book> ListAllBooks();
}