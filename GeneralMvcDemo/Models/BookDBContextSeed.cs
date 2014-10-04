using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GeneralMvcDemo.Models
{
    public class BookDBContextSeed : DropCreateDatabaseIfModelChanges<BookDBContext>
    {
        protected override void Seed(BookDBContext context)
        {
            context.Books.Add(new Book() { Name = "MVC4 RC Early Release", Price = 220 });
            context.Books.Add(new Book() { Name = "Entity FrameWork", Price = 350M });
            context.Books.Add(new Book() { Name = "Azure Getting Started", Price = 540M });
            base.Seed(context);
        }
    }
}