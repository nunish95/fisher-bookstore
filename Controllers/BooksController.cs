using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{

    public class BooksController : Controller{
        [Route("")]
        [Route("books")]
        

        public IActionResult Index(){
            return Content("This is the books controller's Index Action");
        }
        [Route("books/new")]

        public IActionResult New(){
            return Content("This is the books controller's New Action");
        }
        
    }
}