using Lab03_BaiTapTuLamBai02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03_BaiTapTuLamBai02.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult FormRegister()
        {
            // tạo list cho droplist
            ViewBag.listCountry = new List<LoaiHinh>() {
            new LoaiHinh(){ID="0",TenLoaiHinh="-- Chọn Đơn Vị --"},
            new LoaiHinh(){ID="VN",TenLoaiHinh="Việt Nam"},
            new LoaiHinh(){ID="AT",TenLoaiHinh="AUSTRALIA"},
            new LoaiHinh(){ID="UK",TenLoaiHinh="Anh"},
            new LoaiHinh(){ID="FR",TenLoaiHinh="Pháp"},
            new LoaiHinh(){ID="US",TenLoaiHinh="Mỹ"},
            new LoaiHinh(){ID="KP",TenLoaiHinh="Hàn Quốc"},
            new LoaiHinh(){ID="HU",TenLoaiHinh="Hồng Kong"},
            new LoaiHinh(){ID="CN",TenLoaiHinh="Trung Quốc"},
        };
            return View();
        }
        public ActionResult Register()
        {
            // lấy giá trị được các trường đẩy lên server khi submit
            TempData["UNameUnit"] = Request["txtUNameUnit"];
            TempData["TypeUnit"] = Request["txtTypeUnit"];
            TempData["Quantity"] = Request["txtQuantity"];
            TempData["Addresses"] = Request["txtAddresses"];
            TempData["Contact"] = Request["txtContact"];
            TempData["Phone"] = Request["txtPhone"];
            TempData["Fax"] = Request["txtFax"];
            TempData["Email"] = Request["txtEmail"];
            TempData["AddressesWS"] = Request["txtAddressesWS"];
            TempData["FName"] = Request["txtFName"];
            TempData["Pass"] = Request["txtPass"];
            TempData["Receive"] = Request["Receive"].ToString();
            return View();
        }
    }
}