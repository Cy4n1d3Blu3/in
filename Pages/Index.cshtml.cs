using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using FizzBuzzWeb.Models;
using FizzBuzzWeb.Data;
using FizzBuzzWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using FizzBuzzWeb.Interfaces;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> Logger;
        
        [BindProperty]
        public Models.Data data { get; set; }

        private readonly PeopleContext Context;
        private readonly IDataService DataService;
        public IndexModel(ILogger<IndexModel> logger, PeopleContext context, IDataService dataService)
        {
            DataService = dataService;
            Logger = logger;
            Context = context;
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                data.Date = DateTime.Now;
                data.Leap = data.isleapyer();
                DataService.AddEntry(data);
            }
            return Page();
        }
    }
}
