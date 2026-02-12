using Minato.Endpoints;

// Create builder.
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add log.
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Index message.
app.MapGet("/", () => "Hello world, this is Minato version INDEV v1.0.0.");

// Define all endpoints.
Endpoints.MapProductRoutes(app);

app.Run();