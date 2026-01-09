namespace linq_eventiq.Domain;

public class Chart:BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Key {get; set;} = string.Empty;
    public string? VenueDefinition { get; set; } // JSON string chứa cấu hình seat map từ Seats.io
    
    public virtual Event? Event { get; set; }
    public Guid EventId { get; set; }
    
    public virtual IEnumerable<EventSeat> EventSeats { get; set; } = new List<EventSeat>();
    public virtual IEnumerable<EventItem> EventItems { get; set; } = new List<EventItem>();
}
