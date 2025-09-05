using tecnica_api.Data;
using tecnica_api.Models;

namespace tecnica_api.Logic
{
    public class BooksLogic
    {
        private IBooksData booksData;
        public BooksLogic(IBooksData booksData)
        {
            this.booksData = booksData;
        }
        public List<BookModel> GetBooks()
        { 
            return booksData.GetBooksData();
        }

        public List<BookModel> GetBooks(string title)
        { 
            return booksData.GetBookData(title);
        }

        public bool CreateBook(BookModel book)
        { 
            return booksData.CreateBook(book);
        }
    }
}
