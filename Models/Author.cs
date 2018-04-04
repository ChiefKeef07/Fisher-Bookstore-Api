using System;
using System.Collections.Generic;

namespace Fisher.Bookstore.Api.Data
{
    //Authors Model
    public class Author{
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public List<Book> Titles { get; set; }
    }
}