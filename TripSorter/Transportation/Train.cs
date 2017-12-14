using System;

namespace JourneySorterAssembly.Transportation
{

    /// <summary>
    /// Class representing the train-type vehicle or means of transport
    /// 
    /// Developed By : mostafa.monib@gmail.com mostafa monib
    /// </summary>
    /// <seealso cref="JourneySorterAssembly.Transportation.Transport" />
    public class Train : Transport
    {

        /// <summary>
        /// The train number
        /// </summary>
        private String trainNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Train"/> class.
        /// </summary>
        /// <param name="trainNumber">The train number.</param>
        public Train(String trainNumber) : base()
        {
            this.trainNumber = trainNumber;
        }

        /// <summary>
        /// Gets the train number.
        /// </summary>
        /// <returns></returns>
        public String GetTrainNumber()
        {
            return trainNumber;
        }

        /// <summary>
        /// Sets the train number.
        /// </summary>
        /// <param name="trainNumber">The train number.</param>
        public void SetTrainNumber(String trainNumber)
        {
            this.trainNumber = trainNumber;
        }


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
            return DateTime.Now.AddYears(10);
        }

        /// <summary>
        /// Gets the type vehicle.
        /// </summary>
        /// <returns></returns>
        public override String GetTypeVehicle()
        {
            return "Train";
        }
    }
}