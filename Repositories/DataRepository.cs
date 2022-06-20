using FizzBuzzWeb.Data;
using FizzBuzzWeb.Interfaces;
using FizzBuzzWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzWeb.Repositories
{
    public class DataRepository : IDataRepository
    {
        public PeopleContext Context;
        public DateTime Today = DateTime.Today;

        public DataRepository(PeopleContext context)
        {
            Context = context;
        }

        public IQueryable<Models.Data> GetAllDane()
        {
            return Context.data;
        }

        public IQueryable<Models.Data> GetAllTodayDane()
        {
            return Context.data.Where(p => (p.Date.Date == Today));
        }

        public void AddDane(Models.Data data)
        {
            Context.Add(data);
            Context.SaveChanges();
        }


    }
}
