using System;
using System.Collections.Generic;

namespace Airport.Models;

public partial class Airline
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Flight> Flights { get; } = new List<Flight>();
}
