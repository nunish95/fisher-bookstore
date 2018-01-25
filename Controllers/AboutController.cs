using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{

    public class AboutController : Controller{
        [Route("")]
        [Route("About")]
        [Route("About/Index")]

        public IActionResult Index(){
            return Content("This is the About controller's Index Action");
        }
        [Route("About/History")]

        public IActionResult History(){
            return Content("This is the About controller's History Action");
        }
        [Route("About/Location")]
        public IActionResult Location(){
            return Content("This is the About controller's Location Action");
        }
    }
}