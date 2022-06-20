using FizzBuzzWeb.Interfaces;
using FizzBuzzWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzWeb.Services
{
    public class DataService : IDataService
    {
        private readonly IDataRepository DataRepo;

        public DataService(IDataRepository DataRepository)
        {
            DataRepo = DataRepository;
        }

        public IQueryable<Models.Data> GetAllEntries()
        {
            IQueryable<Models.Data> data = DataRepo.GetAllDane();
            return data;
        }

        public IQueryable<Models.Data> GetEntriesFromToday()
        {
            IQueryable<Models.Data> data = DataRepo.GetAllTodayDane();
            return data;
        }

        public void AddEntry(Models.Data data)
        {
            DataRepo.AddDane(data);
        }
    }
}
