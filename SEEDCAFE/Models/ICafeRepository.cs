using System.Linq;
namespace SEEDCAFE.Models
{
    public interface ICafeRepository
    {
        IQueryable<Book> Books { get; }
        void SaveBook(Book b);
        void CreateBook(Book b);
        void DeleteBook(Book b);
    }
}