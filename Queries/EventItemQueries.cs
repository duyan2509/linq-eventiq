using linq_eventiq.Domain;

namespace linq_eventiq.Queries;

public class EventItemQueries
{
    public static IEnumerable<EventItem> GetEventItemsByEvent(List<EventItem> eventItems, Guid eventId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventItem> GetEventItemsByChart(List<EventItem> eventItems, Guid chartId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventItem> GetUpcomingEventItems(List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventItem> GetPastEventItems(List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventItem> GetOngoingEventItems(List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventItem> GetEventItemsByDateRange(
        List<EventItem> eventItems,
        DateTime startDate,
        DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<(EventItem Item1, EventItem Item2)> FindOverlappingEventItems(
        List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, int> CountEventItemsByEvent(List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, DateTime> GetEarliestStartByEvent(List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, DateTime> GetLatestEndByEvent(List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventItem> GetEventItemsWithEventKey(List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventItem> GetEventItemsWithoutEventKey(List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }
}
