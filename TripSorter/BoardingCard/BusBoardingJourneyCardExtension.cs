using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneySorterAssembly.JourneyHelper
{

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="JourneySorterAssembly.JourneyHelper.IBoardingJourneyCardExtension" />
    public class BusBoardingJourneyCardExtension : IBoardingJourneyCardExtension
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