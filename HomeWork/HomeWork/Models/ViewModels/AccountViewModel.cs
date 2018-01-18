using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork.Models.ViewModels
{
    public class AccountViewModel
    {
        public int  Num { get; set; }
        public string Category { get; set; }
        public int Money { get; set; }
        public DateTime Date { get; set; }
        public string Remark { get; set; }


    }
}