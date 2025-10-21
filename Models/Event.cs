using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Event
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Event name is required")]
    [StringLength(100, ErrorMessage = "Event name cannot exceed 100 characters")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Description is required")]
    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Date is required")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Location is required")]
    [StringLength(200, ErrorMessage = "Location cannot exceed 200 characters")]
    public string Location { get; set; } = string.Empty;

    [Required]
    [Range(1, 10000, ErrorMessage = "Max attendees must be between 1 and 10000")]
    public int MaxAttendees { get; set; }

    public int CurrentAttendees { get; set; }

    public string Category { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public List<Registration> Registrations { get; set; } = new();

    public int AvailableSpots => MaxAttendees - CurrentAttendees;

    public double AttendancePercentage => MaxAttendees > 0 ? (double)CurrentAttendees / MaxAttendees * 100 : 0;

    public bool IsFull => CurrentAttendees >= MaxAttendees;
}
