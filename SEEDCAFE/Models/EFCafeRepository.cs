using System.Linq;
namespace SEEDCAFE.Models
{
    public class EFCafeRepository : ICafeRepository
    {
        private CafeDbContext context;
        public EFCafeRepository(CafeDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Book> Books => context.Books;
        public void CreateBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }
        public void DeleteBook(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }
    }
}