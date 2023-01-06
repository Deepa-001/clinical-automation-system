using NewProjectCAS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace NewProjectCAS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Login()
        {   
                return View();
        }

        public ActionResult AuthenticateLogin(LoginViewModel model)
        {
            using (MyDatabseEntities db = new MyDatabseEntities())
            {
                var checkuser = (from m in db.MemberLogins
                                 join r in db.RoleDetails
       on m.RoleId equals r.RoleId
                                 where m.EmailId == model.EmailId && m.Password == model.Password
                                 select new { r.RoleName, m.EmailId, m.Password, m.MemberId }).FirstOrDefault();

                if (checkuser != null)
                {
                    FormsAuthentication.SetAuthCookie(checkuser.EmailId, false);
                    var authTicket = new FormsAuthenticationTicket(1, checkuser.EmailId, DateTime.Now,
                    DateTime.Now.AddMinutes(1), false, checkuser.RoleName);
                    string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                    var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                    HttpContext.Response.Cookies.Add(authCookie);

                    Session["MemberId"] = checkuser.MemberId;
                    switch (checkuser.RoleName)
                    {
                        //case "Doctor":
                        case "Doctor":
                            return RedirectToAction("Decision", "Doctor", new { id = checkuser.MemberId });

                        case "Patient":
                            return RedirectToAction("Decision", "Patient", new { id = checkuser.MemberId });

                        case "Supplier":
                            return RedirectToAction("Decision", "Supplier", new { id = checkuser.MemberId });
                    }
                }
                else
                {
                    ViewBag.Message = "Invalid Email Id or Password";
                }

                return View("Login");
            }

        }

        [HttpPost]
        public ActionResult PostMember(LoginViewModel model)
        {
            using (MyDatabseEntities db = new MyDatabseEntities())
            {
                if (ModelState.IsValid)
                {
                    var member = db.MemberLogins.SingleOrDefault(a => a.EmailId == model.EmailId);
                    if (member == null)
                    {
                        db.InsertMember(model.EmailId, model.Password, model.RoleId);

                        ViewBag.Message = "Registration Successsfull";
                    }
                    else
                    {
                        ViewBag.Message = "EmailID Already Exists";
                    }

                }
                else
                {
                    ViewBag.Message = "Invalid Input";
                }
            }

            List<SelectListItem> lst = new List<SelectListItem>();
            using (MyDatabseEntities db = new MyDatabseEntities())
            {
                var getdata = db.RoleDetails.ToList();
                foreach (var item in getdata)
                {
                    lst.Add(new SelectListItem
                    {
                        Value = item.RoleId.ToString(),
                        Text = item.RoleName
                    });
                }
            }

            LoginViewModel model1 = new LoginViewModel();
            model1.RoleName = lst;
            return View("Register", model1);
        }

        public ActionResult Register()
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            using (MyDatabseEntities db = new MyDatabseEntities())
            {
                var getdata = db.RoleDetails.ToList();
                foreach (var item in getdata)
                {
                    lst.Add(new SelectListItem
                    {
                        Value = item.RoleId.ToString(),
                        Text = item.RoleName
                    });
                }
            }

            LoginViewModel model = new LoginViewModel();
            model.RoleName = lst;
            return View(model);
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();                             // it will clear the session at the end of request
            return RedirectToAction("Login", "Home");
        }
    }
}