using Microsoft.AspNetCore.Mvc;
using MVCExample.Data;
using MVCExample.Models;

namespace MVCExample.Controllers
{
  public class MobileController : Controller
  {
    private readonly MobileContext _db;

    public MobileController(MobileContext mobileContext)
    {
      _db = mobileContext;
    }

    public IActionResult Index()
    {
      var phones = _db.Phones.ToList();
      return View(phones);
    }

    [HttpGet]
    public IActionResult Buy(int id)
    {
      ViewBag.PhoneId = id;
      return View();
    }
    [HttpPost]
    public IActionResult(Order o)
    {
      _db.Orders.Add(o);
      _db.SaveChanges();
      return $"{Order.User}";
      adil

    }
  }
}
