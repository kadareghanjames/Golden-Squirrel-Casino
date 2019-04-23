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
            Game elder = new Game()
            {
                Number = 1,
                Image = @"https://pbs.twimg.com/profile_images/1087746536665243649/hO-51lBr.jpg"
            };
            Game gacorn = new Game()
            {
                Number = 2,
                Image = @"https://media.glassdoor.com/sqll/192597/golden-acorn-casino-squarelogo-1462369646556.png"
            };

            Game spins = new Game()
            {
                Number = 3,
                Image = @"https://media1.tenor.com/images/df0c7e27c55ba3ade8f0ebe78718be76/tenor.gif?itemid=7442174"
            };
            Game acorn = new Game()
            {
                Number = 4,
                Image = @"http://clipart-library.com/data_images/306858.png"
            };
            Game tree = new Game()
            {
                Number = 5,
                Image = @"http://www.clker.com/cliparts/Z/Q/1/5/y/e/green-tree-md.png"
            };
            Game leaf = new Game()
            {
                Number = 6,
                Image = @"https://cdn.shopify.com/s/files/1/2040/0303/products/Pretty_Paint_Art_Cartoon_Leaf_Leaves_-_Fall_11_96229170_200x200.jpg?v=1508507362"
            };
            Game bsquir = new Game()
            {
                Number = 7,
                Image = @"https://i.pinimg.com/originals/d9/70/89/d970898b49b3198b6f57575227aba224.jpg"
            };


            List<Game> symbols = new List<Game>();
            symbols.Add(elder);
            symbols.Add(gacorn);
            symbols.Add(spins);
            symbols.Add(acorn);
            symbols.Add(tree);
            symbols.Add(leaf);
            symbols.Add(bsquir);


            return View(symbols);
        }
    }
}