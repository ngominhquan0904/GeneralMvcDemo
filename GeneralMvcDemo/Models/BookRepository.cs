using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace GeneralMvcDemo.Models
{
    public class BookRepository
    {
        BookDBContext db = new BookDBContext();
        public BookRepository()
        { 
        }
        #region IBookRepository Members

        public IEnumerable<Book> GetAll()
        {
            return db.Books;
        }
      

        public Book Get(int id)
        {
          return  db.Books.FirstOrDefault(t => t.Id == id);
        }

        public Book Add(Book item)
        {
            db.Books.Add(item);
            db.SaveChanges();
            return item;
        }

        public void Remove(int id)
        {
            Book book = db.Books.FirstOrDefault(x=>x.Id==id);
            db.Books.Remove(book);
            db.SaveChanges();
        }

        public bool Update(Book item)
        {
            Book bookUpdate = db.Books.FirstOrDefault(x => x.Id == item.Id);
            bookUpdate.Id = item.Id;
            bookUpdate.Name = item.Name;
            bookUpdate.Price = item.Price;
            db.SaveChanges();
            return true;
        }

        #endregion
    }
}