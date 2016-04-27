namespace DataLayer.DbContext.Context
{
    using Entities.Models;
    using SeedData;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BooksContext : DbContext
    {
        // Your context has been configured to use a 'BooksContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataLayer.DbContext.Context.BooksContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BooksContext' 
        // connection string in the application configuration file.
        public BooksContext()
            : base("name=BooksContext")
        {
            // Initialize Database with data
            Database.SetInitializer(new BooksContextInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Book> Books { get; set; }
    }
}