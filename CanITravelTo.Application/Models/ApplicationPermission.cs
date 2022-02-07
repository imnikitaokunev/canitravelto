namespace Application.Models;

public class ApplicationPermission
{
    public int Id { get; set; }
    public ApplicationCitizen Citizen { get; set; }
    public ApplicationCountry Country { get; set; }
    public ApplicationRule Rule { get; set; }
}
