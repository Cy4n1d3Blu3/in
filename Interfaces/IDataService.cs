using FizzBuzzWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzWeb.Interfaces
{
    public interface IDataService
    {
        public void AddEntry(Models.Data data);

        public IQueryable<Models.Data> GetAllEntries();

        public IQueryable<Models.Data> GetEntriesFromToday();

    }
}
