namespace Minato.Endpoints;
using Minato.Endpoints.Server;

// Adds all server endpoints.
public static class ServerEndpoints
{
    public static void MapProductRoutes(this WebApplication app)
    {
        ServerInfoEndpoint.MapProductRoutes(app);
        ServerStatsEndpoint.MapProductRoutes(app);
    }
}