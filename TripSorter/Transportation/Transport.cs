using System;
using System.Text;

namespace JourneySorterAssembly.Transportation
{

    /// <summary>
    /// This abstract class represents a physical vehicle of a certain type of means of transport, plane, train, bus, etc.
    /// This class shows only some examples of attributes and methods as a test.
    /// Developed By : mostafa.monib@gmail.com mostafa monib
    /// </summary>
    public abstract class Transport
    {

        /// <summary>
        /// The transport company
        /// </summary>
        private TransportProvider transportCompany;

        /// <summary>
        /// The capacity
        /// </summary>
        private int capacity;

        /// <summary>
        /// The maker
        /// </summary>
        private Maker maker;

        /// <summary>
        /// The purchase date
        /// </summary>
        private DateTime purchaseDate;

        /// <summary>
        /// The in use date
        /// </summary>
        private DateTime inUseDate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Transport" /> class.
        /// </summary>
        public Transport()
        {
            transportCompany = null;
            capacity = 0;
            maker = null;
            purchaseDate = DateTime.Now;
            inUseDate = DateTime.Now;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transport" /> class.
        /// </summary>
        /// <param name="transportCompany">The transport company.</param>
        /// <param name="capacity">The capacity.</param>
        /// <param name="maker">The maker.</param>
        /// <param name="purchaseDate">The purchase date.</param>
        /// <param name="inUseDate">The in use date.</param>
        public Transport(TransportProvider transportCompany, int capacity, Maker maker, DateTime purchaseDate,
                DateTime inUseDate)
        {
            this.transportCompany = transportCompany;
            this.capacity = capacity;
            this.maker = maker;
            this.purchaseDate = purchaseDate;
            this.inUseDate = inUseDate;
        }

        /// <summary>
        /// Gets the transport company.
        /// </summary>
        /// <returns></returns>
        public TransportProvider GetTransportCompany()
        {
            return transportCompany;
        }

        /// <summary>
        /// Sets the transport company.
        /// </summary>
        /// <param name="transportCompany">The transport company.</param>
        public void SetTransportCompany(TransportProvider transportCompany)
        {
            this.transportCompany = transportCompany;
        }

        /// <summary>
        /// Gets the capacity.
        /// </summary>
        /// <returns></returns>
        public int GetCapacity()
        {
            return capacity;
        }

        /// <summary>
        /// Sets the capacity.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        public void SetCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        /// <summary>
        /// Gets the maker.
        /// </summary>
        /// <returns></returns>
        public Maker GetMaker()
        {
            return maker;
        }

        /// <summary>
        /// Sets the maker.
        /// </summary>
        /// <param name="maker">The maker.</param>
        public void SetMaker(Maker maker)
        {
            this.maker = maker;
        }

        /// <summary>
        /// Gets the purchase date.
        /// </summary>
        /// <returns></returns>
        public DateTime GetPurchaseDate()
        {
            return purchaseDate;
        }

        /// <summary>
        /// Sets the purchase date.
        /// </summary>
        /// <param name="purchaseDate">The purchase date.</param>
        public void SetPurchaseDate(DateTime purchaseDate)
        {
            this.purchaseDate = purchaseDate;
        }

        /// <summary>
        /// Gets the in use date.
        /// </summary>
        /// <returns></returns>
        public DateTime GetInUseDate()
        {
            return inUseDate;
        }

        /// <summary>
        /// Sets the in use date.
        /// </summary>
        /// <param name="inUseDate">The in use date.</param>
        public void SetInUseDate(DateTime inUseDate)
        {
            this.inUseDate = inUseDate;
        }

        /// <summary>
        /// Determines whether [is out of order].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is out of order]; otherwise, <c>false</c>.
        /// </returns>
        public abstract Boolean IsOutOfOrder();

        /// <summary>
        /// Dates the off road.
        /// </summary>
        /// <returns></returns>
        public abstract DateTime DateOffRoad();

        /// <summary>
        /// Gets the type vehicle.
        /// </summary>
        /// <returns>String</returns>
        public abstract String GetTypeVehicle();

        /// <summary>
        /// Gets the more information.
        /// </summary>
        /// <returns>String</returns>
        public String GetMoreInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Type of vehicle: ").Append(GetTypeVehicle()).Append("\nTransport Provider: ")
                .Append(GetTransportCompany().GetCompanyName());
            return sb.ToString();
        }

    }
}