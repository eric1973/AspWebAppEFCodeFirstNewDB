using DataLayer.DbContext.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DbContext.SeedData
{

    /// <summary>
    /// Always drop - create the database and insert some sample data.
    /// </summary>
    /// <seealso cref="System.Data.Entity.DropCreateDatabaseAlways{DataLayer.DbContext.Context.BooksContext}" />
    public class BooksContextInitializer : DropCreateDatabaseAlways<BooksContext>
    {
        protected override void Seed(BooksContext context)
        {
            context.Books.Add(new Entities.Models.Book
            {
                Title = "C# 6 in a Nutshell",
                Price = 49.95M
            });

            context.Books.Add(new Entities.Models.Book
                {
                    Title = "Adaptive Code via C#",
                    Price = 45.95M
                }
            );

            context.Books.Add(new Entities.Models.Book
            {
                Title = "CSS3",
                Price = 25.95M
            }
);
            // Save changes into database
            base.Seed(context);
        }
    }
}
