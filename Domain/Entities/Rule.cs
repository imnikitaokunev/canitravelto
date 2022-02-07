using Domain.Enums;

namespace Domain.Entities;

public class Rule
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public RuleRigidity Rigidity { get; set; }

    public ICollection<Permission> Persmissions { get; set; }
}
