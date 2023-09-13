using AkijBashirGroup.Models;


namespace AkijBashirGroup.Interface
{
  
    public interface IUser: IBase<User>, IDisposable
    {
        ResultResponse SaveUser(User user);
        ResultResponse UpdateUser(User user);
       
    }
}
