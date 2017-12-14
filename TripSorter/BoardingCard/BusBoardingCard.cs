using System;
using System.Text;

namespace JourneySorterAssembly.JourneyHelper
{

    /// <summary>

    /// </summary>
    /// <seealso cref="JourneySorterAssembly.JourneyHelper.BoardingJourneyCard" />
    public class BusBoardingJourneyCard : BoardingJourneyCard
    {



        /// <summary>
        /// Get More Informatios
        /// It allows to obtain the information contained in a boarding pass.
        /// Depending on the type of transport, the information displayed will be different.
        /// </summary>
        /// <returns>String</returns>
        public override String GetMoreInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Convert.ToInt32(Getid())).Append(". ").Append("Take the airport bus from ").Append(GetDeparture().GetCity()).Append(" to ")
                .Append(GetDestination().GetCity()).Append(".");
            sb = GetSeat() == null
                    ? sb.Append("No seat assignment")
                    : sb.Append("Seat ").Append(GetSeat());
            sb.Append("\n");
            Constants.LatesId = Convert.ToInt32(Getid());
            return sb.ToString();
        }

    }
}