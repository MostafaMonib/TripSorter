using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TripSorterClient_Web.Modal
{
    public class Transport
    {
        public TransportProvider TransportCompany { get; set; }
        public int Capacity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime InUseDate { get; set; }
    }
}