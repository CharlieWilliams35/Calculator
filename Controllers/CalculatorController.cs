using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        public string Calculate(string input)
        {
            DataTable dt = new DataTable();
            var result = dt.Compute(input, "");
            if (result.ToString() == input)
            {
                return "Error";
            }
            else
            {
                return result.ToString();
            }

        }

    }

}
