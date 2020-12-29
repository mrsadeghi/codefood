using CodeFood.Helper;
using CodeFood.Services;
using CodeFood.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Register(UserRegisterVM model)
        {
            try
            {
                var result = _userService.Register(model);
                return Json(new DTO<UserRegisterVM>(
                    model,
                    result,
                    result ? "مشخصات شما با موفقیت ثبت شد، لطفا منتظر تایید باشید" : "ثبت مشخصات با خطا مواجه شد"));
            }
            catch(CodeFoodException ex)
            {
                return Json(new DTO<UserRegisterVM>(model, false, ex.Message));
            }
            catch (Exception)
            {
                return Json(new DTO<UserRegisterVM>(model, false, "ثبت مشخصات با خطا مواجه شد"));
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
