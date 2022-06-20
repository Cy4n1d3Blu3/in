using FizzBuzzWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzWeb.Interfaces
{
    public interface IDataRepository
    {
        public void AddDane(Models.Data data);
        IQueryable<Models.Data> GetAllDane();

        IQueryable<Models.Data> GetAllTodayDane();
    }
}
