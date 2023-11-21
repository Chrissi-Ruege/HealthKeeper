using System.ComponentModel.DataAnnotations;

namespace HealthKeeper.Models;

public class StatisticsModel{
    [Key]
    public String UserId{get;set;}
    public float currentWeight{get;set;}
    public DateTime currentDate{get;set;}
}