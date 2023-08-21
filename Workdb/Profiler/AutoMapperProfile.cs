using AutoMapper;
using Workdb.Models;
using Workdb.WorkDTOs;

namespace Workdb.Profiler
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() { 

            CreateMap<City,CityDto>().ReverseMap(); 
            CreateMap<EmployeeDto,Employee>().ReverseMap();
            CreateMap<EmployeeTransferSalary,EmployeeTransferSalaryDto>().ReverseMap();

        }
    }
}
