using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VatTuManager.Areas.Admin.Models;
using Model.Dao;

namespace VatTuManager.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                DanhMucNguoiDungDao dao = new DanhMucNguoiDungDao();
                bool result = dao.Login(model.userName, model.passWork);
                if (result)
                {

                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Đăng nhập không thành công.");
                }
            }

            return View("Index");
        }
    }
}