using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public class BookRepository
    {
        private BookScienceContext context;

        public Book? Get(int bookId)
        {
            context = new BookScienceContext();

            return context.Books.Find(bookId);
        }

        public List<Book> GetAll()
        {
            List<Book> books;
            IQueryable<Book> query = null;
            try
            {
                using BookScienceContext context = new BookScienceContext();
                query = context.Books;
                books = query.ToList();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return books;
        }

        public void Create(Book book)
        {
            context = new BookScienceContext();
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void Update(Book book)
        {
            context = new BookScienceContext();
            context.Books.Update(book); 
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context = new BookScienceContext();
            var book = context.Books.FirstOrDefault(b => b.BookId == id);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }
        }
    }
}
