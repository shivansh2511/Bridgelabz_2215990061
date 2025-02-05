using System;

class Book
{
    // Static variable shared across all books
    private static string LibraryName = "Central City Library";

    // Readonly variable (cannot be changed after assignment)
    public readonly string ISBN;
    public string Title;
    public string Author;

    // Constructor
    public Book(string isbn, string title, string author)
    {
        this.ISBN = isbn;  // Resolving ambiguity using 'this'
        this.Title = title;
        this.Author = author;
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        // Checking if the object is an instance of Book using 'is' operator
        if (this is Book)
        {
            Console.WriteLine(string.Format("Library Name: {0}", LibraryName));
            Console.WriteLine(string.Format("ISBN: {0}", this.ISBN));
            Console.WriteLine(string.Format("Title: {0}", this.Title));
            Console.WriteLine(string.Format("Author: {0}", this.Author));
        }
        else
        {
            Console.WriteLine("Invalid book object.");
        }
    }

    // Static method to display the library name
    public static void DisplayLibraryName()
    {
        Console.WriteLine(string.Format("Library Name: {0}", LibraryName));
    }
}

// Main class to test the Book class
class Program
{
    static void Main()
    {
        // Displaying library name
        Book.DisplayLibraryName();

        // Creating book objects
        Book book1 = new Book("978-3-16-148410-0", "The Great Gatsby", "F. Scott Fitzgerald");
        Book book2 = new Book("978-0-452-28423-4", "To Kill a Mockingbird", "Harper Lee");

        Console.WriteLine("\nBook 1 Details:");
        book1.DisplayBookDetails();

        Console.WriteLine("\nBook 2 Details:");
        book2.DisplayBookDetails();
    }
}

