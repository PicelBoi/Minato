namespace Minato.Endpoints.Server;

using Minato.Core.Server;

public static class ServerInfoEndpoint
{
    public static void MapProductRoutes(this WebApplication app)
    {
        app.MapGet("/server/info", () => new ServerInfo());
    }
}