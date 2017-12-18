using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneySorterAssembly.JourneyHelper.BusCard
{

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="JourneySorterAssembly.JourneyHelper.IBoardingJourneyCard" />
    public class BusBoardingJourneyCardExtension : IBoardingJourneyCard
    {


        /// <summary>
        /// Creates the boarding journey card.
        /// </summary>
        /// <returns>BusBoardingJourneyCard</returns>
        public BoardingJourneyCard CreateBoardingJourneyCard()
        {
            return new BusBoardingJourneyCard();
        }

    }
}