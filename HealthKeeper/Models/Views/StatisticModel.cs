using HealthKeeper.Models.Database;
using static HealthKeeper.Controllers.StatisticsController;

namespace HealthKeeper.Models.Views
{
    public class StatisticModel : ErrorViewModel
    {

        public List<GetStatisticEntry> Statistics { get; set; }

        public StatisticModel() { }
        public StatisticModel(string error) { Error = error; }
    }
}
