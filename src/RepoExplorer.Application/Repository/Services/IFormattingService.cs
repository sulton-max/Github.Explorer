namespace RepoExplorer.Application.Repository.Services;

/// <summary>
/// Defines the formatting service functionality.
/// </summary>
public interface IFormattingService
{
    /// <summary>
    /// Formats contributors for markdown.
    /// </summary>
    /// <param name="contributorsUsername">List of contributors username</param>
    /// <returns></returns>
    ValueTask<string> FormatContributorsForMarkdownAsync(IReadOnlyList<string> contributorsUsername);
}