using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WebProgramlamaOdev.Core.Models;
using WebProgramlamaOdev.Models.ViewModels;

namespace WebProgramlamaOdev.Controllers.StudentNS
{
    [Authorize]
    public class StudentController : Controller
    {
        public IActionResult ButunOgrenciler()
        {
            WebClient webClient = new WebClient();
            var json = webClient.DownloadString("https://localhost:44385/Student/GetAll");
            var x = JsonConvert.DeserializeObject<List<WebProgramlamaOdev.Core.Models.Student>>(json);
            var vm = new StudentViewModel();
            vm.StudentList = x; 
            return View(vm);
        }
        public IActionResult OgrenciEkleSayfasi()
        {
            return View();
        }

        public async Task< IActionResult > OgrenciEkle(Student student)
        {
            using (var client = new HttpClient())
            {
                var url = ("https://localhost:44385/Student/Add");

                //HTTP POST
                var stu = JsonConvert.SerializeObject(student);
                var requestContent = new StringContent(stu, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, requestContent);

                return RedirectToAction("ButunOgrenciler");
            }
        }
        [HttpGet]
        public IActionResult OgrenciDuzenle(int studentid)
        {
            WebClient webClient = new WebClient();
            var vm = webClient.DownloadString("https://localhost:44385/Student/GetById/"+studentid);
            var x = JsonConvert.DeserializeObject<Student>(vm);
            return View(x);
        }
        public IActionResult OgrenciHakkinda(int studentid)
        {
            WebClient webClient = new WebClient();
            var vm = webClient.DownloadString("https://localhost:44385/Student/GetById/"+studentid);
            var x = JsonConvert.DeserializeObject<Student>(vm);
            return View(x);
        }
        public async Task<IActionResult >OgrenciDuzenle(Student student)
        {


            using (var client = new HttpClient())
            {
                var url =("https://localhost:44385/Student/Update");

                //HTTP POST
                var stu = JsonConvert.SerializeObject(student);
                var requestContent = new StringContent(stu, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, requestContent);

                return RedirectToAction("OgrenciDuzenle", new { studentid = student.ID });
            }           
        }
        public IActionResult OgrenciSil(int id)
        {
            WebClient webClient = new WebClient();
            var vm = webClient.DownloadString("https://localhost:44385/Student/Delete/" + id);

            return RedirectToAction("ButunOgrenciler");
        }
    }
}
