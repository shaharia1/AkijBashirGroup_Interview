using AkijBashirGroup.Interface;
using AkijBashirGroup.ModelContext;



namespace AkijBashirGroup.Repo
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ModelDbContext _context;
        
        public IUser Users { get; set; }

        public UnitOfWork(ModelDbContext context)
        {
            _context = context;

            Users = new UserRepo(context);
            
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
            
        }

        public void SaveChanges()
        {
             _context.SaveChanges();

        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
