using Microsoft.AspNetCore.Mvc;
using MVCExample.Data;

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
  }
}
