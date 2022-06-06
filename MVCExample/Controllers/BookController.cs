using Microsoft.AspNetCore.Mvc;
using MVCExample.Data;

namespace MVCExample.Controllers
{
  public class BookController : Controller
  {
    private readonly MobileContext _db;
    public BookController(MobileContext bookContext)
    {
      _db = bookContext;
    }
    public IActionResult Index()
    {
      var books = _db.Books.ToList();
      return View(books);
    }
  }
}
