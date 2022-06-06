using MVCExample.Data;
using MVCExample.Models;

namespace MVCExample
{
  public class SampleData
  {
    public static void InitializePhone(MobileContext context)
    {
      if (!context.Phones.Any())
      {
        context.Phones.AddRange(
          new Phone
          {
            Name="Iphone 13",Company="Apple",Price = 600
          },
          new Phone
          {
            Name="Samsung S22",Company="Samsung",Price = 700
          },
          new Phone
          {
            Name="Oppo reno 5",Company="BBC",Price = 450
          },
          new Phone
          {
            Name="Samsung A72",Company="Samsung",Price = 350
          },
          new Phone
          {
            Name="Xiaomi mi 11",Company="Xiaomi",Price = 400
          });
        context.SaveChanges();
      }
    }
    public static void InitializeBook(MobileContext context)
    {
      if (!context.Books.Any())
      {
        context.Books.AddRange(
          new Book
          {
            Name="Война и мир", Autor="Лев Толстой", Price = 50
          },
          new Book
          {
            Name="Абай жолы", Autor="Ауезов Мухтар", Price = 150
          }
          );
        context.SaveChanges();
      }
    }
  }
}
