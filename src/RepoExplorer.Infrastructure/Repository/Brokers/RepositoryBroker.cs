using Octokit;
using RepoExplorer.Application.Repository.Brokers;

namespace RepoExplorer.Infrastructure.Repository.Brokers;

/// <summary>
/// Provides a repository broker functionality.
/// </summary>
public class RepositoryBroker(GitHubClient gitHubClient) : IRepositoryBroker
{
    public ValueTask<IReadOnlyList<RepositoryContributor>> GetContributorsAsync(string repositoryId)
    {
        throw new NotImplementedException();
    }

    public ValueTask<IReadOnlyList<RepositoryContributor>> GetContributorsAsync(string owner, string repositoryName)
    {
        throw new NotImplementedException();
    }
}