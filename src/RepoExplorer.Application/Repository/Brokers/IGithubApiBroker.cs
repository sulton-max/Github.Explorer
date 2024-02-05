using RepoExplorer.Application.Repository.Models;

namespace RepoExplorer.Application.Repository.Brokers;

/// <summary>
/// Defines the Github API broker functionality.
/// </summary>
public interface IGithubApiBroker
{
    /// <summary>
    /// Get github usr by username.
    /// </summary>
    /// <param name="username">Username of user being queried</param>
    /// <returns>Github user if found, otherwise null</returns>
    ValueTask<GithubUser?> GetUserAsync(string username);
}