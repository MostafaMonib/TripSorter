using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneySorterAssembly.JourneyHelper.PureJourneyTechnique
{
    //Developed By : mostafa.monib@gmail.com mostafa monib
    /// <summary>
    /// 
    /// </summary>
    public class Journey
    {

        /// <summary>
        /// The boarding journey cards
        /// </summary>
        private List<BoardingJourneyCard> BoardingJourneyCards;

        /// <summary>
        /// The ordering technique
        /// </summary>
        private IJourneySorterTechnique orderingTechnique;

        /// <summary>
        /// Initializes a new instance of the <see cref="Journey"/> class.
        /// </summary>
        /// <param name="BoardingJourneyCards">The boarding journey cards.</param>
        public Journey(List<BoardingJourneyCard> BoardingJourneyCards)
        {
            this.BoardingJourneyCards = BoardingJourneyCards;
        }

        /// <summary>
        /// Sets the ordering travel technique.
        /// </summary>
        /// <param name="orderingTechnique">The ordering technique.</param>
        public void SetOrderingTravelTechnique(IJourneySorterTechnique orderingTechnique)
        {
            this.orderingTechnique = orderingTechnique;
        }

        /// <summary>
        /// Sorts the journey.
        /// </summary>
        /// <param name="BoardingJourneyCards">The boarding journey cards.</param>
        /// <returns></returns>
        public List<BoardingJourneyCard> SortJourney(List<BoardingJourneyCard> BoardingJourneyCards)
        {
            this.BoardingJourneyCards = orderingTechnique.SortJourney(BoardingJourneyCards);
            return BoardingJourneyCards;
        }

        /// <summary>
        /// Gets the more information fro travel.
        /// It allows to obtain the information contained in a boarding pass.
        /// Depending on the type of transport, the information displayed will be different.
        /// </summary>
        /// <returns>String</returns>
        public String GetMoreInformationFroTravel()
        {
            StringBuilder sb = new StringBuilder();
            foreach (BoardingJourneyCard bc in BoardingJourneyCards)
            {
                sb.Append(bc.GetMoreInformation());
            }

            sb.Append(Constants.LatesId + 1).Append(". ").Append("You have arrived at your final destination.");
            return sb.ToString();
        }
    }
}