namespace Domain.Entities;

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Citizen> Citizens { get; set; }
    public ICollection<Permission> Permissions { get; set; }
}
