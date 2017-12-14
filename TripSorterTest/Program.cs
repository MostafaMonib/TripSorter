using JourneySorterAssembly.JourneyHelper;
using JourneySorterAssembly.Locator;
using JourneySorterAssembly.Transportation;
using System;
using System.Collections.Generic;

namespace TripSorterTest
{
    /// <summary>
    /// Test the JourneySorterAssemblye.dll is workin fine or not!
    /// 
    /// Developed By : mostafa.monib@gmail.com mostafa monib
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {

            // Manufacture 4 boarding passes using the Factory pattern to create different factories
            // according to the type of boarding card we want to create
            IBoardingJourneyCardExtension airplaneBoardingJourneyCardFactory = new AirplaneBoardingJourneyCardExtension();
            IBoardingJourneyCardExtension trainBoardingJourneyCardFactory = new TrainBoardingJourneyCardExtension();
            IBoardingJourneyCardExtension busBoardingJourneyCardFactory = new BusBoardingJourneyCardExtension();

            List<BoardingJourneyCard> unorderedBoardingJourneyCards = new List<BoardingJourneyCard>()
            {
                    airplaneBoardingJourneyCardFactory.CreateBoardingJourneyCard(),
                    trainBoardingJourneyCardFactory.CreateBoardingJourneyCard(),
                    airplaneBoardingJourneyCardFactory.CreateBoardingJourneyCard(),
                    busBoardingJourneyCardFactory.CreateBoardingJourneyCard()
            };

            #region 4 boarding passes Journey Cards Data
            var bJourneyCard1 = (AirplaneBoardingJourneyCard)unorderedBoardingJourneyCards[0];

            var bJourneyCard2 = (TrainBoardingJourneyCard)unorderedBoardingJourneyCards[1];

            var bJourneyCard3 = (AirplaneBoardingJourneyCard)unorderedBoardingJourneyCards[2];

            var bJourneyCard4 = (BusBoardingJourneyCard)unorderedBoardingJourneyCards[3];

            bJourneyCard1.SetFlightNumber("SK22")
                .SetGate("22")
                .SetBaggageTicketCounter(null)
                .SetId("004")
                .SetTransport(new Airplane())
                .SetSeat("7B")
                .SetDeparture(new Location("stockolm-sweeden", "Stockolm", "Sweeden"))
                .SetDestination(new Location("ny-usa", "New York", "USA"));

            bJourneyCard2
                .SetId("001")
                .SetTransport(new Train("78A"))
                .SetSeat("45B")
                .SetDeparture(new Location("madrid-spain", "Madrid", "Spain"))
                .SetDestination(new Location("barcelona-spain", "Barcelona", "Spain"));

            bJourneyCard3
                .SetFlightNumber("SK455")
                .SetGate("45B")
                .SetBaggageTicketCounter("344")
                .SetId("003")
                .SetSeat("3A")
                .SetDeparture(new Location("geronaairport-spain", "Gerona", "Spain"))
                .SetDestination(new Location("stockolm-sweeden", "Stockolm", "Sweeden"));

            bJourneyCard4
                .SetId("002")
                .SetSeat(null)
                .SetDeparture(new Location("barcelona-spain", "Barcelona", "Spain"))
                .SetDestination(new Location("geronaairport-spain", "Gerona", "Spain"));
            #endregion

            // Establish the ordering Technique following the Technique pattern
            Journey Journey = new Journey(unorderedBoardingJourneyCards);
            Journey.SetOrderingTravelTechnique(new TechniqueNoStartNoEnd());

            // Order travel cards
            Journey.SortJourney(unorderedBoardingJourneyCards);

            // Show the Journey information
            Console.WriteLine(Journey.GetMoreInformationFroTravel());

            //Stop program until the user inter any keword
            Console.ReadKey();
        }
    }
}
