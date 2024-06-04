using System.ComponentModel.DataAnnotations;

namespace HealthKeeper.Models;

public class UserUpdateModel
{
    [Key]
    [Required]
    [EmailAddress(ErrorMessage = "Gültige EMail-Adresse wird erwartet.")]
    [Display(Name = "Email-Adresse")]
    public string? Mail { get; set; }

    [StringLength(50, ErrorMessage = "Der {0} muss mindestens {2} und darf maximal {1} Zeichen enthalten", MinimumLength = 4)]
    [Display(Name = "Benutzername")]
    public string? Username { get; set; }


    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Altes Passwort")]
    public string? OldPassword { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Das {0} muss mindestens {2} und darf maximal {1} Zeichen enthalten.", MinimumLength = 4)]
    [DataType(DataType.Password)]
    [Display(Name = "Neue Passwort")]
    public string? NewPassword { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Neues Passwort wiederholen")]
    [Compare("Password", ErrorMessage = "Die Passwörter stimmen nicht überein.")]
    public string? ConfirmNewPassword { get; set; }
}