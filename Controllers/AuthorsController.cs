using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{

    public class AuthorsController : Controller{
        [Route("")]
        [Route("authors")]
        

        public IActionResult Index(){
            return Content("This is the authors controller's Index Action");
        }
        [Route("authors/featured")]

        public IActionResult Featured(){
            return Content("This is the authors controller's featured Action");
        }
        
    }
}