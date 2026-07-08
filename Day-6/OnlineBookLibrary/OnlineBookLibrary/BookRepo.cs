using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookLibrary
{
    internal interface BookRepo
    {
        Task<Book> addBook(Book book);
        Task<bool> removeBook(Book book);
        Task<Book> update(Book book);
        Task<Book> getBookById(int id);
        Task<List<Book>> getAllBooks();

    }
}
