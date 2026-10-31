using System.Globalization; 

var ac1 = new AcStation("AC1");
var ac2 = new AcStation("AC2");
var dc1 = new DcStation("DC1");

var sessions = new List<(ChargingStation station, decimal kwh)>

{
(ac1, Reports.ParseKwh("20")),
(dc1, Reports.ParseKwh("20")),
(ac2, Reports.ParseKwh("12")),
(dc1, Reports.ParseKwh("40"))
};
decimal total = 0m;
foreach (var session in sessions)
{
   total += session.station.CalculatePrice(session.kwh);
}
Console.WriteLine($"Dagens intäkter: {total:F2} kr");