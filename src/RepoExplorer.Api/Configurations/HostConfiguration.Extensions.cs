using System.Net.Http.Headers;
using RepoExplorer.Application.Repository.Brokers;
using RepoExplorer.Application.Repository.Services;
using RepoExplorer.Infrastructure.Repository.Brokers;
using RepoExplorer.Infrastructure.Repository.Services;
using RepoExplorer.Infrastructure.Settings;

namespace RepoExplorer.Api.Configurations;

public static partial class HostConfiguration
{
    /// <summary>
    /// Configures exposers including controllers
    /// </summary>
    /// <param name="builder">Application builder</param>
    /// <returns></returns>
    private static WebApplicationBuilder AddGithubInfrastructure(this WebApplicationBuilder builder)
    {
        // Register clients
        builder.Services.AddHttpClient<IGithubApiBroker, GithubApiBroker>(
            client =>
            {
                client.BaseAddress = new Uri(builder.Configuration["GithubApiSettings:BaseAddress"]!);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                    "Bearer",
                    builder.Configuration["GithubApiSettings:AccessToken"]
                );
                client.DefaultRequestHeaders.Add("User-Agent", "Explorer");
            }
        );

        return builder;
    }
    
    /// <summary>
    /// Configures exposers including controllers
    /// </summary>
    /// <param name="builder">Application builder</param>
    /// <returns></returns>
    private static WebApplicationBuilder AddExposers(this WebApplicationBuilder builder)
    {
        // Add formatters
        builder.Services.AddRouting(options => options.LowercaseUrls = true);
        builder.Services.AddControllers();

        builder.Services.Configure<ApiSettings>(builder.Configuration.GetSection(nameof(ApiSettings)));

        return builder;
    }

    /// <summary>
    /// Configures devTools including controllers
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    private static WebApplicationBuilder AddDevTools(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        return builder;
    }

    /// <summary>
    /// Add Controller middleWhere
    /// </summary>
    /// <param name="app">Application host</param>
    /// <returns>Application host</returns>
    private static WebApplication UseExposers(this WebApplication app)
    {
        app.MapControllers();

        return app;
    }

    /// <summary>
    /// Add Controller middleWhere
    /// </summary>
    /// <param name="app">Application host</param>
    /// <returns>Application host</returns>
    private static WebApplication UseDevTools(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        return app;
    }
}