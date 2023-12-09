using Lab04_1.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Lab04_1.Controllers
{
    public class CustomerController : Controller
    {
        /*
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        */
        //GET: /Customer/CustomerDetail action tra ve thong tin
        //chi tiet mot khach hang cho View customerDetail
        public ActionResult CustomerDetails()
        {
            Customer Cus = new Customer()
            {
                CustomerID = "KH001",
                FullName = "Pham Van Giang",
                Address = "Tp Thu Duc",
                Email = "6251071025gmail.com",
                Phone = "0976.320.547",
                Balance = 485000
            };
            return View(Cus);
            //Cach 1: gan du lieu vao ViewBag de chuyen toi View
            //ViewBag.customer = cus;
            //return View();
            //co the chuyen du lieu qua doi tuong model de chuyen toi View 
        }
        //GET Product/CustomerList (Action tra ve danh sach khach hang cho View CustomerList)
        public ActionResult CustomerList()
        {
            //Tao mot danh sach khach hang
            List<Customer> lsCus = new List<Customer>()
            {
                new Customer() {CustomerID="KH001", 
                    FullName="Trinh Van Chung", 
                    Address = "Tp Ho Chi Minh", 
                    Email = "dungta.uit@gmail.com", 
                    Phone ="0988.611.889",  Balance=15200000},
                new Customer() {CustomerID="KH002", 
                    FullName="Do Thi Cuc", 
                    Address = "Tp Ha Noi", 
                    Email = "cucdt@gmail.com", 
                    Phone ="0988.611.880",  Balance=22000000},
                new Customer() {CustomerID="KH003", 
                    FullName="Nguyen Tuan Thang", 
                    Address = "Nam Dinh", 
                    Email = "thangnt@gmail.com", 
                    Phone ="0942.611.889",  
                    Balance=12000000},
                new Customer() {CustomerID="KH004", 
                    FullName="Le Ngoc Hai",
                    Address = "Tp Ha Noi", 
                    Email = "hailn@gmail.com", 
                    Phone ="0999.611.880",  
                    Balance=6000000},
            };
            //Gan du lieu vao ViewBag de chuyen qua View
            ViewBag.lsCus = lsCus;
            return View();
        }
    }
}