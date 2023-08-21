using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Workdb.Data;
using Workdb.Models;
using Workdb.WorkDTOs;

namespace Workdb.Services.City
{
    public class CityService : ICityService
    {

        private readonly DataContext _dataContext;

        public CityService(DataContext dataContext) {
        
            _dataContext = dataContext;

        }

        public Task<List<CityDto>> GetCitiesList()
        {
            throw new NotImplementedException();
        }
    }
}
