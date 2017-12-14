using System;

namespace JourneySorterAssembly.Transportation
{
    /// <summary>
    /// Developed By : mostafa.monib@gmail.com mostafa monib
    /// </summary>
    /// <seealso cref="JourneySorterAssembly.Transportation.Transport" />
    public class Airplane : Transport
    {


        /// <summary>
        /// Determines whether [is out of order].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is out of order]; otherwise, <c>false</c>.
        /// </returns>
        public override Boolean IsOutOfOrder()
        {
            return false;
        }


        /// <summary>
        /// Dates the off road.
        /// </summary>
        /// <returns></returns>
        public override DateTime DateOffRoad()
        {
            return DateTime.Now.AddYears(7);
        }


        /// <summary>
        /// Gets the type vehicle.
        /// </summary>
        /// <returns></returns>
        public override String GetTypeVehicle()
        {
            return "Aeroplane";
        }
    }
}
