using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs;

/// <summary>
/// Represents the object structure and format required from the client for creating topic.
/// </summary>
public class CreateTopicDto
{
    [Required]
    [StringLength(30, MinimumLength = 2)]
    [RegularExpression("^[a-zA-Z0-9_.-]+$", ErrorMessage = "Name cannot contain spaces or special characters.")]
    public required string Name { get; set; }

    [Required]
    public required string Description { get; set; }
}