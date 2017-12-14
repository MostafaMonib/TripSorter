using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TripSorterClient_Web.Modal
{
    public class TripCard
    {
        public string Id { get; set; }
        public string Gate { get; set; }
        public string FlightNumber { get; set; }
        public string BaggageTicketCounter { get; set; }
        public Location Departure { get; set; }
        public Location Destination { get; set; }
        public string Transport { get; set; }
        public String Seat { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public TransportProvider TransportProvider { get; set; }
        public string TrainNumber { get; set; }
    }
}