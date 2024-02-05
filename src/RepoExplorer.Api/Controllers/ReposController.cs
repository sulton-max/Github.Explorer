using Microsoft.AspNetCore.Mvc;
using Octokit;

namespace RepoExplorer.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReposController : ControllerBase
{
    [HttpGet("{owner}/{repositoryName}/contributors")]
    public async Task<IActionResult> GetContributorsAsync([FromServices] IGitHubClient gitHubClient, string owner, string repositoryName)
    {
        var contributors = await gitHubClient.Repository.GetAllContributors(owner, repositoryName);
        return Ok(contributors);
    }

    [HttpGet("{repositoryId:long}/contributors")]
    public async Task<IActionResult> GetContributorsAsync([FromServices] IGitHubClient gitHubClient, long repositoryId)
    {
        var contributors = await gitHubClient.Repository.GetAllContributors(repositoryId);
        return Ok(contributors);
    }
}