using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneySorterAssembly.JourneyHelper
{

    /// <summary>
    /// 
    /// Developed By : mostafa.monib@gmail.com
    /// 
    /// </summary>
    /// <seealso cref="JourneySorterAssembly.JourneyHelper.IBoardingJourneyCardExtension" />
    public class AirplaneBoardingJourneyCardExtension : IBoardingJourneyCardExtension
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