using Airport.Models;

AirportContext ctx = new AirportContext();

foreach (var item in ctx.Airports)
{
    Console.WriteLine(item.Name);
}