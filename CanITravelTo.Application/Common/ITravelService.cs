using Application.Models;

namespace Application.Common;

public interface ITravelService
{
    Task<CitizenCanTravelResponse> CanTravelAsync(string citizen, string country);
}
