namespace RepoExplorer.Api.Configurations;

public static partial class HostConfiguration
{
    /// <summary>
    /// Configures application builder
    /// </summary>
    /// <param name="builder">Application builder</param>
    /// <returns>Application builder</returns>
    public static ValueTask<WebApplicationBuilder> ConfigureAsync(this WebApplicationBuilder builder)
    {
        builder
            .AddGithubInfrastructure()
            .AddDevTools()
            .AddExposers();

        return new(builder);
    }

    /// <summary>
    /// Configures application
    /// </summary>
    /// <param name="app">Application host</param>
    /// <returns>Application host</returns>
    public static ValueTask<WebApplication> ConfigureAsync(this WebApplication app)
    {
        app
            .UseDevTools()
            .UseExposers()
            .UseStaticFiles();
        
        return ValueTask.FromResult(app);
    }
}