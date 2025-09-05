using tecnica_api.Models;

namespace tecnica_api.Data
{
    public class BooksData : IBooksData
    {
        public static List<BookModel> Books = new()
        {
            new() { Title = "El fin del mundo y un despiadado país de las maravillas", Id = Guid.NewGuid() },
            new() { Title = "La chica mecánica", Id = Guid.NewGuid() }
        };

        public List<BookModel> GetBooksData()
        {
            return Books;
        }

        public List<BookModel> GetBookData(string Title)
        {
            BookModel book = Books.FirstOrDefault(book => book.Title.Equals(Title));
            List<BookModel> bookList = new();

            if (book is not null) bookList.Add(book);

            return bookList;
        }

        public bool CreateBook(BookModel book)
        {
            if (Books.Any(bBook => bBook.Title == book.Title))
            { 
                Books.Add(book);
                return true;
            }
            return false;
        }
    }
}
