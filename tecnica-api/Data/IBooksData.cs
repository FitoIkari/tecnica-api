using tecnica_api.Models;

namespace tecnica_api.Data
{
    public interface IBooksData
    {
        List<BookModel> GetBookData(string Title);
        List<BookModel> GetBooksData();
    }
}