using AutoMapper;
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
using testTrain.Model.ViewModels;
using testTrain.Configuration;
namespace testTrain.Controllers
{
    [Route("[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]

    public class HomeController : Controller
    {
        private readonly DataContext _ctx;
        private readonly IMapper _mapper;
        public HomeController(DataContext ctx, IMapper mapper)
        {
            this._ctx = ctx;
            this._mapper = mapper;

        }
      
        // GET: HomeController
        [Route("index")]
        public ActionResult Index()
        {
            var Users = _ctx.Users.ToList();
            var ShowDeliveryManData = _mapper.Map<List<delieveryMan>,List<DisplayDeliveryManVM>>(Users);
            return View(ShowDeliveryManData);
        }

        // GET: HomeController/Create
        [HttpGet]
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
        public IActionResult createDeliveryMan( delieveryMan man)
        {  using (var client = new System.Net.Http.HttpClient())
            {
                var postTask = client.PostAsJsonAsync<delieveryMan>("http://localhost:26767/api/delieveryMen", man);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }

        // POST: HomeController/Create




       
    }


}

    

