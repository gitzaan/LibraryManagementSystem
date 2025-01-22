using LibraryManagementSystem.Services;

namespace LibraryManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        var manager = LibraryManager.Instance;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Add EBook");
            Console.WriteLine("3. Remove Book");
            Console.WriteLine("4. Search Book");
            Console.WriteLine("5. List All Books");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter ISBN: ");
                    string isbn = Console.ReadLine();
                    manager.AddBook("book", title, author, isbn);
                    break;

                case "2":
                    Console.Write("Enter title: ");
                    title = Console.ReadLine();
                    Console.Write("Enter author: ");
                    author = Console.ReadLine();
                    Console.Write("Enter ISBN: ");
                    isbn = Console.ReadLine();
                    Console.Write("Enter file size (MB): ");
                    int.TryParse(Console.ReadLine(), out int fileSize);
                    manager.AddBook("ebook", title, author, isbn, fileSize);
                    break;

                case "3":
                    Console.Write("Enter ISBN to remove: ");
                    isbn = Console.ReadLine();
                    manager.RemoveBook(isbn);
                    break;

                case "4":
                    Console.Write("Enter title to search: ");
                    title = Console.ReadLine();
                    manager.SearchBook(title);
                    break;

                case "5":
                    manager.ListAllBooks();
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}