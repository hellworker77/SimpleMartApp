using Mart.Identity.Preset;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityCors();

var connectionString = builder.Configuration.GetConnectionString("entityDb");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(connectionString,
        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
    options.UseLazyLoadingProxies();
});


builder.Services.AddIdentityConfigurations();

builder.Services.AddIdentityServerContextsConfiguration(builder.Configuration);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseCorsWithPolicy();

app.UseHttpsRedirection();

app.UseRouting();

app.UseIdentityServer();

app.UseAuthorization();

app.MapControllers();

app.Run();
