using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03_BaiTapTuLam01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // In ra các số nguyên tố từ 1-100
            ViewBag.PrimeNumbers = GetPrimeNumbers(1, 100);

            // In ra giai thừa từ 1-10
            ViewBag.Factorials = GetFactorials(1, 10);

            // In ra bảng cửu chương từ 2-9
            ViewBag.MultiplicationTable = GetMultiplicationTable(2, 9);

            return View();
        }

        private List<int> GetPrimeNumbers(int start, int end)
        {
            List<int> primes = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private List<int> GetFactorials(int start, int end)
        {
            List<int> factorials = new List<int>();
            for (int i = start; i <= end; i++)
            {
                factorials.Add(CalculateFactorial(i));
            }
            return factorials;
        }

        private int CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * CalculateFactorial(n - 1);
        }

        private List<string> GetMultiplicationTable(int number, int end)
        {
            List<string> table = new List<string>();
            for (int i = 1; i <= end; i++)
            {
                table.Add($"{number} x {i} = {number * i}");
            }
            return table;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}