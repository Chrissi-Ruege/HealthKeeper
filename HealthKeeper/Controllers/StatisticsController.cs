using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using HealthKeeper.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace HealthKeeper.Controllers;

[AllowAnonymous]
[Route("[controller]")]
public class StatisticsController : Controller
{
    private const double MinWeight = 0;
    private const double MaxWeight = 300;

    private const double MinHeight = 0.5;
    private const double MaxHeight = 2.5;

    private readonly DatabaseContext _ctx;

    public StatisticsController(DatabaseContext ctx)
    {
        _ctx = ctx;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("{limit}")]
    public async Task<ActionResult<List<GetStatisticEntry>>> GetEntries(IdentityUser user, int limit)
    {
        /*  var entries = await _ctx.StatsEntries
              .OrderBy(x => x.Timestamp)
              .Take(limit)
              .Where(x => x.UserId == user.Id)
              .Select(x => Tuple.Create(x.Weight, x.Height, CalculateBMI(x.Height, x.Weight)))
              .Select(x => new GetStatisticEntry(x.Item1, x.Item2, x.Item3, BmiToText(x.Item3)))
              .ToListAsync();
          return Ok(entries);*/
        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> AddEntry(IdentityUser user, [FromBody] PostStatisticEntry body)
    {
        var weight = body.Weight;

        // Validate weight input
        if (weight <= MinWeight || weight >= MaxWeight)
        {
            return BadRequest($"The provided weight needs to be in range {MinWeight}-{MaxWeight}.");
        }

        // Check if height is provided or try to use last value
        var height = body.Height ?? await GetLastHeight(user);

        // Check if a height could be determined.
        if (height == null)
        {
            return BadRequest("Height needs to be provided");
        }

        // Validate height input
        if (height <= MinHeight || height >= MaxHeight)
        {
            return BadRequest($"The provided height needs to be in range {MinHeight}-{MaxWeight}");
        }

        var entry = new StatisticEntry()
        {
            UserId = user.Id,
            Timestamp = DateTime.UtcNow,
            Weight = weight,
            Height = (double)height
        };

        _ctx.StatsEntries.Add(entry);
        await _ctx.SaveChangesAsync();
        return Ok();
    }

    private async Task<double?> GetLastHeight(IdentityUser user)
    {
        var entry = await GetLatestEntry(user);
        return entry?.Height;
    }

    private async Task<StatisticEntry?> GetLatestEntry(IdentityUser user)
    {
        return await _ctx.StatsEntries
            .Where(x => x.UserId == user.Id)
            .OrderBy(x => x.Timestamp)
            .FirstOrDefaultAsync();
    }

    public record PostStatisticEntry(double Weight, double? Height);

    public record GetStatisticEntry(double Weight, double Height, double Bmi, string Category);
}