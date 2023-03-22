using System;
using System.Collections.Generic;

namespace Airport.Models;

public partial class Airport
{
    public string IataCode { get; set; } = null!;

    public string? Name { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public virtual ICollection<Flight> FlightDestinationNavigations { get; } = new List<Flight>();

    public virtual ICollection<Flight> FlightOriginNavigations { get; } = new List<Flight>();
}
