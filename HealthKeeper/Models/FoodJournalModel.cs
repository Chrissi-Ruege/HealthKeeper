using System.ComponentModel.DataAnnotations;

namespace HealthKeeper.Models;

public class FoodJournalModel
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }
    public float KaloriePer100Gramm { get; set; }

    public float FatPer100Gramm { get; set; }

    public float ProteinPer100Gramm { get; set; }

    public float SugarPer100Gramm { get; set; }

    public float CarbsPer100Gramm { get; set; }



}