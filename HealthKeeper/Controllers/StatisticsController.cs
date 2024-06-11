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
        var height = body.Height ?? await GetLastHeight(user);

        // Validate height input
        var validator = StatisticValidator.Validate(weight, height);
     
        if (validator.Item1)
        {
            return View(new StatisticModel(validator.Item2)
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