namespace Minato.Core;

// Covers users.

public class User
{
    public Guid Guid { get; set; } = Guid.NewGuid();

    public string ID { get; set; } = "perry@auth.picelboi.xyz";

    public string DisplayName { get; set; } = "Perry";

    public string PublicKey = "";

    public string Pronouns { get; set; } = "";

    public string Bio { get; set; } = "";

    public List<Role> Roles { get; set; } = new();
}