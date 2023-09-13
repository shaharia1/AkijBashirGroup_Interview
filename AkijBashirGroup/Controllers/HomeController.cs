﻿using AkijBashirGroup.Interface;
using AkijBashirGroup.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AkijBashirGroup.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly IUnitOfWork _unitOfWork;

		public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
		{
			_logger = logger;
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

		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}