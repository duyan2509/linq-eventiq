using linq_eventiq.Domain;

namespace linq_eventiq.Queries;

public class EventQueries
{
    public static IEnumerable<Event> GetPublishedEvents(List<Event> events)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> GetEventsByOrganization(List<Event> events, Guid organizationId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> GetEventsByStatus(List<Event> events, EventStatus status)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> GetUpcomingEvents(List<Event> events, List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> GetPastEvents(List<Event> events, List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> GetEventsWithItems(List<Event> events, List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> SearchEventsByName(List<Event> events, string searchTerm)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> GetEventsByProvince(List<Event> events, string provinceName)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, int> CountEventsByOrganization(List<Event> events)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> GetEventsByDateRange(List<Event> events, DateTime startDate, DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> GetEventsWithApprovalHistory(
        List<Event> events, 
        List<EventApprovalHistory> approvalHistories)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<(Event Event, DateTime EarliestStart)> GetEventsWithEarliestStart(
        List<Event> events,
        List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> GetEventsWithTicketClasses(
        List<Event> events,
        List<TicketClass> ticketClasses)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> GetSubmittedEvents(
        List<Event> events,
        List<EventApprovalHistory> approvalHistories)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> GetEventsByOrganizationAndStatus(
        List<Event> events, 
        Guid organizationId, 
        EventStatus status)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> GetEventsWithPaymentInfo(List<Event> events)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Event> GetEventsWithCharts(
        List<Event> events,
        List<Chart> charts)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, EventApprovalHistory> GetLatestApprovalHistory(
        List<EventApprovalHistory> approvalHistories)
    {
        throw new NotImplementedException();
    }
}
