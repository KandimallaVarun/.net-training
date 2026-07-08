using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookLibrary
{
    internal class BookRepoImpl : BookRepo
    {
        public Task<Book> addBook(Book book)
        {
            var result = new Book
            {
                Id = book.Id,
                Name = book.Name,
                Author = book.Author,
                Price = book.Price
            };
            return Task.FromResult(result);
        }

        public Task<List<Book>> getAllBooks()
        {
            var list = new List<Book>
            {
                new Book { Id = 1, Name = "Book 1", Author = "Author 1", Price = 10.99 },
                new Book { Id = 2, Name = "Book 2", Author = "Author 2", Price = 15.99 },
                new Book { Id = 3, Name = "Book 3", Author = "Author 3", Price = 20.99 }
            };
            return Task.FromResult(list);
        }

        public Task<Book> getBookById(int id)
        {
            var book = new Book { Id = id, Name = "Book " + id, Author = "Author " + id, Price = 10.99 + id };
            return Task.FromResult(book);
        }

        public Task<bool> removeBook(Book book)
        {
            if (book == null) return Task.FromResult(false);
            return Task.FromResult(true);
        }

        public Task<Book> update(Book book)
        {
            var updated = new Book
            {
                Id = book.Id,
                Name = book.Name + " (Updated)",
                Author = book.Author,
                Price = book.Price + 5.00
            };
            return Task.FromResult(updated);
        }
    }
}
