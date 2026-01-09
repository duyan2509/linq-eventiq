using linq_eventiq.Domain;

namespace linq_eventiq.Queries;

public class PayoutQueries
{
    public static Payout? GetPayoutByEventItem(List<Payout> payouts, Guid eventItemId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payout> GetPayoutsByEvent(List<Payout> payouts, Guid eventId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payout> GetPayoutsByOrganization(List<Payout> payouts, Guid organizationId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payout> GetPendingPayouts(List<Payout> payouts)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payout> GetPaidPayouts(List<Payout> payouts)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payout> GetPayoutsByStatus(List<Payout> payouts, PayoutStatus status)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<PayoutStatus, int> CountPayoutsByStatus(List<Payout> payouts)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, decimal> GetGrossRevenueByOrganization(List<Payout> payouts)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, decimal> GetOrgAmountByOrganization(List<Payout> payouts)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payout> GetPayoutsByPaidDateRange(
        List<Payout> payouts,
        DateTime? startDate,
        DateTime? endDate)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<dynamic> GetPayoutsWithDetails(
        List<Payout> payouts,
        List<Event> events,
        List<Organization> organizations)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payout> GetTopPayoutsByRevenue(
        List<Payout> payouts,
        int topN = 10)
    {
        throw new NotImplementedException();
    }

    public static decimal GetTotalPendingPayoutAmount(List<Payout> payouts)
    {
        throw new NotImplementedException();
    }
}
