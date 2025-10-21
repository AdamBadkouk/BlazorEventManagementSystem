using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Registration
{
    public int Id { get; set; }

    public int EventId { get; set; }

    [Required(ErrorMessage = "Full name is required")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone number is required")]
    [Phone(ErrorMessage = "Please enter a valid phone number")]
    [StringLength(20, ErrorMessage = "Phone number cannot exceed 20 characters")]
    public string Phone { get; set; } = string.Empty;

    [Range(1, 10, ErrorMessage = "Number of tickets must be between 1 and 10")]
    public int NumberOfTickets { get; set; } = 1;

    [StringLength(500, ErrorMessage = "Special requirements cannot exceed 500 characters")]
    public string? SpecialRequirements { get; set; }

    public DateTime RegistrationDate { get; set; } = DateTime.Now;
}
