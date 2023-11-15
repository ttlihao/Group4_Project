using Business.Entities;
using Business.Repositories;

namespace Service
{
    public class Service
    {
        private BookRepository repo = new BookRepository();

        public List<Book> GetAllBookID()
        {
            return repo.GetAll();
        }

        public List<Book> SearchBooks(string keyword)
        {
            return repo.GetAll().Where(b => b.BookName.ToLower().Contains(keyword.ToLower()) ||
                                             b.BookDescription.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public void DeleteABook(int id)
        {
            repo.Delete(id);
        }

        public Book? GetABook(int id)
        {
            return repo.Get(id);
        }

        public void AddABook(Book book)
        {
            repo.Create(book);
        }

        public void UpdateABook(Book book)
        {
            repo.Update(book);
        }
    }
}