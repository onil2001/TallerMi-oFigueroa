using Microsoft.AspNetCore.Hosting;
using Mi�oFigueroa;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var starup = new Startup(builder.Configuration);


starup.ConfigureServices(builder.Services);

var app = builder.Build();

starup.Configure(app, app.Environment);

app.Run();

