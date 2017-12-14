using JourneySorterAssembly.Locator;
using System;
using System.Collections.Generic;

namespace JourneySorterAssembly.Transportation
{

    /// <summary>
    /// This abstract class represents the manufacturer of a vehicle.
         /// Contains attributes and methods by way of example.
    /// Developed By : mostafa.monib@gmail.com mostafa monib
    /// </summary>
    public abstract class Maker
    {

        /// <summary>
        /// The name
        /// </summary>
        private String name;

        /// <summary>
        /// The headquarters
        /// </summary>
        private Location headquarters;

        /// <summary>
        /// Initializes a new instance of the <see cref="Maker"/> class.
        /// </summary>
        protected Maker()
        {
            name = "";
            headquarters = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Maker"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="headquarters">The headquarters.</param>
        protected Maker(String name, Location headquarters)
        {
            this.name = name;
            this.headquarters = headquarters;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public String GetName()
        {
            return name;
        }

        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="name">The name.</param>
        public void SetName(String name)
        {
            this.name = name;
        }

        /// <summary>
        /// Gets the headquarters.
        /// </summary>
        /// <returns></returns>
        public Location GetHeadquarters()
        {
            return headquarters;
        }

        /// <summary>
        /// Sets the headquarters.
        /// </summary>
        /// <param name="headquarters">The headquarters.</param>
        public void SetHeadquarters(Location headquarters)
        {
            this.headquarters = headquarters;
        }

        /// <summary>
        /// Gets the vehicles by year.
        /// It allows to obtain the vehicles that this manufacturer manufactured during the year indicated by the parameter
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>List<Transport></returns>
        public abstract List<Transport> GetVehiclesByYear(int year);

    }
}