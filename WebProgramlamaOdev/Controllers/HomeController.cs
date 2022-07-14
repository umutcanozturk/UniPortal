
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.Controllers
{   [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult DersListesi()
        {
            return View();
        }
        public IActionResult ButunDersler()
        {
            return View();
        }
        public IActionResult DersHakkında()
        {
            return View();
        }
        public IActionResult ButunProfesorler()
        {

            return View();
        }
        public IActionResult ProfesorEkle()
        {
            return View();
        }
        public IActionResult ProfesorDuzenle()
        {
            return View();
        }
        public IActionResult ProfesorProfil()
        {
            return View();
        }
        public IActionResult DersEkle()
        {
            return View();
        }
        public IActionResult DersDuzenle()
        {
            return View();
        }
        public IActionResult ButunKutuphaneler()
        {
            return View();
        }
        public IActionResult KutuphaneEkle()
        {
            return View();
        }
        public IActionResult KutuphaneDuzenle()
        {
            return View();
        }
        public IActionResult ButunFakulteler()
        {
            return View();
        }
        public IActionResult FakulteEkle()
        {
            return View();
        }
        public IActionResult FakulteDuzenle()
        {
            return View();
        }
        public IActionResult ButunPersonel()
        {
            return View();
        }
        public IActionResult PersonelEkle()
        {
            return View();
        }
        public IActionResult PersonelDuzenle()
        {
            return View();
        }
        public IActionResult PersonelProfil()
        {
            return View();
        }
        public IActionResult Butunİzinler()
        {
            return View();
        }
        public IActionResult İzinEkle()
        {
            return View();
        }
        public IActionResult İzinDuzenle()
        {
            return View();
        }
        public IActionResult İzinTakvimi()
        {
            return View();
        }
        public IActionResult OdemeOzetleri()
        {
            return View();
        }
        public IActionResult OdemeEkle()
        {
            return View();
        }
        public IActionResult OdemeMakbuzlari()
        {
            return View();
        }
        public IActionResult KayitOl()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
