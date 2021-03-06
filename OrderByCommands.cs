using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq;

namespace CIDM3312Midterm
{
    public class OrderByCommands
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
                                                });
                var orderedNameList = booksAuthorsJoin.OrderBy(a => a.AuthorLName);
                foreach(var b in orderedNameList) {
                    Console.WriteLine(b);
                }
            } 
        }
        public static void Problem2() {
            using (var context = new AppDbContext()) {
                var books = context.Book.ToList();
                var descendingBooks = books.OrderByDescending(b => b.Title);
                foreach(Book b in descendingBooks) {
                    Console.WriteLine(b);
                }
            } 
        }
    }
}