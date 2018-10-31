using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web;

namespace TestAjax.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }


    public class BooksInitilizer : DropCreateDatabaseAlways<BookContext>
    {
        

        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Толстой", Price = 434 });
            db.Books.Add(new Book { Name = "Война", Author = "Толстой", Price = 4 });
            db.Books.Add(new Book { Name = "Очки", Author = "Чехов", Price = 44 });
            base.Seed(db);
        }
    }
}