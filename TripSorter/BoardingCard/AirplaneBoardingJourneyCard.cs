using System;
using System.Text;

namespace JourneySorterAssembly.JourneyHelper
{

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="JourneySorterAssembly.JourneyHelper.BoardingJourneyCard" />
    public class AirplaneBoardingJourneyCard : BoardingJourneyCard
    {

        /// <summary>
        /// The flight number
        /// </summary>
        private String flightNumber;

        /// <summary>
        /// The gate
        /// Boarding gate
        /// </summary>
        private String gate;

        /// <summary>
        /// The bagga geticket counter
        /// Code of the counter where to check-in
        /// </summary>
        private String baggaGeticketCounter;

        /// <summary>
        /// Initializes a new instance of the <see cref="AirplaneBoardingJourneyCard"/> class.
        /// </summary>
        public AirplaneBoardingJourneyCard() : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AirplaneBoardingJourneyCard"/> class.
        /// Build an airplane boarding pass type object
        /// </summary>
        /// <param name="flightNumber">The flight number.</param>
        /// <param name="gate">The gate.</param>
        /// <param name="baggaGeticketCounter">The bagga geticket counter.</param>
        public AirplaneBoardingJourneyCard(String flightNumber, String gate, String baggaGeticketCounter) : base()
        {
            this.flightNumber = flightNumber;
            this.gate = gate;
            this.baggaGeticketCounter = baggaGeticketCounter;
        }

        /// <summary>
        /// Gets the flight number.
        /// </summary>
        /// <returns></returns>
        public String GetFlightNumber()
        {
            return flightNumber;
        }

        /// <summary>
        /// Sets the flight number.
        /// </summary>
        /// <param name="flightNumber">The flight number.</param>
        /// <returns></returns>
        public AirplaneBoardingJourneyCard SetFlightNumber(String flightNumber)
        {
            this.flightNumber = flightNumber;
            return this;
        }

        /// <summary>
        /// Gets the gate.
        /// Get the boarding gate boarding pass
        /// </summary>
        /// <returns></returns>
        public String GetGate()
        {
            return gate;
        }

        /// <summary>
        /// Sets the gate.
        /// Allows you to modify the boarding gate of the boarding pass
        /// </summary>
        /// <param name="gate">The gate.</param>
        /// <returns>
        /// @ return The boarding pass with the modified boarding gate     
        /// </returns>
        public AirplaneBoardingJourneyCard SetGate(String gate)
        {
            this.gate = gate;
            return this;
        }

        /// <summary>
        /// Gets the bagga geticket counter.
        /// It allows to obtain the check-in counter code
        /// </summary>
        /// <returns>@ return The code of the check-in counter</returns>
        public String GetBaggaGeticketCounter()
        {
            return baggaGeticketCounter;
        }

        /// <summary>
        /// Sets the baggage ticket counter.
        /// It allows to obtain the information contained in a boarding pass.
        /// Depending on the type of transport, the information shown will be different.
        /// </summary>
        /// <param name="baggaGeticketCounter">
        /// The bagga geticket counter.
        /// </param>
        /// <returns>
        /// @return The information contained on a boarding pass.
        /// </returns>
        public AirplaneBoardingJourneyCard SetBaggageTicketCounter(String baggaGeticketCounter)
        {
            this.baggaGeticketCounter = baggaGeticketCounter;
            return this;
        }


        /// <summary>
        /// More the infor.
        /// It allows to obtain the information contained in a boarding pass.
        /// Depending on the type of transport, the information displayed will be different.
        /// </summary>
        /// <returns>String</returns>
        public override String GetMoreInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Convert.ToInt32(Getid())).Append(". ").Append("From ").Append(GetDeparture().GetCity()).Append(" Airport, take flight ")
                .Append(GetFlightNumber()).Append(" to ").Append(GetDestination().GetCity())
                .Append(". Gate ").Append(GetGate()).Append(", seat ").Append(GetGate())
                .Append(".\n");
            sb = GetBaggaGeticketCounter() == null
                    ? sb.Append("Baggage will be automatically transferred from your last leg")
                    : sb.Append("Baggage drop at ticket counter").Append(GetBaggaGeticketCounter());
            sb.Append("\n");
            Constants.LatesId = Convert.ToInt32(Getid());
            return sb.ToString();
        }


    }
}