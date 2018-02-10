using HomeWork.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Account()
        {
            List<AccountViewModel> list = new List<AccountViewModel>();
            Random Random = new Random();
            for(int i=1;i<=100;i++)
            {
                int Number = i;
                int Money = Random.Next(90000);
                 // int Year = Random.Next(9999);
                //int Month = Random.Next(1, 13);
                int Day = Random.Next(1000);
                var Time = DateTime.Now.AddMilliseconds(Day).AddDays(Day);
                var Category = Random.Next(1, 3);
                string Name = "支出";
                if(Category==1)
                {
                    Name = "收入";
                }
                

                list.Add(new AccountViewModel()
                {
                    Num =Number,
                    Money=Money,
                    Date=Convert.ToDateTime(Time),
                    Category=Name,

               });
            }
           
            return View(list);
        }
    }
}