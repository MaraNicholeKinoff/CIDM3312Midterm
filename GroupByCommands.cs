using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq;

namespace CIDM3312Midterm
{
    public class GroupByCommands
    {
        
        public static void Problem1() {
            using (var context = new AppDbContext()) {
                var books = context.Book.ToList();
                var publisherGroups = books.GroupBy(b => b.Publisher);
                foreach(var group in publisherGroups) {
                    Console.WriteLine($"Publisher Group: {group.Key}");
                    foreach(Book b in group) {
                        Console.WriteLine(b);
                    }
                }
            } 
        }
        public static void Problem2() {
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
                var ordered = booksAuthorsJoin.OrderBy(a => a.AuthorLName);
                var groupedBooks = ordered.GroupBy(b => b.Publisher);
                foreach(var group in groupedBooks) {
                    Console.WriteLine($"Publisher Group: {group.Key}");
                    foreach(var b in group) {                        
                        Console.WriteLine(b);
                    }
                }
            } 
        }
    }
}