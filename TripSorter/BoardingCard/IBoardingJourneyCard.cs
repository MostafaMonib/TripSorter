namespace JourneySorterAssembly.JourneyHelper
{

    /// <summary>
    /// This class acts as a manufacturing factory for boarding cards following the design pattern Factory Method
    /// 
    /// Developed By : mostafa.monib@gmail.com mostafa monib
    /// </summary>
    public interface IBoardingJourneyCard
    {

        /// <summary>
        /// Creates the boarding journey card.
        /// </summary>
        /// <returns>BoardingJourneyCard</returns>
        BoardingJourneyCard CreateBoardingJourneyCard();

    }
}