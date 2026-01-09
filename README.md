# LINQ Practice - EventIQ

Project để luyện tập LINQ queries với domain model của EventIQ.

## Cấu trúc Project

```
linq-eventiq/
├── Domain/              # Domain entities
│   ├── BaseEntity.cs
│   ├── Event.cs
│   ├── EventItem.cs
│   ├── Ticket.cs
│   ├── Payment.cs
│   └── ...
├── Data/                # Data generation
│   └── SampleDataGenerator.cs
├── Queries/             # LINQ queries 
│   ├── EventQueries.cs
│   ├── RevenueQueries.cs
│   ├── TicketQueries.cs
│   ├── PaymentQueries.cs
│   ├── PayoutQueries.cs
│   ├── EventItemQueries.cs
│   └── SeatQueries.cs
└── Program.cs           # Entry point
```

## Cách sử dụng

1. Build project:
   ```bash
   dotnet build
   ```

2. Chạy project:
   ```bash
   dotnet run
   ```

## Sample Data

Project tự động generate sample data với:
- 5 Organizations
- 15 Events (3 mỗi org)
- Nhiều EventItems, Tickets, Payments, Charts, Seats...


