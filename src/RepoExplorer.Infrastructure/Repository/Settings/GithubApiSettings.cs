using RepoExplorer.Infrastructure.Settings;

namespace RepoExplorer.Infrastructure.Repository.Settings;

/// <summary>
/// Represents github API settings
/// </summary>
public class GithubApiSettings : ApiSettings
{
    public string UsersEndpoint { get; set; } = default!;
    
    public string AccessToken { get; set; } = default!;
}