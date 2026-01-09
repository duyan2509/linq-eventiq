using linq_eventiq.Domain;

namespace linq_eventiq.Queries;

public class TicketQueries
{
    public static IEnumerable<Ticket> GetTicketsByUserId(List<Ticket> tickets, string userId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Ticket> GetTicketsByEventItem(List<Ticket> tickets, Guid eventItemId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Ticket> GetTicketsByTicketClass(List<Ticket> tickets, Guid ticketClassId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Ticket> GetUsedTickets(List<Ticket> tickets)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Ticket> GetUnusedTickets(List<Ticket> tickets)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, int> CountTicketsByEventItem(List<Ticket> tickets)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, int> CountTicketsByTicketClass(List<Ticket> tickets)
    {
        throw new NotImplementedException();
    }

    public static Ticket? FindTicketByCode(List<Ticket> tickets, string ticketCode)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<dynamic> GetTicketsWithDetails(
        List<Ticket> tickets,
        List<EventItem> eventItems,
        List<TicketClass> ticketClasses)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<dynamic> GetUserTicketsWithEventInfo(
        List<Ticket> tickets,
        List<EventItem> eventItems,
        List<Event> events,
        string userId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Ticket> GetUpcomingTickets(
        List<Ticket> tickets,
        List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Ticket> GetExpiredTickets(
        List<Ticket> tickets,
        List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static int GetTotalTicketsSoldForEvent(
        List<Ticket> tickets,
        List<EventItem> eventItems,
        Guid eventId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Ticket> GetTicketsByPurchaseDateRange(
        List<Ticket> tickets,
        DateTime startDate,
        DateTime endDate)
    {
        throw new NotImplementedException();
    }
}
