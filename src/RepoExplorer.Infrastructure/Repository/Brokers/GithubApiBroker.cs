using System.Net;
using System.Text.Json;
using RepoExplorer.Application.Repository.Brokers;
using RepoExplorer.Application.Repository.Models;

namespace RepoExplorer.Infrastructure.Repository.Brokers;

/// <summary>
/// Provides a Github API broker.
/// </summary>
public class GithubApiBroker(HttpClient httpClient) : IGithubApiBroker
{
    public async ValueTask<GithubUser?> GetUserAsync(string username)
    {
        var response = await httpClient.GetAsync($"users/{username}");
        var test = httpClient.DefaultRequestHeaders.Authorization;

        return response.StatusCode switch
        {
            HttpStatusCode.OK or HttpStatusCode.NotModified => JsonSerializer.Deserialize<GithubUser>(await response.Content.ReadAsStringAsync()),
            HttpStatusCode.NotFound => null,
            _ => throw new Exception("Failed to get user from Github API")
        };
    }
}