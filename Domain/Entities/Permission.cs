namespace Domain.Entities;

public class Permission
{
    public int Id { get; set; }
    public int CitizenId { get; set; }
    public int CountryId { get; set; }
    public int RuleId { get; set; }

    public Citizen Citizen { get; set; }
    public Country Country { get; set; }
    public Rule Rule { get; set; }
}
