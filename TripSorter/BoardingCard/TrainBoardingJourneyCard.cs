using JourneySorterAssembly.Transportation;
using System;
using System.Text;

namespace JourneySorterAssembly.JourneyHelper
{

    /// <summary>
    /// Developed By : mostafa.monib@gmail.com mostafa monib
    /// </summary>
    /// <seealso cref="JourneySorterAssembly.JourneyHelper.BoardingJourneyCard" />
    public class TrainBoardingJourneyCard : BoardingJourneyCard
    {

        /// <summary>
        /// Get More Informations.
        /// It allows to obtain the information contained in a boarding pass.
        /// Depending on the type of transport, the information displayed will be different.
        /// </summary>
        /// <returns>
        /// String
        /// </returns>
        public override String GetMoreInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Convert.ToInt32(Getid())).Append(". ").Append("Take train ").Append(((Train)GetTransport()).GetTrainNumber())
                .Append(" from ").Append(GetDeparture().GetCity()).Append(" to ")
                .Append(GetDestination().GetCity()).Append(". Sit in seat ").Append(GetSeat())
                .Append("\n");
            Constants.LatesId = Convert.ToInt32(Getid());
            return sb.ToString();
        }

    }
}