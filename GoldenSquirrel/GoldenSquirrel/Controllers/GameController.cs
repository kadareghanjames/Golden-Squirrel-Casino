using GoldenSquirrel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoldenSquirrel.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            Game g = new Game()
            {
                Number = 1,
                Image = @"https://target.scene7.com/is/image/Target/GUEST_171cec78-3b75-4b09-9d8a-ee62d58c121b?wid=488&hei=488&fmt=pjpeg"
            };
            Game a = new Game()
            {
                Number = 2,
                Image = @"http://clipart-library.com/data_images/306851.jpg"
            };
            Game t = new Game()
            {
                Number = 3,
                Image = @"https://previews.123rf.com/images/avelkrieg/avelkrieg1303/avelkrieg130300026/18203835-illustration-of-a-cartoon-tree-on-a-patch-of-grass.jpg"
            };
            Game p = new Game()
            {
                Number = 4,
                Image = @"https://i.ytimg.com/vi/rK--l8XSSV0/hqdefault.jpg"
            };

            return View();
        }
    }
}