﻿namespace tecnica_api.Models
{
    public class BookModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string Summary { get; set; }
    }
}
