using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /* 
     * Iterating Over a Collection of Books: We'll create a scenario where we have a Book collection, 
     * and we want to iterate over this collection using an iterator.
    */

    /*Explanation:
     * Book Class: Represents a single book with a title.
     * 
     * IBookIterator Interface: Defines the methods HasNext and Next for iterating over a collection of books.
     * 
     * IBookCollection Interface: Defines a method CreateIterator for creating an iterator for the collection.
     * 
     * BookCollection Class: Implements the IBookCollection interface and provides a method to add books and create an iterator.
     * 
     * BookIterator Class: Implements the IBookIterator interface and provides the logic for iterating over the collection of books.
     * 
     * Main Program: The program creates a BookCollection, adds several Book objects, and then iterates over them using the BookIterator.
    */

    // Step 1: Define the Book Class
    public class Book
    {
        public string Title { get; set; }

        public Book(string title)
        {
            Title = title;
        }
    }

    // Step 2: Create the IBookIterator Interface
    public interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }

    // Step 3: Create the IBookCollection Interface
    public interface IBookCollection
    {
        IBookIterator CreateIterator();
    }

    // Step 4: Implement the BookCollection Class
    public class BookCollection : IBookCollection
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public IBookIterator CreateIterator()
        {
            return new BookIterator(_books);
        }
    }

    // Step 5: Implement the BookIterator Class
    public class BookIterator : IBookIterator
    {
        private readonly List<Book> _books;
        private int _position = 0;

        public BookIterator(List<Book> books)
        {
            _books = books;
        }

        public bool HasNext()
        {
            return _position < _books.Count;
        }

        public Book Next()
        {
            return _books[_position++];
        }
    }
}
