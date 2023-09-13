using AkijBashirGroup.Interface;
using AkijBashirGroup.ModelContext;
using AkijBashirGroup.Models;
using Azure;
using Microsoft.EntityFrameworkCore;


namespace AkijBashirGroup.Repo
{
	public class UserRepo : Base<User>, IUser
	{

		private readonly ModelDbContext _dbContext;
		private readonly ResponseRepo response = new ResponseRepo();
		public UserRepo(ModelDbContext modelDbContext) : base(modelDbContext)
		{
			_dbContext = modelDbContext;
		}

		public ResultResponse SaveUser(User user)
		{
			try
			{
				var validation = DataValidation(user);
				if (validation != null)
				{
					return validation;
				}

				var chkUser = _dbContext.Users?.Where(s => s.Username == user.Username).FirstOrDefault();
				if (chkUser == null)
				{
					var ph = new Microsoft.AspNet.Identity.PasswordHasher();
					var hash = ph.HashPassword(user.Password);
					user.Password = hash;
					user.CreateDate = DateTime.Now;
					

					Create(user);

					SaveChanges();

					return response.SaveMessage();
				}

				return response.ExixtsMessage();

			}
			catch (Exception)
			{

				throw;
			}
		}

		public ResultResponse UpdateUser(User user)
		{
			try
			{

				var chkUser = _dbContext.Users?.Where(s => s.Id == user.Id).FirstOrDefault();

				if (chkUser == null)
				{
					return response.NorecordeFound();
				}
				chkUser.UpdateDate = DateTime.Now;
				
				chkUser.FullName = user.FullName;
				chkUser.MobileNumber = user.MobileNumber;
				

				Update(chkUser);

				SaveChanges();
				return response.UpdateMessage();
			}
			catch (Exception)
			{

				throw;
			}
		}


		#region Dispose
		private bool disposed = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					ModelDbContext.Dispose();
				}
			}
			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		#endregion


		#region 

		private ResultResponse DataValidation(User user)
		{
			if (string.IsNullOrWhiteSpace(user.Username))
			{
				return new ResultResponse { msg = "User Name Is Required" };
			}

			if (string.IsNullOrWhiteSpace(user.Email))
			{
				return new ResultResponse { msg = "Email Is Required" };
			}
			if (string.IsNullOrWhiteSpace(user.FullName))
			{
				return new ResultResponse { msg = "Full Name Is Required" };
			}

			if (string.IsNullOrWhiteSpace(user.MobileNumber))
			{
				return new ResultResponse { msg = "Mobile Number Is Required" };
			}
			if (string.IsNullOrWhiteSpace(user.Password))
			{
				return new ResultResponse { msg = "Password Is Required" };
			}

			return null; // No validation errors


		}

		

		#endregion

	}


}
