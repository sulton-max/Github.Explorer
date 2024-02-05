using System.Text;
using System.Xml.XPath;
using RepoExplorer.Application.Repository.Brokers;
using RepoExplorer.Application.Repository.Services;

namespace RepoExplorer.Infrastructure.Repository.Services;

/// <summary>
/// Provides a formatting service functionality.
/// </summary>
public class FormattingService(IGithubApiBroker githubApiBroker) : IFormattingService
{
    public async ValueTask<string> FormatContributorsForMarkdownAsync(IReadOnlyList<string> contributorsUsername)
    {
        // Query all contributors
        var contributors = await Task.WhenAll(contributorsUsername.Select(async contributor => await githubApiBroker.GetUserAsync(contributor)));

        // Format contributors
        var formattedContributors = contributors.Select(
                contributor =>
                {
                    // TODO : Use html document service to create elements
                    return $"""
                            <a href="{contributor!.HtmlUrl}"><img src="{contributor.AvatarUrl}" title="{contributor.Login}" width="50" height="50"></a>
                            """;
                }
            )
            .ToList();

        // Append elements to result
        var result = new StringBuilder();
        result.AppendLine("[//]: contributor-faces");
        result.AppendLine(Environment.NewLine);
        formattedContributors.ForEach(contributor => result.AppendLine(contributor));
        result.AppendLine(Environment.NewLine);
        result.AppendLine("[//]: contributor-faces");

        return result.ToString();
    }
}