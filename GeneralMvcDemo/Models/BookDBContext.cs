using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GeneralMvcDemo.Models
{
    public class BookDBContext:DbContext
    {
      public   DbSet<Book> Books { get; set; }
    }
}