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

        public async Task<IActionResult> ShowThetre()
        {
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiURL"] + "Thetre/selectThetre";

                using (var response = await client.GetAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        var thetreModel = JsonConvert.DeserializeObject<List<TheatreModel>>(data);
                        return View(thetreModel);
                    }
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddThetre()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddThetre(TheatreModel theatreModel)
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
                        ViewBag.message = "Sorry.. Unable To Add Theatre..!!";
                    }
                }
                return View();
            }
        }
    }
}
