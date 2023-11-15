using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using DataAccess.Repositories;

namespace DataAccess
{
    public class BookService
    {
        private BookRepository repo = new BookRepository();

        public List<Book> GetAllBookID()
        {
            return repo.GetAll();
        }

        public List<Book> SearchBooks(string BookName)
        {
            return repo.SearchBooks(BookName);
        }

        public void DeleteABook(int id)
        {
            repo.Delete(id);
        }

        public Book? GetABook(int id)
        {
            return repo.Get(id);
        }

        public void Create(Book book)
        {
            
            repo.Create(book);

        }

        public void UpdateABook(Book book)
        {
            repo.Update(book);
        }
    }
}
