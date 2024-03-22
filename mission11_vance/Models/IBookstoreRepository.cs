namespace mission11_vance.Models
{
    public interface IBookstoreRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
