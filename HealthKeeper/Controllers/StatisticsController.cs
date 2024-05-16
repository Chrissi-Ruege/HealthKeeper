using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using HealthKeeper.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace HealthKeeper.Controllers;

[Route("[controller]")]
[Authorize]
public class StatisticsController : Controller
{

    private const double MIN_WEIGHT = 0;
    private const double MAX_WEIGHT = 300;

    private const double MIN_HEIGHT = 0.5;
    private const double MAX_HEIGHT = 2.5;

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
        double weight = body.Weight;

        // Validate weight input
        if (weight <= MIN_WEIGHT || weight >= MAX_WEIGHT)
        {
            return BadRequest($"The provided weight needs to be in range {MIN_WEIGHT}-{MAX_WEIGHT}.");
        }

        double? height = body.Height;

        // Check if height is provided or try to use last value
        if (height == null)
        {
            height = await GetLastHeight(user);
        }

        // Check if a height could be determined.
        if (height == null)
        {
            return BadRequest("Height needs to be provided");
        }

        // Validate height input
        if (height <= MIN_HEIGHT || height >= MAX_HEIGHT)
        {
            return BadRequest($"The provided height needs to be in range {MIN_HEIGHT}-{MAX_WEIGHT}");
        }

        var entry = new StatisticEntry()
        {
            UserId = user.Id,
            Timestamp = DateTime.UtcNow,
            Weight = weight,
            Height = height ?? 0.0
        };

        _ctx.StatsEntries.Add(entry);
        await _ctx.SaveChangesAsync();
        return Ok();
    }

    /// <summary>
    /// Calculates the bmi value from the height and weight of a person.
    /// </summary>
    /// <param name="weight">The current weight in kilogram.</param>
    /// <param name="height">The current height in meter.</param>
    /// <returns>Returns the calculated bmi value.</returns>
    public double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }

    /// <summary>
    /// Returns the corresponding bmi category from a given bmi value.
    /// </summary>
    /// <see cref="https://www.calculator.net/bmi-calculator.html"/>
    /// <param name="bmi">BMI value</param>
    /// <returns>The name of the category</returns>
    public string BmiToText(double bmi)
    {
        switch (bmi)
        {
            case < 16.0:
                return "Severe Thinness";
            case < 17.0:
                return "Moderate Thinness";
            case < 18.5:
                return "Mild Thinness";
            case < 25.0:
                return "Normal";
            case < 30.0:
                return "Overweight";
            case < 35.0:
                return "Obese Class I";
            case < 40.0:
                return "Obese Class II";
            default:
                return "Obese Class III";
        }
    }

    private async Task<double?> GetLastHeight(IdentityUser user)
    {
        var entry = await GetLatestEntry(user);
        return entry?.Height;
    }

    private async Task<StatisticEntry?> GetLatestEntry(IdentityUser user)
    {
        return _ctx.StatsEntries
            .Where(x => x.UserId == user.Id)
            .OrderBy(x => x.Timestamp)
            .FirstOrDefault();
    }

    public record PostStatisticEntry(double Weight, double Height);

    public record GetStatisticEntry(double Weight, double Height, double Bmi, string Category);
}