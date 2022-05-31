using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MovieApp.Entity;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.UI.Controllers
{
    public class TheatreController : Controller
    {
        IConfiguration _configuration;

        public TheatreController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> ShowTheatre()
        {
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiURL"] + "Theatre/selectTheatre";

                using (var response = await client.GetAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        var theatreModel = JsonConvert.DeserializeObject<List<TheatreModel>>(data);
                        return View(theatreModel);
                    }
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddTheatre()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddTheatre(TheatreModel theatreModel)
        {
            StringContent body = new StringContent(JsonConvert.SerializeObject(theatreModel), Encoding.UTF8, "application/json");
            string endpoint = _configuration["WebApiURL"] + "Theatre/addTheatre";
            using (HttpClient httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsync(endpoint, body))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Success";
                        ViewBag.message = "Theatre Added Successfully..!!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Soory.. Unable To Add Theatre..!!";
                    }
                }
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTheatre(int id)
        {
            string URL = _configuration["WebApiURL"] + "Theatre/FetchTheatre?id=" + id;
            using (HttpClient httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(URL))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var body = await response.Content.ReadAsStringAsync();
                        TheatreModel theatreModel = JsonConvert.DeserializeObject<TheatreModel>(body);
                        return View(theatreModel);
                    }
                }
            }
            return RedirectToAction("ShowTheatre", "Theatre");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTheatre(TheatreModel theatreModel)
        {
            StringContent body = new StringContent(JsonConvert.SerializeObject(theatreModel), Encoding.UTF8, "application/json");
            string URL = _configuration["WebApiURL"] + "Thetre/EditThetre";
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.PutAsync(URL, body))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return RedirectToAction("ShowTheatre", "Theatre");
                    }
                }
            }
            return RedirectToAction("ShowTheatre", "Theatre");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTheatre(int id)
        {
            string endpoint = _configuration["WebApiURL"] + "Theatre/DeleteThetre?id=" + id;
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.DeleteAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return RedirectToAction("ShowTheatre", "Theatre");
                    }
                }
            }
            return RedirectToAction("ShowTheatre", "Theatre");
        }
    }
}
