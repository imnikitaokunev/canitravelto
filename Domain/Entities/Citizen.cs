namespace Domain.Entities;

public class Citizen
{
    public int Id { get; set; }
    public int CountryId { get; set; }

    public Country Country { get; set; }
    public ICollection<Permission> Permissions { get; set; }
}
