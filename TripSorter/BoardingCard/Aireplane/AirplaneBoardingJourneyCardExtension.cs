using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneySorterAssembly.JourneyHelper.AirplaneCard
{

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="JourneySorterAssembly.JourneyHelper.IBoardingJourneyCard" />
    public class AirplaneBoardingJourneyCardExtension : IBoardingJourneyCard
    {


        /// <summary>
        /// Creates the boarding journey card.
        /// </summary>
        /// <returns>AirplaneBoardingJourneyCard</returns>
        public BoardingJourneyCard CreateBoardingJourneyCard()
        {
            return new AirplaneBoardingJourneyCard();
        }

    }
}