using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq;

namespace CIDM3312Midterm
{
    public class FindCommands
    {
        
        public static void Problem1() {
            using (var context = new AppDbContext()) {
                var booksAuthorsJoin = context.Book.Join(
                                                context.Author, 
                                                b => b.AuthorID, 
                                                a => a.AuthorID, 
                                                (b, a) => new {
                                                    Title = b.Title,
                                                    Publisher = b.Publisher,
                                                    PublishDate = b.PublishDate,
                                                    Pages = b.Pages,
                                                    AuthorFName = a.AuthorFName,
                                                    AuthorLName = a.AuthorLName
                                                }).ToList();
                Console.WriteLine(booksAuthorsJoin.Find(a => a.AuthorFName == "Adam"));                
            } 
        }
        public static void Problem2() {
            using (var context = new AppDbContext()) {
                var books = context.Book.ToList();
                Console.WriteLine(books.Find(x => x.Pages > 1000));
            } 
        }
    }
}