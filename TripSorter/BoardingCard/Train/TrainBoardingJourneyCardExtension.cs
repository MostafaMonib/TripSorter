namespace JourneySorterAssembly.JourneyHelper.TrainCard
{
    //Developed By : mostafa.monib@gmail.com mostafa monib
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="JourneySorterAssembly.JourneyHelper.IBoardingJourneyCard" />
    public class TrainBoardingJourneyCardExtension : IBoardingJourneyCard
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