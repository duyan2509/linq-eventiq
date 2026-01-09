using linq_eventiq.Domain;

namespace linq_eventiq.Queries;

public class PaymentQueries
{
    public static Payment? GetPaymentByCheckoutId(List<Payment> payments, Guid checkoutId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payment> GetPaymentsByUserId(List<Payment> payments, Guid userId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payment> GetPaymentsByEventItem(List<Payment> payments, Guid eventItemId)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payment> GetSuccessfulPayments(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payment> GetPendingPayments(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payment> GetFailedPayments(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payment> GetPaymentsByStatus(List<Payment> payments, PaymentStatus status)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<PaymentStatus, int> CountPaymentsByStatus(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payment> GetVerifiedPayments(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payment> GetUnverifiedPayments(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static Payment? GetPaymentByPaymentId(List<Payment> payments, string paymentId)
    {
        throw new NotImplementedException();
    }

    public static Dictionary<Guid, decimal> GetGrossAmountByEventItem(List<Payment> payments)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payment> GetPaymentsByPaidDateRange(
        List<Payment> payments,
        DateTime startDate,
        DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Payment> GetTopPaymentsByAmount(
        List<Payment> payments,
        int topN = 10)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<dynamic> GetPaymentsWithDetails(
        List<Payment> payments,
        List<Checkout> checkouts,
        List<EventItem> eventItems)
    {
        throw new NotImplementedException();
    }
}
