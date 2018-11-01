using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq;

namespace CIDM3312Midterm
{
    public class WhereCommands
    {
        
        public static void Problem1() {
            using (var context = new AppDbContext()) {
                var books = context.Book.ToList();
                foreach(Book b in books) {
                    Console.WriteLine(b);
                }
            } 
        }
        public static void Problem2() {
            using (var context = new AppDbContext()) {
                var books = context.Book.ToList();
                var apressBooks = books.Where(b => b.Publisher == "Apress");
                foreach(Book b in apressBooks) {
                    Console.WriteLine(b);
                }
            } 
        }
        public static void Problem3() {
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
                var shortName = booksAuthorsJoin.Min(a => a.AuthorFName);
                var shortNameList = booksAuthorsJoin.Where(a => a.AuthorFName == shortName);
                foreach(var b in shortNameList) {
                    Console.WriteLine(b);
                }
            } 
        }
    }
}