using Workdb.WorkDTOs;

namespace Workdb.Models;

public interface ICityService
{
    Task<List<CityDto>> GetCitiesList();

}
