using System;
using Microsoft.AspNetCore.Mvc;
using lab1.Data.Models;

namespace lab1.Data.Controllers
{
    public class CalculateController : Controller
    {
        private readonly Random random = new();
        private readonly int a;
        private readonly int b;
        private readonly string sum;
        private readonly string sub;
        private readonly string mult;
        private readonly string div;

        public CalculateController()
        {
            a = random.Next(0, 11);
            b = random.Next(0, 11);
            sum = $"{a} + {b} = {a + b}";
            sub = $"{a} - {b} = {a - b}";
            mult = $"{a} * {b} = {a * b}";
            div = b == 0 ? "Can't devide by 0" : $"{a} / {b} = {a / b}";
        }

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult PassUsingModel()
        {
            var model = new CalcModel(a, b, sum, sub, mult, div);
            return View(model);
        }

        public ViewResult PassUsingViewData()
        {
            ViewData["a"] = a;
            ViewData["b"] = b;
            ViewData["sum"] = sum;
            ViewData["sub"] = sub;
            ViewData["mult"] = mult;
            ViewData["div"] = div;
            return View();
        }

        public ViewResult PassUsingViewBag()
        {
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.sum = sum;
            ViewBag.sub = sub;
            ViewBag.mult = mult;
            ViewBag.div = div;
            return View();
        }

        public ViewResult AccessServiceDirectly()
        {            
            return View();
        }
    }
}
