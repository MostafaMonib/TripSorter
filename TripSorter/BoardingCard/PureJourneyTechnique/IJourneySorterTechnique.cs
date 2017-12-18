using System.Collections.Generic;

namespace JourneySorterAssembly.JourneyHelper.PureJourneyTechnique
{

    /// <summary>
    /// This class represents the parent class for any sorting strategy of a set of cards
    /// of boarding.
    /// This class is part of the Technique pattern to have different card sorting algorithms
    /// of boarding, but in a dynamic and extensible way
    /// Developed By: mostafa.monib@gmail.com mostafa monib    
    /// </summary>
    public interface IJourneySorterTechnique
    {
        /// <summary>
        /// Sorts the journey.
        /// It allows to obtain the information contained in a boarding pass.
        /// Depending on the type of transport, the information displayed will be different.
        /// </summary>
        /// <param name="BoardingJourneyCards">The boarding journey cards.</param>
        /// <returns>List<BoardingJourneyCard></returns>
        List<BoardingJourneyCard> SortJourney(List<BoardingJourneyCard> BoardingJourneyCards);
    }
}