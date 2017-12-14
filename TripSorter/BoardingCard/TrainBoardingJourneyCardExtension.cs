namespace JourneySorterAssembly.JourneyHelper
{

    /// <summary>
    /// Developed By : mostafa.monib@gmail.com mostafa monib
    /// </summary>
    /// <seealso cref="JourneySorterAssembly.JourneyHelper.IBoardingJourneyCardExtension" />
    public class TrainBoardingJourneyCardExtension : IBoardingJourneyCardExtension
    {

        /// <summary>
        /// Creates the boarding journey card.
        /// </summary>
        /// <returns>
        /// BoardingJourneyCard
        /// </returns>
        public BoardingJourneyCard CreateBoardingJourneyCard()
    {
        return new TrainBoardingJourneyCard();
    }

}
}