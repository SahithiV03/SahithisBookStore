using SahithisBooks.DataAccess.Repository.iRepository;
using SahithisBooks.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SahithisBookStore.Models;
using SahithisBooks.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SahithisBooks.Models;
using SahithisBookStore.Models.ViewModels;

namespace SahithisBookStore.Area.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unifOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unifOfWork)
        {
            _logger = logger;
            _unifOfWork = unifOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _unifOfWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
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
