using System.Text.Json.Serialization;

namespace RepoExplorer.Application.Repository.Models;

/// <summary>
/// Represents a Github user.
/// </summary>
public class GithubUser
{
    [JsonPropertyName("login")]
    public string Login { get; set; } = default!;

    [JsonPropertyName("id")]
    public long Id { get; set; } = default!;

    [JsonPropertyName("node_id")]
    public string NodeId { get; set; } = default!;

    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; } = default!;

    [JsonPropertyName("gravatar_id")]
    public string GravatarId { get; set; } = default!;

    [JsonPropertyName("url")]
    public string Url { get; set; } = default!;

    [JsonPropertyName("html_url")]
    public string HtmlUrl { get; set; } = default!;

    [JsonPropertyName("followers_url")]
    public string FollowersUrl { get; set; } = default!;

    [JsonPropertyName("following_url")]
    public string FollowingUrl { get; set; } = default!;

    [JsonPropertyName("gists_url")]
    public string GistsUrl { get; set; } = default!;

    [JsonPropertyName("starred_url")]
    public string StarredUrl { get; set; } = default!;

    [JsonPropertyName("subscriptions_url")]
    public string SubscriptionsUrl { get; set; } = default!;

    [JsonPropertyName("organizations_url")]
    public string OrganizationsUrl { get; set; } = default!;

    [JsonPropertyName("repos_url")]
    public string ReposUrl { get; set; } = default!;

    [JsonPropertyName("events_url")]
    public string EventsUrl { get; set; } = default!;

    [JsonPropertyName("received_events_url")]
    public string ReceivedEventsUrl { get; set; } = default!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("site_admin")]
    public bool SiteAdmin { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("company")]
    public string Company { get; set; } = default!;

    [JsonPropertyName("blog")]
    public string Blog { get; set; } = default!;

    [JsonPropertyName("location")]
    public string Location { get; set; } = default!;

    [JsonPropertyName("email")]
    public string Email { get; set; } = default!;

    [JsonPropertyName("hireable")]
    public bool? Hireable { get; set; }

    [JsonPropertyName("bio")]
    public string Bio { get; set; } = default!;

    [JsonPropertyName("twitter_username")]
    public string TwitterUsername { get; set; } = default!;

    [JsonPropertyName("public_repos")]
    public int PublicRepos { get; set; }

    [JsonPropertyName("public_gists")]
    public int PublicGists { get; set; }

    [JsonPropertyName("followers")]
    public int Followers { get; set; }

    [JsonPropertyName("following")]
    public int Following { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
}