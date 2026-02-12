namespace Minato.Endpoints.Server;

using Minato.Core.Server;

public static class ServerStatsEndpoint
{
    public static void MapProductRoutes(this WebApplication app)
    {
        app.MapGet("/server/stats", () => new ServerStats());
    }
}