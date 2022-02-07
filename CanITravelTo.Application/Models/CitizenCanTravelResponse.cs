namespace Application.Models;

public class CitizenCanTravelResponse
{
    public bool CanTravel { get; set; }
    public List<ApplicationPermission> Permissions { get; set; }
}
