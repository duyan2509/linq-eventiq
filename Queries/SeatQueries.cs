using linq_eventiq.Domain;

namespace linq_eventiq.Queries;

public class SeatQueries
{
    public static IEnumerable<EventSeat> GetSeatsByChart(List<EventSeat> seats, Guid chartId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventSeat> GetSeatsBySection(List<EventSeat> seats, string section)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventSeat> GetSeatsByCategoryKey(List<EventSeat> seats, string categoryKey)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventSeatState> GetSeatStatesByEventItem(
        List<EventSeatState> seatStates, 
        Guid eventItemId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventSeat> GetFreeSeatsForEventItem(
        List<EventSeat> seats,
        List<EventSeatState> seatStates,
        Guid eventItemId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventSeat> GetPaidSeatsForEventItem(
        List<EventSeat> seats,
        List<EventSeatState> seatStates,
        Guid eventItemId)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, int> CountSeatsByChart(List<EventSeat> seats)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<string, int> CountSeatsBySection(List<EventSeat> seats)
    {
        throw new NotImplementedException();
    }

    public static (int Free, int Paid) CountFreeAndPaidSeats(
        List<EventSeatState> seatStates,
        Guid eventItemId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventSeatState> GetSeatStatesWithTicket(List<EventSeatState> seatStates)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<EventSeat> SearchSeatsByLabel(List<EventSeat> seats, string searchTerm)
    {
        throw new NotImplementedException();
    }
}
