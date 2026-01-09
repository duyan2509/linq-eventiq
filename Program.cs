using linq_eventiq.Data;
using linq_eventiq.Domain;
using linq_eventiq.Queries;

namespace linq_eventiq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== LINQ Practice - EventIQ ===\n");

        // Generate sample data
        Console.WriteLine("Generating sample data...");
        var (organizations, events, eventItems, ticketClasses, tickets, payments, 
             charts, eventSeats, eventSeatStates, checkouts, payouts) = SampleDataGenerator.GenerateSampleData();

        Console.WriteLine($"Generated {organizations.Count} organizations");
        Console.WriteLine($"Generated {events.Count} events");
        Console.WriteLine($"Generated {eventItems.Count} event items");
        Console.WriteLine($"Generated {ticketClasses.Count} ticket classes");
        Console.WriteLine($"Generated {tickets.Count} tickets");
        Console.WriteLine($"Generated {payments.Count} payments");
        Console.WriteLine($"Generated {charts.Count} charts");
        Console.WriteLine($"Generated {eventSeats.Count} event seats");
        Console.WriteLine($"Generated {eventSeatStates.Count} seat states");
        Console.WriteLine($"Generated {checkouts.Count} checkouts");
        Console.WriteLine($"Generated {payouts.Count} payouts\n");

        Console.WriteLine("=== Sample Data Ready ===\n");
        Console.WriteLine("You can now practice implementing LINQ queries in the Queries folder.\n");
        Console.WriteLine("Example queries to implement:");
        Console.WriteLine("1. EventQueries.GetPublishedEvents()");
        Console.WriteLine("2. RevenueQueries.GetTotalRevenue()");
        Console.WriteLine("3. TicketQueries.GetTicketsByUserId()");
        Console.WriteLine("... and many more!\n");

        // Example: Test one query (uncomment when implemented)
        // try
        // {
        //     var publishedEvents = EventQueries.GetPublishedEvents(events);
        //     Console.WriteLine($"Found {publishedEvents.Count()} published events");
        // }
        // catch (NotImplementedException)
        // {
        //     Console.WriteLine("Query not implemented yet. Please implement it first!");
        // }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
