using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using testTrain.Data;
using testTrain.Model;

namespace testTrain.Controllers
{
    [Route("[controller]")]
   [ApiExplorerSettings(IgnoreApi = true)]

    public class HomeController : Controller
    { private readonly DataContext _ctx;
        public HomeController(DataContext ctx)
        {
            this._ctx = ctx;

        }
        // GET: HomeController
        [Route("index")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public ActionResult Index()
        {
            
            return View(_ctx.delieveryDrivers.ToList());
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("createdeliveryman")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("createDeliveryMan")]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult createDeliveryMan( delieveryMan man)
        {
          

            return View();
        }

        // POST: HomeController/Create


        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    

    }


}

    

