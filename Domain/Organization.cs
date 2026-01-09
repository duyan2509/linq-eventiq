using System.ComponentModel.DataAnnotations;

namespace linq_eventiq.Domain;

public sealed class Organization: BaseEntity
{
    public string UserId { get; set; } = string.Empty;
    
    [StringLength(maximumLength:30, MinimumLength = 2)]
    public required string Name { get; set; }
    
    public required string Avatar { get; set; }
    
    public List<Event> Events { get; set; } = new List<Event>();
}
