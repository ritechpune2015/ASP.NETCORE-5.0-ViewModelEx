using System;
using System.Reflection.Metadata.Ecma335;

namespace ViewModelEx.Models
{
    public class Book
    {
        public Int64    BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
        public Book()
        {
            this.BookID = 121;
            this.BookName = "Inside Object";
            this.AuthorName = "Microsoft";
            this.Price = 5600;
        }
    }
    
}

