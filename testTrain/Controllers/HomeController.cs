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
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace testTrain.Controllers
{
    [Route("[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]

    public class HomeController : Controller
    {
        private readonly DataContext _ctx;
        private readonly IMapper _mapper;
        private readonly UserManager<DelieveryMan> _userManager;
        public HomeController(DataContext ctx, IMapper mapper , UserManager<DelieveryMan> userManager)
        {
            this._ctx = ctx;
            this._mapper = mapper;
            this._userManager = userManager;
        }
      
        // GET: HomeController
        [Route("index")]
        public ActionResult Index()
        {
            var Users = _ctx.Users.ToList();
            var ShowDeliveryManData = _mapper.Map<List<DelieveryMan>,List<DisplayDeliveryManVM>>(Users);

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
        [Route("CreateDeliveryMan")]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> CreateDeliveryMan(CreateDeliveryManVM DeliveryManVM)
        {

            var DeliveryMan = _mapper.Map<DelieveryMan>(DeliveryManVM);
            DeliveryMan.UserName = DeliveryMan.PhoneNumber;
            DeliveryMan.Id = Guid.NewGuid().ToString();
            var IsCreated = await _userManager.CreateAsync(DeliveryMan, DeliveryManVM.Password);
            if (IsCreated.Succeeded)
            {

                return RedirectToAction("Index");

            }

            return View();
        }





       
    }


}

    

