namespace LibrarySystem.Migrations
{
    using LibrarySystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LibrarySystem.Models.LibraryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LibrarySystem.Models.LibraryDbContext context)
        {
            if (context.Books.Any())
            {
                return;
            }

            IList<Category> categories = new List<Category>()
            {
                new Category() { Name = "Programming" },
                new Category() { Name = "Databases" },
                new Category() { Name = "Web Development" },
                new Category() { Name = "System Administration" },
                new Category() { Name = "Data Structures and Algorithms" },
                new Category() { Name = "Rocket Science" }
            };

            List<Book> books = new List<Book>()
            {
                new Book() { 
                    Title = "Fundamentals of Computer Programming with C#",
                    Author = "Svetlin Nakov & Co.", ISBN = "978-954-400-773-7",
                    WebSite = "http://www.introprogramming.info/english-intro-csharp-book/",
                    Description = "The free book \"Fundamentals of Computer Programming with C#\" aims to provide novice programmers solid foundation of basic knowledge regardless of the programming language. This book covers the fundamentals of programming that have not changed significantly over the last 10 years. Educational content was developed by an authoritative author team led by Svetlin Nakov and covers topics such as variables conditional statements, loops and arrays, and more complex concepts such as data structures (lists, stacks, queues, trees, hash tables, etc.), and recursion recursive algorithms, object-oriented programming and high-quality code. From the book you will learn how to think as programmers and how to solve efficiently programming problems. You will master the fundamental principles of programming and basic data structures and algorithms, without which you can't become a software engineer.",
                    Category = categories[0]
                },
                new Book() { 
                    Title = "C# Yellow Book",
                    Author = "Rob Miles", ISBN = "B003UN7WHS",
                    WebSite = "http://www.csharpcourse.com",
                    Description = "The C# Book is used by the Department of Computer Science in the University of Hull as the basis of the First Year programming course.",
                    Category = categories[0]
                },
                new Book() { 
                    Title = "Programming = ++ Algorithms;",
                    Author = "Preslav Nakov and Panayot Dobrikov", ISBN = "954-8905-06-X",
                    WebSite = "http://www.programirane.org",
                    Description = "The “Programming=++Algorithms;” book is now available for free download as PDF. Everyone who speaks Bulgarian could benefit from the free non-commercial edition of this highly-valuable book on algorithms and competitive programming.",
                    Category = categories[4]
                },
                new Book() { 
                    Title = "SQL in a Nutshell: A Desktop Quick Reference",
                    Author = "Kevin Kline", ISBN = "978-156-592-744-5",
                    Category = categories[1]
                },
                new Book() { 
                    Title = "Beginning HTML and CSS",
                    Author = "Rob Larsen", 
                    Category = categories[2]
                },
                new Book() { 
                    Title = "Beginning ASP.NET 4.5 in C# Coding Skills Kit",
                    Author = "Imar Spaanjaars", WebSite="http://www.goodreads.com/book/show/17129477",
                    Category = categories[2]
                },
                new Book() { 
                    Title = "Advanced Linux Programming",
                    Author = "CodeSourcery LLC", WebSite="http://www.advancedlinuxprogramming.com",
                    Category = categories[3]
                },            
            };


            context.Books.AddOrUpdate(books.ToArray());
        }
    }
}
