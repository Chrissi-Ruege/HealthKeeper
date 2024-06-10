namespace HealthKeeper.Models.Views;

public class ErrorViewModel
{
    public string? Error { get; set; }

    public bool ShowError => !string.IsNullOrEmpty(Error);

    public ErrorViewModel() { }
    public ErrorViewModel(string error) { Error = error; }
}