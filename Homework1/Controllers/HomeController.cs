using Microsoft.AspNetCore.Mvc;

namespace _1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ReverseName(string name)
    {
        if (name == null)
        {
            ViewBag.Message = "Check Your Name";
        }
        else
        {
            string reversedName = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reversedName += name[i];
            }

            ViewBag.Message = reversedName;
        }

        return View("Index");
    }
}

