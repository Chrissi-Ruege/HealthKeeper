using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using HealthKeeper.Models.Database;
using Microsoft.EntityFrameworkCore;
using HealthKeeper.Utils;
using HealthKeeper.Models.Views;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;

namespace HealthKeeper.Controllers;

[Authorize]
[Route("[controller]")]
public class StatisticsController : Controller
{
    private const double MinWeight = 0;
    private const double MaxWeight = 300;

    private const double MinHeight = 60;
    private const double MaxHeight = 300;

    private readonly DatabaseContext _ctx;

    public StatisticsController(DatabaseContext ctx)
    {
        _ctx = ctx;
    }

    [HttpGet]
    public async Task<IActionResult> Index(IdentityUser user)
    {
        return View(new StatisticModel()
        {

            Statistics = await GetEntries(user, 100)
        });
    }

    public async Task<List<GetStatisticEntry>> GetEntries(IdentityUser user, int limit)
    {
        var entries = await _ctx.StatsEntries
            // .OrderBy(x => x.Timestamp)
            // .Take(limit)
            //.Where(x => x.UserId == user.Id)
            .Select(x => Tuple.Create(x.Weight, x.Height, BmiHelper.CalculateBMI(x.Weight, ((double)x.Height / 100)), x.Timestamp))
            .Select(x => new GetStatisticEntry(x.Item4, x.Item1, x.Item2, x.Item3, BmiHelper.BmiToText(x.Item3)))
            .ToListAsync();
        return entries;
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Index(PostStatisticEntry body, IdentityUser user)
    {
        var weight = body.Weight;

        // Validate weight input
        if (weight <= MinWeight || weight >= MaxWeight)
        {
            return View(new StatisticModel($"Das angegebene Gewicht muss im Bereich von {MinWeight}kg bis {MaxWeight}kg liegen.")
            {
                Statistics = await GetEntries(user, 100)
            });
        }

        // Check if height is provided or try to use last value
        var height = body.Height ?? await GetLastHeight(user);

        // Check if a height could be determined.
        if (height == null)
        {
            return View(new StatisticModel("Die Größe muss angegeben werden.")
            {
                Statistics = await GetEntries(user, 100)
            });
        }

        // Validate height input
        if (height <= MinHeight || height >= MaxHeight)
        {
            return View(new StatisticModel($"Die angegebene Größe muss im Bereich von {MinHeight}cm bis {MaxHeight}cm liegen.")
            {

                Statistics = await GetEntries(user, 100)
            });
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
        var bmi = BmiHelper.CalculateBMI(weight, ((double)height / 100));

        return View(new StatisticModel()
        {
            Error = $"BMI: {bmi.ToString("#,##")} - {BmiHelper.BmiToText(bmi)}",
            Statistics = await GetEntries(user, 100)
        });
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


    public record GetStatisticEntry(DateTime Time, double Weight, double Height, double Bmi, string Category);
}