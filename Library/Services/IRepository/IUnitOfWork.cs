namespace Library.Services.IRepository
{
    public interface IUnitOfWork 
    {
        public IBookRepository BookRepository { get; }
        public IAuthorRepository AuthorRepository { get; }
        public bool SaveChanges();


    }
}
