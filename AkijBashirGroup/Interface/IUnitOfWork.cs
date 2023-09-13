
namespace AkijBashirGroup.Interface 
{
    public interface IUnitOfWork
    {
        IUser Users { get; set; }

        Task CompleteAsync();
        void SaveChanges();
    }
}
