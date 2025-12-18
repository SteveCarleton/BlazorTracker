using System.ComponentModel.DataAnnotations;

namespace BlazorTracker.Models;

public class TrackerItem
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;

    public bool IsComplete { get; set; } = default!;
}
