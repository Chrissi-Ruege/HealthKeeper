namespace HealthKeeper.Models.Views;

public class RegisterForm
{

    public required string Username { get; set; }
    public required string Email { get; set; }

    public required string Password { get; set; }
    public required string PasswordConfirm { get; set; }
}

