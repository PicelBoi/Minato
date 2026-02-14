
// Contains schemas for server info and stats.

namespace Minato.Core;

// Schemas.

public class ServerInfo
{
    public string Name { get; set; } = "Minato";

    public string Address { get; set; } = "minato.picelboi.xyz";

    public string Description { get; set; } = "Minato is a server made by PicelBoi to host the experimental IM protocol known as the PicelBoi Chat Protocol.";

    public string Symbol { get; set; } = "👍";

    public string Motto { get; set; } = "Memento mori.";

    public string Website { get; set; } = "https://picelboi.xyz";

    public string Color { get; set; } = "#87ceeb";
}

public class ServerStats
{
    public int UsersOn { get; set; } = 0;

    public int UsersRegistered { get; set; } = 0;

    public int UsersMax { get; set; } = 0;

    public int TextChannels { get; set; } = 0;

    public int VoiceChannels { get; set; } = 0;

    public int Roles { get; set; } = 0;
}