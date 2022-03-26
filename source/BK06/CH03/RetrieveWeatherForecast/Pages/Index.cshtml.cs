using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

// Added Using Statements
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Text.Json;

namespace RetrieveWeatherForecast.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public String myData { get; set; }

        public async Task OnGet()
        {
            // Create a client object to retrieve the data.
            HttpClient client = new HttpClient();

            // Tell the client object where to obtain the data
            // and what format the data will appear in.
            client.BaseAddress = 
                new Uri("https://localhost:44327/weatherforecast");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            // Provide a default response and then obtain the data.
            myData = "No Weather Report Today";
            HttpResponseMessage getData = 
                await client.GetAsync("https://localhost:44327/weatherforecast");

            // If the data access was a success, then read it from the response
            // and display it on screen.
            if (getData.IsSuccessStatusCode)
            {
                String data = getData.Content.ReadAsStringAsync().Result;

                // Deserialize the JSON data as a WeatherForecast array.
                WeatherForecast[] JSONData = 
                    JsonSerializer.Deserialize<WeatherForecast[]>(data);

                // Output each weather forecast as a row in a table.
                myData = "";
                foreach (WeatherForecast Item in JSONData)
                {
                    myData += "<tr>";
                    myData += "<td>" + Item.date.ToLongDateString() + "</td>";
                    myData += "<td>" + Item.temperatureC + "</td>";
                    myData += "<td>" + Item.temperatureF + "</td>";
                    myData += "<td>" + Item.summary + "</td>";
                    myData += "</tr>";
                }
            }

            await Task.Delay(1000);
        }
    }
}
