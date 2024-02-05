using Microsoft.AspNetCore.Mvc;
using RepoExplorer.Application.Repository.Services;

namespace RepoExplorer.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReposController : ControllerBase
{
    [HttpPost("contributors/format")]
    public async Task<IActionResult> FormatContributors([FromBody] IReadOnlyList<string> contributors, [FromServices]IFormattingService formattingService)
    {
        var result = await formattingService.FormatContributorsForMarkdownAsync(contributors);
        return Ok(result);
    }
}