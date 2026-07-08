using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookLibrary
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            BookRepoImpl bookRepo = new BookRepoImpl();

            var added = await bookRepo.addBook(new Book { Id = 4, Name = "Book 4", Author = "Author 4", Price = 25.99 });
            Console.WriteLine($"Added: {added?.Name}");

            var removed = await bookRepo.removeBook(new Book { Id = 2, Name = "Book 2", Author = "Author 2", Price = 15.99 });
            Console.WriteLine($"Removed: {removed}");

            var updated = await bookRepo.update(new Book { Id = 3, Name = "Book 3", Author = "Author 3", Price = 20.99 });
            Console.WriteLine($"Updated: {updated?.Name}");

            var bookById = await bookRepo.getBookById(1);
            Console.WriteLine($"BookById: {bookById?.Name}");

            List<Book> allBooks = await bookRepo.getAllBooks();
            allBooks.ForEach(book => Console.WriteLine($"Id: {book.Id}, Name: {book.Name}, Author: {book.Author}, Price: {book.Price}"));
        }
    }
}
