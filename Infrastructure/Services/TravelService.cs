using Application.Common;
using Application.Models;
using Domain.Entities;
using Domain.Enums;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class TravelService : ITravelService
{
    private readonly IRepository<Permission> _permissionsRepository;

    public TravelService(IRepository<Permission> permissionRepository)
    {
        _permissionsRepository = permissionRepository;
    }

    public async Task<CitizenCanTravelResponse> CanTravelAsync(string citizenOf, string country)
    {
        var permissions = await _permissionsRepository.GetAll().Where(x => x.Citizen.Country.Name == citizenOf && x.Country.Name == country).ProjectToType<ApplicationPermission>().ToListAsync();

        if (permissions.Any(x => x.Rule.Rigidity == RuleRigidity.Forbiddance))
        {
            return new CitizenCanTravelResponse
            {
                CanTravel = false,
                Permissions = permissions.Where(x => x.Rule.Rigidity == RuleRigidity.Forbiddance).ToList()
            };
        }

        return new CitizenCanTravelResponse { CanTravel = true, Permissions = permissions.OrderByDescending(x => x.Rule.Rigidity).ToList() };
    }
}
