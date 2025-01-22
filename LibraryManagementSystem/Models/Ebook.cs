namespace LibraryManagementSystem.Models;

public class EBook : Book
{
    public int FileSize { get; set; }

    public EBook(string title, string author, string isbn, int fileSize)
        : base(title, author, isbn)
    {
        FileSize = fileSize;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nFile Size: {FileSize}MB";
    }
}