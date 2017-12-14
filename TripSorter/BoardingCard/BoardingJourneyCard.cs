using JourneySorterAssembly.Locator;
using JourneySorterAssembly.Transportation;
using System;

/// <summary>
/// 
/// BoardingJourneyCard.cs
/// 
/// Class that represents a generic boarding pass for any type of transport.
/// This class contains attributes and example methods that could be considered
/// common to any boarding card of any type of transport. Dice
/// that the BaordingCard class could contain many attributes, many
/// of which could be other complex objects, such as a vehicle, a
/// airport, a train or bus station, the person who owns the
/// boarding card, etc; you could choose to apply the Builder pattern for
/// build objects of type BoardingJourneyCard, but given that this type of objects
/// they need to be instantiated with parameters specified at the time of
/// execution, I have opted for a provisional solution, to make the
/// methods of this class that modify the values ​​of their attributes, return
/// this, that is, the object that calls the method. In this way, we can
/// chain calls to different Set methods, and avoid having several
/// overloaded builders.    
/// 
/// 
/// Developed By : mostafa.monib@gmail.com mostafa monib
///
/// </summary>
namespace JourneySorterAssembly.JourneyHelper
{

    /// <summary>
    /// Class that represents a generic boarding pass for any type of transport.
    /// This class contains attributes and example methods that could be considered
    /// common to any boarding card of any type of transport. Dice
    /// that the BaordingCard class could contain many attributes, many
    /// of which could be other complex objects, such as a vehicle, a
    /// airport, a train or bus station, the person who owns the
    /// boarding card, etc; you could choose to apply the Builder pattern for
    /// build objects of type BoardingJourneyCard, but given that this type of objects
    /// they need to be instantiated with parameters specified at the time of
    /// execution, I have opted for a provisional solution, to make the
    /// methods of this class that modify the values ​​of their attributes, return
    /// this, that is, the object that calls the method. In this way, we can
    /// chain calls to different Set methods, and avoid having several
    /// overloaded builders.
    /// Developed By : mostafa.monib@gmail.com mostafa monib
    /// </summary>
    public abstract class BoardingJourneyCard
    {

        /// <summary>
        /// The id
        /// </summary>
        private String id;

        /// <summary>
        /// The departure
        /// </summary>
        private Location departure;

        /// <summary>
        /// The destination
        /// </summary>
        private Location destination;

        /// <summary>
        /// The transport
        /// </summary>
        private Transport transport;

        /// <summary>
        /// The seat
        /// Seat number in which the traveler travels. It could be null if the
        /// vehicle does not have seats, or there are no assigned seats
        /// </summary>
        private String seat;

        /// <summary>
        /// The departure date
        /// </summary>
        private DateTime departureDate;

        /// <summary>
        /// The arrival date
        /// </summary>
        private DateTime arrivalDate;

        /// <summary>
        /// The transport company
        /// </summary>
        private TransportProvider transportProvider;

        /// <summary>
        /// The owner
        /// </summary>
        private BoardingJourneyCardOwner owner;

        /// <summary>
        /// The denied
        /// </summary>
        private Boolean denied;

        /// <summary>
        /// The valid
        /// </summary>
        private Boolean valid;

        /// <summary>
        /// Initializes a new instance of the <see cref="BoardingJourneyCard" /> class.
        /// </summary>
        protected BoardingJourneyCard()
        {
            id = "000000";
            transport = null;
            seat = "";
            departureDate = DateTime.Now;
            arrivalDate = DateTime.Now;
            transportProvider = null;
            owner = null;
            denied = false;
            valid = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoardingJourneyCard" /> class.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="seat">The seat.</param>
        /// <param name="departureDate">The departure date.</param>
        /// <param name="arrivalDate">The arrival date.</param>
        /// <param name="client">The client.</param>
        /// <param name="transportProvider">The transport company.</param>
        protected BoardingJourneyCard(String id, String seat, DateTime departureDate, DateTime arrivalDate,
                BoardingJourneyCardOwner client, TransportProvider transportProvider)
        {
            this.id = id;
            this.seat = seat;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
            this.owner = client;
            this.transportProvider = transportProvider;
            denied = false;
            valid = false;
        }

        /// <summary>
        /// Getids this instance.
        /// </summary>
        /// <returns></returns>
        public String Getid()
        {
            return id;
        }

        /// <summary>
        /// Sets the id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public BoardingJourneyCard SetId(String id)
        {
            this.id = id;
            return this;
        }

        /// <summary>
        /// Gets the departure.
        /// </summary>
        /// <returns></returns>
        public Location GetDeparture()
        {
            return departure;
        }

        /// <summary>
        /// Sets the departure.
        /// Allows to modify the departure place that appears on the boarding pass
        /// </summary>
        /// <param name="departure">The departure.</param>
        /// <returns></returns>
        public BoardingJourneyCard SetDeparture(Location departure)
        {
            this.departure = departure;
            return this;
        }

        /// <summary>
        /// Gets the destination.
        /// Allows you to obtain the destination place that appears on the boarding pass
        /// </summary>
        /// <returns></returns>
        public Location GetDestination()
        {
            return destination;
        }

        /// <summary>
        /// Sets the destination.
        /// Allows you to modify the destination place on the boarding pass
        /// </summary>
        /// <param name="destination">The destination.</param>
        /// <returns></returns>
        public BoardingJourneyCard SetDestination(Location destination)
        {
            this.destination = destination;
            return this;
        }

        /// <summary>
        /// Gets the transport company.
        /// Allows obtaining the transport company issuing the card
        /// </summary>
        /// <returns></returns>
        public TransportProvider GetTransportCompany()
        {
            return transportProvider;
        }

        /// <summary>
        /// Sets the transport company.
        /// Allows to modify the transport company issuing the card
        /// </summary>
        /// <param name="transportCompany">The transport company.</param>
        /// <returns></returns>
        public BoardingJourneyCard SetTransportCompany(TransportProvider transportProvider)
        {
            this.transportProvider = transportProvider;
            return this;
        }

        /// <summary>
        /// Gets the transport.
        /// Allows you to obtain the vehicle corresponding to the boarding pass
        /// </summary>
        /// <returns></returns>
        public Transport GetTransport()
        {
            return transport;
        }

        /// <summary>
        /// Sets the transport.
        /// </summary>
        /// <param name="transport">The transport.</param>
        /// <returns></returns>
        public BoardingJourneyCard SetTransport(Transport transport)
        {
            this.transport = transport;
            return this;
        }

        /// <summary>
        /// Gets the seat.
        /// Allows you to obtain the seat number where the traveler will sit. Can
        /// have the value null if there are no assigned seats or if the vehicle does not
        /// has seats
        /// </summary>
        /// <returns></returns>
        public String GetSeat()
        {
            return seat;
        }

        /// <summary>
        /// Sets the seat.
        /// Allows you to modify the seat number where the traveler will sit
        /// </summary>
        /// <param name="seat">The seat.</param>
        /// <returns></returns>
        public BoardingJourneyCard SetSeat(String seat)
        {
            this.seat = seat;
            return this;
        }

        /// <summary>
        /// Gets the departure date.
        /// Allows you to obtain the departure date of the trip
        /// </summary>
        /// <returns></returns>
        public DateTime GetDepartureDate()
        {
            return departureDate;
        }

        /// <summary>
        /// Sets the departure date.
        /// Allow to modify the departure date of the trip
        /// </summary>
        /// <param name="departureDate">The departure date.</param>
        /// <returns></returns>
        public BoardingJourneyCard SetDepartureDate(DateTime departureDate)
        {
            this.departureDate = departureDate;
            return this;
        }

        /// <summary>
        /// Gets the arrival date.
        /// Allows you to obtain the arrival date of the trip
        /// </summary>
        /// <returns></returns>
        public DateTime GetArrivalDate()
        {
            return arrivalDate;
        }

        /// <summary>
        /// Sets the arrival date.
        /// Allows to modify the arrival date of the trip
        /// </summary>
        /// <param name="arrivalDate">The arrival date.</param>
        /// <returns></returns>
        public BoardingJourneyCard SetArrivalDate(DateTime arrivalDate)
        {
            this.arrivalDate = arrivalDate;
            return this;
        }

        /// <summary>
        /// Gets the client.
        /// It allows to obtain the owner of the boarding pass
        /// </summary>
        /// <returns></returns>
        public BoardingJourneyCardOwner GetClient()
        {
            return owner;
        }

        /// <summary>
        /// Sets the client.
        /// Modify the boarding card owner
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns></returns>
        public BoardingJourneyCard SetClient(BoardingJourneyCardOwner client)
        {
            this.owner = client;
            return this;
        }

        /// <summary>
        /// Gets the denied.
        /// Allows you to know if the boarding pass is denied
        /// </summary>
        /// <returns></returns>
        public Boolean GetDenied()
        {
            return denied;
        }

        /// <summary>
        /// Sets the denied.
        /// Deny or not a boarding pass
        /// </summary>
        /// <param name="denied">if Set to <c>true</c> [denied].</param>
        /// <returns></returns>
        public BoardingJourneyCard SetDenied(Boolean denied)
        {
            this.denied = denied;
            return this;
        }

        /// <summary>
        /// Gets the valid.
        /// It lets you know if the boarding pass is valid
        /// </summary>
        /// <returns></returns>
        public Boolean GetValid()
        {
            return valid;
        }

        /// <summary>
        /// Sets the valid.
        /// Allows to validate or invalidate a boarding pass
        /// </summary>
        /// <param name="valid">if Set to <c>true</c> [valid].</param>
        /// <returns></returns>
        public BoardingJourneyCard SetValid(Boolean valid)
        {
            this.valid = valid;
            return this;
        }

        /// <summary>
        /// Mores the infor.
        /// It allows to obtain the information contained in a boarding pass.
        /// Depending on the type of transport, the information displayed will be different.
        /// </summary>
        /// <returns></returns>
        public abstract String GetMoreInformation();

    }
}