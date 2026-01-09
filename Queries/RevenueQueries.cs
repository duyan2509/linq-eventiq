using linq_eventiq.Domain;

namespace linq_eventiq.Queries;

public class RevenueQueries
{
    public static decimal GetTotalRevenue(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static decimal GetTotalPlatformFee(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static decimal GetTotalOrgAmount(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<(int Year, int Month), decimal> GetRevenueByMonth(
        List<Payment> payments,
        int? year = null,
        int? month = null)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, decimal> GetRevenueByEventItem(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<(Guid EventId, decimal Revenue)> GetTopRevenueEvents(
        List<Payment> payments,
        List<EventItem> eventItems,
        int topN = 10)
    {
        throw new NotImplementedException();
    }

    public static int CountSuccessfulPayments(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static decimal GetAveragePaymentAmount(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<dynamic> GetPaymentsByEventItem(
        List<Payment> payments,
        List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<dynamic> GetRevenueByTicketClass(
        List<Payment> payments,
        List<Ticket> tickets,
        List<TicketClass> ticketClasses)
    {
        throw new NotImplementedException();
    }

    public static int GetPendingPayoutsCount(List<Payout> payouts)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<dynamic> GetPayoutsByEvent(
        List<Payout> payouts,
        List<Event> events)
    {
        throw new NotImplementedException();
    }

    public static int GetTotalTicketsSold(List<Ticket> tickets)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, int> GetTicketsSoldByEventItem(List<Ticket> tickets)
    {
        throw new NotImplementedException();
    }

    public static dynamic GetRevenueStatistics(
        List<Payment> payments,
        List<Ticket> tickets,
        List<Payout> payouts)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payment> GetSuccessfulPaymentsByDateRange(
        List<Payment> payments,
        DateTime startDate,
        DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, decimal> GetRevenueByOrganization(
        List<Payment> payments,
        List<EventItem> eventItems,
        List<Event> events)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payment> GetVerifiedPayments(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, int> GetTicketsSoldByTicketClass(List<Ticket> tickets)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<PayoutStatus, int> GetPayoutStatusSummary(List<Payout> payouts)
    {
        throw new NotImplementedException();
    }
}
