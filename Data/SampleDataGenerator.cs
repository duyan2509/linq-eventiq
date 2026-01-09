using linq_eventiq.Domain;

namespace linq_eventiq.Data;

public class SampleDataGenerator
{
    private static Random _random = new Random();

    public static (List<Organization>, List<Event>, List<EventItem>, List<TicketClass>, 
                   List<Ticket>, List<Payment>, List<Chart>, List<EventSeat>, 
                   List<EventSeatState>, List<Checkout>, List<Payout>) GenerateSampleData()
    {
        // Tạo Organizations
        var organizations = new List<Organization>();
        for (int i = 0; i < 5; i++)
        {
            organizations.Add(new Organization
            {
                Id = Guid.NewGuid(),
                UserId = $"user-{i}",
                Name = $"Organization {i + 1}",
                Avatar = $"avatar-{i + 1}.jpg",
                CreatedAt = DateTime.UtcNow.AddDays(-_random.Next(100, 200))
            });
        }

        // Tạo Events
        var events = new List<Event>();
        foreach (var org in organizations)
        {
            for (int i = 0; i < 3; i++)
            {
                var eventStatus = (EventStatus)_random.Next(0, 6);
                events.Add(new Event
                {
                    Id = Guid.NewGuid(),
                    Name = $"Event {i + 1} - {org.Name}",
                    Banner = $"banner-{org.Id}-{i}.jpg",
                    Description = $"Description for Event {i + 1}",
                    Start = DateTime.UtcNow.AddDays(_random.Next(-30, 60)),
                    OrganizationId = org.Id,
                    Organization = org,
                    Status = eventStatus,
                    BankCode = "VNBANK",
                    AccountNumber = $"123456789{i}",
                    AccountName = org.Name,
                    CreatedAt = DateTime.UtcNow.AddDays(-_random.Next(50, 150))
                });
            }
        }

        // Tạo EventAddresses
        var provinces = new[] { "Hà Nội", "TP.HCM", "Đà Nẵng", "Hải Phòng", "Cần Thơ" };
        foreach (var evt in events)
        {
            var province = provinces[_random.Next(provinces.Length)];
            evt.EventAddress = new EventAddress
            {
                Id = Guid.NewGuid(),
                EventId = evt.Id,
                Event = evt,
                ProvinceCode = $"P{_random.Next(1, 100)}",
                CommuneCode = $"C{_random.Next(1, 100)}",
                ProvinceName = province,
                CommuneName = $"Commune {_random.Next(1, 20)}",
                Detail = $"Street {_random.Next(1, 200)}",
                CreatedAt = evt.CreatedAt
            };
        }

        // Tạo Charts
        var charts = new List<Chart>();
        foreach (var evt in events)
        {
            for (int i = 0; i < 2; i++)
            {
                charts.Add(new Chart
                {
                    Id = Guid.NewGuid(),
                    EventId = evt.Id,
                    Event = evt,
                    Name = $"Chart {i + 1}",
                    Key = $"chart-key-{evt.Id}-{i}",
                    CreatedAt = evt.CreatedAt.AddDays(_random.Next(1, 10))
                });
            }
        }

        // Tạo EventSeats
        var eventSeats = new List<EventSeat>();
        var sections = new[] { "A", "B", "C", "VIP" };
        foreach (var chart in charts)
        {
            for (int row = 1; row <= 10; row++)
            {
                for (int seatNum = 1; seatNum <= 20; seatNum++)
                {
                    var section = sections[_random.Next(sections.Length)];
                    eventSeats.Add(new EventSeat
                    {
                        Id = Guid.NewGuid(),
                        ChartId = chart.Id,
                        Chart = chart,
                        Label = $"{section}-{row}-{seatNum}",
                        Section = section,
                        Row = row.ToString(),
                        Number = seatNum.ToString(),
                        CategoryKey = section == "VIP" ? "VIP" : section,
                        CreatedAt = chart.CreatedAt
                    });
                }
            }
        }

        // Tạo EventItems
        var eventItems = new List<EventItem>();
        foreach (var evt in events)
        {
            var chart = charts.FirstOrDefault(c => c.EventId == evt.Id);
            if (chart != null)
            {
                for (int i = 0; i < 2; i++)
                {
                    var start = evt.Start.AddHours(i * 3);
                    eventItems.Add(new EventItem
                    {
                        Id = Guid.NewGuid(),
                        EventId = evt.Id,
                        Event = evt,
                        ChartId = chart.Id,
                        Chart = chart,
                        Name = $"{evt.Name} - Session {i + 1}",
                        Description = $"Session {i + 1} description",
                        Start = start,
                        End = start.AddHours(2),
                        MaxPerUser = 5,
                        EventKey = $"event-key-{evt.Id}-{i}",
                        CreatedAt = evt.CreatedAt.AddDays(_random.Next(1, 20))
                    });
                }
            }
        }

        // Tạo EventSeatStates
        var eventSeatStates = new List<EventSeatState>();
        foreach (var eventItem in eventItems)
        {
            var seatsForChart = eventSeats.Where(s => s.ChartId == eventItem.ChartId).ToList();
            foreach (var seat in seatsForChart.Take(_random.Next(10, seatsForChart.Count / 2)))
            {
                eventSeatStates.Add(new EventSeatState
                {
                    Id = Guid.NewGuid(),
                    EventItemId = eventItem.Id,
                    EventItem = eventItem,
                    EventSeatId = seat.Id,
                    EventSeat = seat,
                    Status = _random.Next(0, 2) == 1 ? SeatStatus.Paid : SeatStatus.Free,
                    UpdatedAt = DateTime.UtcNow.AddDays(-_random.Next(1, 30))
                });
            }
        }

        // Tạo TicketClasses
        var ticketClasses = new List<TicketClass>();
        var ticketClassNames = new[] { "Standard", "VIP", "Premium", "Economy" };
        var ticketClassPrices = new[] { 100000m, 500000m, 300000m, 50000m };
        var colors = new[] { "#FF5733", "#33FF57", "#3357FF", "#FF33F5" };

        foreach (var evt in events)
        {
            for (int i = 0; i < 3; i++)
            {
                var index = _random.Next(ticketClassNames.Length);
                ticketClasses.Add(new TicketClass
                {
                    Id = Guid.NewGuid(),
                    EventId = evt.Id,
                    Event = evt,
                    Name = ticketClassNames[index],
                    Price = ticketClassPrices[index],
                    Color = colors[index],
                    TotalQuantity = 200,
                    SoldQuantity = _random.Next(0, 100),
                    CreatedAt = evt.CreatedAt.AddDays(_random.Next(1, 15))
                });
            }
        }

        // Tạo Tickets
        var tickets = new List<Ticket>();
        var userIds = Enumerable.Range(1, 50).Select(i => $"user-{i}").ToList();

        foreach (var eventItem in eventItems)
        {
            var eventTicketClasses = ticketClasses.Where(tc => tc.EventId == eventItem.EventId).ToList();
            if (eventTicketClasses.Any())
            {
                for (int i = 0; i < _random.Next(10, 50); i++)
                {
                    var ticketClass = eventTicketClasses[_random.Next(eventTicketClasses.Count)];
                    tickets.Add(new Ticket
                    {
                        Id = Guid.NewGuid(),
                        EventItemId = eventItem.Id,
                        EventItem = eventItem,
                        TicketClassId = ticketClass.Id,
                        TicketClass = ticketClass,
                        UserId = userIds[_random.Next(userIds.Count)],
                        TicketCode = GenerateTicketCode(),
                        Status = _random.Next(0, 2) == 1 ? TicketStatus.USED : TicketStatus.UNUSED,
                        CreatedAt = eventItem.Start.AddDays(-_random.Next(1, 30))
                    });
                }
            }
        }

        // Link tickets to seat states
        foreach (var ticket in tickets)
        {
            var seatState = eventSeatStates
                .FirstOrDefault(s => s.EventItemId == ticket.EventItemId && s.TicketId == null);
            if (seatState != null && _random.Next(0, 2) == 1)
            {
                seatState.TicketId = ticket.Id;
                seatState.Ticket = ticket;
                seatState.Status = SeatStatus.Paid;
            }
        }

        // Tạo Checkouts
        var checkouts = new List<Checkout>();
        foreach (var eventItem in eventItems)
        {
            for (int i = 0; i < _random.Next(5, 20); i++)
            {
                var seatIds = eventSeats
                    .Where(s => s.ChartId == eventItem.ChartId)
                    .OrderBy(x => _random.Next())
                    .Take(_random.Next(1, 5))
                    .Select(s => s.Label)
                    .ToList();

                checkouts.Add(new Checkout
                {
                    Id = Guid.NewGuid(),
                    UserId = Guid.NewGuid(),
                    EventItemId = eventItem.Id,
                    EventItem = eventItem,
                    Status = _random.Next(0, 3) switch
                    {
                        0 => "INIT",
                        1 => "SUCCESS",
                        _ => "CANCELED"
                    },
                    CreatedAt = eventItem.Start.AddDays(-_random.Next(1, 40))
                });
                checkouts.Last().SetSeatIds(seatIds);
            }
        }

        // Tạo Payments
        var payments = new List<Payment>();
        foreach (var checkout in checkouts.Where(c => c.Status == "SUCCESS"))
        {
            var eventItem = eventItems.First(ei => ei.Id == checkout.EventItemId);
            var ticketClass = ticketClasses.FirstOrDefault(tc => tc.EventId == eventItem.EventId);
            
            if (ticketClass != null)
            {
                var seatCount = checkout.GetSeatIds().Count;
                var grossAmount = ticketClass.Price * seatCount;
                var platformFee = grossAmount * 0.20m;
                var orgAmount = grossAmount * 0.80m;

                payments.Add(new Payment
                {
                    Id = Guid.NewGuid(),
                    CheckoutId = checkout.Id,
                    Checkout = checkout,
                    UserId = checkout.UserId,
                    EventItemId = checkout.EventItemId,
                    EventItem = eventItem,
                    PaymentId = $"EVT{checkout.Id.ToString("N").Substring(0, 12)}{DateTime.UtcNow:yyyyMMddHHmmss}",
                    GrossAmount = grossAmount,
                    PlatformFee = platformFee,
                    OrgAmount = orgAmount,
                    Status = _random.Next(0, 4) switch
                    {
                        0 => PaymentStatus.PENDING,
                        1 => PaymentStatus.SUCCESS,
                        2 => PaymentStatus.FAILED,
                        _ => PaymentStatus.CANCELLED
                    },
                    PaidAt = _random.Next(0, 2) == 1 ? checkout.CreatedAt.AddHours(_random.Next(1, 48)) : null,
                    BankCode = "VNBANK",
                    IsVerified = _random.Next(0, 2) == 1,
                    VerifiedAt = _random.Next(0, 2) == 1 ? checkout.CreatedAt.AddHours(_random.Next(1, 48)) : null,
                    CreatedAt = checkout.CreatedAt
                });

                checkout.Payment = payments.Last();
            }
        }

        // Tạo Payouts
        var payouts = new List<Payout>();
        var groupedPayments = payments
            .Where(p => p.Status == PaymentStatus.SUCCESS)
            .GroupBy(p => p.EventItemId);

        foreach (var group in groupedPayments)
        {
            var eventItem = eventItems.First(ei => ei.Id == group.Key);
            var evt = events.First(e => e.Id == eventItem.EventId);
            var org = organizations.First(o => o.Id == evt.OrganizationId);

            payouts.Add(new Payout
            {
                Id = Guid.NewGuid(),
                EventId = evt.Id,
                Event = evt,
                EventItemId = eventItem.Id,
                EventItem = eventItem,
                OrganizationId = org.Id,
                Organization = org,
                GrossRevenue = group.Sum(p => p.GrossAmount),
                PlatformFee = group.Sum(p => p.PlatformFee),
                OrgAmount = group.Sum(p => p.OrgAmount),
                Status = _random.Next(0, 2) == 1 ? PayoutStatus.PENDING : PayoutStatus.PAID,
                PaidAt = _random.Next(0, 2) == 1 ? DateTime.UtcNow.AddDays(-_random.Next(1, 30)) : null,
                CreatedAt = eventItem.Start.AddDays(-_random.Next(1, 20))
            });
        }

        return (organizations, events, eventItems, ticketClasses, tickets, payments, 
                charts, eventSeats, eventSeatStates, checkouts, payouts);
    }

    private static string GenerateTicketCode()
    {
        return Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
    }
}
