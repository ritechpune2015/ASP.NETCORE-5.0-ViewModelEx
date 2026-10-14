using Microsoft.AspNetCore.Mvc;
using ViewModelEx.Models;
using ViewModelEx.ViewModels;

namespace ViewModelEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ProdCustBookVM bv = new ProdCustBookVM();

            Product p = new Product();
            Customer c = new Customer();
            Book b = new Book();

            bv.Address = c.Address;
            bv.AuthorName = b.AuthorName;
            bv.BookName = b.BookName;
            bv.BookPrice = b.Price;
            bv.CustomerName = c.CustomerName;
            bv.EmailID = c.EmailID;
            bv.MfgName = p.MfgName;
            bv.MobileNo = c.MobileNo;
            bv.Price = p.Price;
            bv.ProductName = p.ProductName;

            return View(bv);
        }
    }
}
