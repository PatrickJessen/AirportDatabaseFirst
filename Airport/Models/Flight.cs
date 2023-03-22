using System;
using System.Collections.Generic;

namespace Airport.Models;

public partial class Flight
{
    public int Id { get; set; }

    public int? AirlineId { get; set; }

    public string? Origin { get; set; }

    public string? Destination { get; set; }

    public DateTime? DepartureTime { get; set; }

    public DateTime? ArrivalTime { get; set; }

    public virtual Airline? Airline { get; set; }

    public virtual Airport? DestinationNavigation { get; set; }

    public virtual Airport? OriginNavigation { get; set; }
}
