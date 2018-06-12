using MVC_Calc_Program4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Calc_Program4.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            var model = new CalcM();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(CalcM c)
        {
            c.Result = 0;
            switch (c.Op)
            {
                case '+':
                    c.Result = c.No2 + c.No1;
                    break;
                case '-':
                    c.Result = c.No2 - c.No1;
                    break;
                case '*':
                    c.Result = c.No2 * c.No1;
                    break;
                case '/':
                    c.Result = c.No2 / c.No1;
                    break;
                case 'C':
                    c.Result = 0;
                    c.No1 = 0;
                    c.No2 = 0;
                    break;
            }
            c.No2 = c.Result;
            c.No1 = 0;

            return View(c);
        }
    }
}