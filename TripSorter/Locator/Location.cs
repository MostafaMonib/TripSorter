using System;
using System.Collections.Generic;

namespace JourneySorterAssembly.Locator
{
    //Developed By : mostafa.monib@gmail.com mostafa monib

    /// <summary>
    /// This class represents a geographical location corresponding to a locality
    /// </summary>
    public class Location
    {

        /// <summary>
        /// The id
        /// </summary>
        private String id;

        /// <summary>
        /// The city
        /// </summary>
        private String city;

        /// <summary>
        /// The country
        /// </summary>
        private String country;

        /// <summary>
        /// The longitude
        /// </summary>
        private double longitude;

        /// <summary>
        /// The latitude
        /// </summary>
        private double latitude;

        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        public Location()
        {
            id = "000000";
            city = "";
            country = "";
            longitude = 0.0;
            latitude = 0.0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="city">The city.</param>
        /// <param name="country">The country.</param>
        public Location(String id, String city, String country)
        {
            this.id = id;
            this.city = city;
            this.country = country;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="city">The city.</param>
        /// <param name="country">The country.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="latitude">The latitude.</param>
        public Location(String id, String city, String country, double longitude, double latitude)
        {
            this.id = id;
            this.city = city;
            this.country = country;
            this.longitude = longitude;
            this.latitude = latitude;
        }

        /// <summary>
        /// Gets the id.
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
        public void Setid(String id)
        {
            this.id = id;
        }

        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <returns></returns>
        public String GetCity()
        {
            return city;
        }

        /// <summary>
        /// Sets the city.
        /// </summary>
        /// <param name="city">The city.</param>
        public void SetCity(String city)
        {
            this.city = city;
        }

        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <returns></returns>
        public String GetCountry()
        {
            return country;
        }

        /// <summary>
        /// Sets the country.
        /// </summary>
        /// <param name="country">The country.</param>
        public void SetCountry(String country)
        {
            this.country = country;
        }

        /// <summary>
        /// Gets the longitude.
        /// </summary>
        /// <returns></returns>
        public double GetLongitude()
        {
            return longitude;
        }

        /// <summary>
        /// Sets the longitude.
        /// </summary>
        /// <param name="longitude">The longitude.</param>
        public void SetLongitude(double longitude)
        {
            this.longitude = longitude;
        }

        /// <summary>
        /// Gets the latitude.
        /// </summary>
        /// <returns></returns>
        public double GetLatitude()
        {
            return latitude;
        }

        /// <summary>
        /// Sets the latitude.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        public void SetLatitude(double latitude)
        {
            this.latitude = latitude;
        }


        /// <summary>
        /// Nearests the places.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns></returns>
        public List<Location> NearestPlaces(double distance)
        {
            return new List<Location>() {
                    new Location("000001", "Munich", "Alemania", 2.446, 1.045),
                    new Location("000002", "Lisboa", "Portugal", 20.406, 10.355)};
        }
    }
}