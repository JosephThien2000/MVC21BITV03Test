using Nhom04MidTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Nhom04MidTest.Controllers;

public class CustomerController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
