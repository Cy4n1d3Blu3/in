using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzWeb.Interfaces;
using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzWeb.Pages
{
    public class WszystkieModel : PageModel
    {
        private readonly IDataService DataService;
        public WszystkieModel(IDataService dataService)
        {
            DataService = dataService;
        }

        public IQueryable<Models.Data> data;

        public void OnGet()
        {
            data = DataService.GetAllEntries();
        }
    }
}
