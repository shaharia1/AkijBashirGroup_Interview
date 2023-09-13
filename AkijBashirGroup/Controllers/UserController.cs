using Microsoft.AspNetCore.Mvc;
using AkijBashirGroup.Interface;
using AkijBashirGroup.Models;

namespace AkijBashirGroup.Controllers
{
    public class UserController : Controller
    {
        
		private readonly IUnitOfWork _unitOfWork;

		public UserController(IUnitOfWork unitOfWork)
		{
			
			_unitOfWork = unitOfWork;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ResultResponse SaveUser(User user)
		{
			try
			{
				var data = _unitOfWork.Users.SaveUser(user);

				return data;
			}
			catch (Exception)
			{

				throw;
			}
		}
		//public IActionResult Save([FromBody] User user)
  //      {
  //          try
  //          {
  //              _IUser.SaveUser(user);

  //              return base.Json("Save");
  //          }
  //          catch (Exception)
  //          {

  //              throw;
  //          }
  //      }

        
    }
}
