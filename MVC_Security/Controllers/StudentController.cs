using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Security.Controllers
{
    // Controller enkel toegankelijk indien ingelogd (role of name maakt niet uit)
    //[Authorize]
    //// Enkel toegankelijk voor bepaalde Roles
    [Authorize(Roles = "Student, Leraar")]
    public class StudentController : Controller
    {
        // GET: Student
        // Indien bepaalde methode wel bereikbaar moet zijn voor niet ingelogde gebruikers gebruik( bij [Authorize] voor controller) :
        // [AllowAnonymous]
        // Indien enkel methode dient bereikbaar te zijn voor ingelogde gebruikers en niet volledige controller
        // [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}