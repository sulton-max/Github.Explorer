using Octokit;

namespace RepoExplorer.Application.Repository.Brokers;

/// <summary>
/// Defines the repository broker functionality.
/// </summary>
public interface IRepositoryBroker
{
    /// <summary>
    /// Gets contributors of a repository.
    /// </summary>
    /// <param name="repositoryId">Repository id</param>
    /// <returns>List of contributors</returns>
    ValueTask<IReadOnlyList<RepositoryContributor>> GetContributorsAsync(string repositoryId);
    
    /// <summary>
    /// Gets contributors of a repository.
    /// </summary>
    /// <param name="owner">Username of repository owner</param>
    /// <param name="repositoryName">Repository name</param>
    /// <returns>List of contributors</returns>
    ValueTask<IReadOnlyList<RepositoryContributor>> GetContributorsAsync(string owner, string repositoryName);
}