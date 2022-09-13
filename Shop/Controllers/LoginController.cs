using Shop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace AdminWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly DataFashionContext _context;
        public LoginController(DataFashionContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var user = HttpContext.Session.GetString("user");
            if(user != null)
            {
                return Redirect("/Home");
            }
            else
            {
                return View();
            }
           
        }
        public IActionResult IndexRes()
        {
            var user = HttpContext.Session.GetString("user");
            if (user != null)
            {
                return Redirect("/Home");
            }
            else
            {
                return View();
            }
        }
        [TempData]
        public string Message { get; set; }
        [HttpPost]
        public ActionResult LoginAdmin()
        {
            String email = HttpContext.Request.Form["Email"];
            String Pass = HttpContext.Request.Form["pass"];
            String btnLogin = HttpContext.Request.Form["login"];
            if(btnLogin != null)
            {
                //if(email == null)
                //{
                //    TempData["AlertType"] = "alert-warning";
                //    TempData["AlertMessage"] = "Email can't be empty! Please enter again!";
                //    return Redirect("/Login");

                //}
                //if (IsValidEmail(email) == false)
                //{
                //    TempData["AlertType"] = "alert-warning";
                //    TempData["AlertMessage"] = "Email format is invalid! Please enter again!";
                //    return Redirect("/Login");
                //}
                //if (Pass == null)
                //{
                //    TempData["AlertType"] = "alert-warning";
                //    TempData["AlertMessage"] = "Password can't be empty! Please enter again";
                //    return Redirect("/Login");
                //}
                var dataFashionContext = _context.Users.Include(u => u.Role);
                Console.WriteLine("Pass before get:" + Pass);
                Pass = GetMD5(Pass);
                Console.WriteLine("Pass after get:" + Pass);
                var data = dataFashionContext.Where(s => s.Email.Equals(email) && s.Password.Equals(Pass) && s.Status == 1 && s.RoleId.Equals("Customer")).ToList();
                if(data.Count > 0)
                {
                    HttpContext.Session.SetString("user", data.FirstOrDefault().Id.ToString());
                    
                    TempData["AlertType"] = "alert-success";
                    TempData["AlertMessage"] = "Login Success";
                    return RedirectToAction("Index", "Products");
                }
                else
                {
                    TempData["AlertType"] = "alert-warning";
                    TempData["AlertMessage"] = "Wrong pass or Email";
                    return Redirect("/Login");

                }
            }
            TempData["AlertType"] = "alert-warning";
            TempData["AlertMessage"] = "Wrong pass or Email";
            return Redirect("/Login");
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            ViewBag.Message = "Success";
            return Redirect("/Login");
        }
        [HttpPost]
        public ActionResult Res()
        {
          //  Id,Email,Password,Fullname,Phone,Address,Status,RoleId
               String email = HttpContext.Request.Form["Email"];
            String Pass = HttpContext.Request.Form["Password"];
            String Fullname = HttpContext.Request.Form["Fullname"];
            String Address = HttpContext.Request.Form["Address"];
            String Phone = HttpContext.Request.Form["Phone"];
            String btnRes= HttpContext.Request.Form["res"];
            if(btnRes != null)
            {
                if (checkEmailExist(email) == false)
                {
                    TempData["AlertType"] = "alert-warning";
                    TempData["AlertMessage"] = "Email is Exist";
                    return Redirect("/Login");
                }
                else
                {
                    User user = new User();
                    user.Email = email;
                    user.Password = Pass;
                    user.Address = Address;
                    user.Phone = Phone;
                    user.Fullname = Fullname;
                    user.Status = 1;
                    user.RoleId = "Customer";
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    TempData["AlertType"] = "alert-success";
                    TempData["AlertMessage"] = "Success";
                    return Redirect("/Login");
                }
            
            }
            TempData["AlertType"] = "alert-warning";
            TempData["AlertMessage"] = "Fail";
            return Redirect("/Login");
        }
     
        public ActionResult ChangeInfo()
        {
            String email = HttpContext.Request.Form["Email"];
            String Pass = HttpContext.Request.Form["Password"];
            String Fullname = HttpContext.Request.Form["Fullname"];
            String Address = HttpContext.Request.Form["Address"];
            String Phone = HttpContext.Request.Form["Phone"];
            String btnRes = HttpContext.Request.Form["res"];
           
             if (btnRes != null)
            {
                if (checkEmailExist(email) == false)
                {
                    ViewBag.Message = "Email is Exist";
                    return Redirect("/Login");
                }
                else
                {
                    User user = new User();
                    user.Email = email;
                    user.Password = Pass;
                    user.Address = Address;
                    user.Phone = Phone;
                    user.Fullname = Fullname;
                    user.Status = 1;
                    user.RoleId = "Customer";
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    ViewBag.Message = "Success";
                    return Redirect("/Login");
                }
               
            }
            return Redirect("");
        }
        public bool checkEmailExist(string Email)
        {
            var dataFashionContext = _context.Users.Include(u => u.Role);
            var data = dataFashionContext.Where(s => s.Email.Equals(Email)).ToList();
            if(data.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
          
        }
        //create a string MD5
        public static string GetMD5(string str)
        {
            Console.WriteLine("Before encode:" + str);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            Console.WriteLine("After encode:" + byte2String);

            return byte2String;
        }
        //public static bool IsValidEmail(string email)
        //{
        //    if (string.IsNullOrWhiteSpace(email))
        //        return false;

        //    try
        //    {
        //        // Normalize the domain
        //        email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
        //                              RegexOptions.None, TimeSpan.FromMilliseconds(200));

        //        // Examines the domain part of the email and normalizes it.
        //        string DomainMapper(Match match)
        //        {
        //            // Use IdnMapping class to convert Unicode domain names.
        //            var idn = new IdnMapping();

        //            // Pull out and process domain name (throws ArgumentException on invalid)
        //            string domainName = idn.GetAscii(match.Groups[2].Value);

        //            return match.Groups[1].Value + domainName;
        //        }
        //    }
        //    catch (RegexMatchTimeoutException e)
        //    {
        //        return false;
        //    }
        //    catch (ArgumentException e)
        //    {
        //        return false;
        //    }

        //    try
        //    {
        //        return Regex.IsMatch(email,
        //            @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
        //            RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        //    }
        //    catch (RegexMatchTimeoutException)    
        //    {
        //        return false;
        //    }
        }
    }
}
