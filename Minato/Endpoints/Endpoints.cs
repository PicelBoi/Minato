namespace Minato.Endpoints;
using Minato.Endpoints.Server;

// Adds all endpoints.
public static class Endpoints
{
    public static void MapProductRoutes(this WebApplication app)
    {
        ServerEndpoints.MapProductRoutes(app);
    }
}