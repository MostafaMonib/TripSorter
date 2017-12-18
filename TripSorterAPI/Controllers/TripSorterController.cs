using JourneySorterAssembly.JourneyHelper;
using JourneySorterAssembly.JourneyHelper.AirplaneCard;
using JourneySorterAssembly.JourneyHelper.BusCard;
using JourneySorterAssembly.JourneyHelper.PureJourneyTechnique;
using JourneySorterAssembly.JourneyHelper.TrainCard;
using JourneySorterAssembly.Transportation;
using Microsoft.Azure.Mobile.Server.Config;
using System;
using System.Collections.Generic;
using System.Web.Http;
using TripSorterClient_Web.Modal;

namespace TripSorterAPI.Controllers
{
    /// <summary>
    /// Use the MobileAppController attribute for each ApiController you want to use
    /// from your mobile clients
    /// 
    /// Developed By : mostafa.monib@gmail.com mostafa monib
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    [MobileAppController]
    public class TripSorterController : ApiController
    {
        /// <summary>
        /// Posts the sorted journy.
        /// This API should call the bussines logic that is JourneySorterAssemblye.dll
        /// </summary>
        /// <param name="tripCards">The trip cards.</param>
        /// <returns></returns>
        public string PostSortedJourny(List<TripCard> tripCards)
        {
            string journeyInfo = string.Empty;

            IBoardingJourneyCard airplaneBoardingJourneyCardFactory = new AirplaneBoardingJourneyCardExtension();
            IBoardingJourneyCard trainBoardingJourneyCardFactory = new TrainBoardingJourneyCardExtension();
            IBoardingJourneyCard busBoardingJourneyCardFactory = new BusBoardingJourneyCardExtension();

            List<BoardingJourneyCard> unorderedBCards = new List<BoardingJourneyCard>();

            #region boarding passes Journey Cards Data

            for (int i = 0; i < tripCards.Count; i++)
            {
                var trip = tripCards[i];

                if (trip.Transport.ToLower() == "airplane")
                {
                    unorderedBCards.Add(airplaneBoardingJourneyCardFactory.CreateBoardingJourneyCard());
                    var bJourneyAir = (AirplaneBoardingJourneyCard)unorderedBCards[i];

                    bJourneyAir
                        .SetFlightNumber(trip.FlightNumber)
                        .SetGate(trip.Gate)
                        .SetBaggageTicketCounter(trip.BaggageTicketCounter)
                        .SetId(trip.Id)
                        .SetTransport(new Airplane())
                        .SetSeat(trip.Seat)
                        .SetDeparture(new JourneySorterAssembly.Locator
                            .Location(trip.Departure.City+"-"+ trip.Departure.Country, trip.Departure.City, trip.Departure.Country))
                        .SetDestination(new JourneySorterAssembly.Locator
                            .Location(trip.Destination.City + "-" + trip.Destination.Country, trip.Destination.City, trip.Destination.Country));
                }
                else if (trip.Transport.ToLower() == "bus")
                {
                    unorderedBCards.Add(busBoardingJourneyCardFactory.CreateBoardingJourneyCard());
                    var bJourneyBus = (BusBoardingJourneyCard)unorderedBCards[i];

                    bJourneyBus
                        .SetId(trip.Id)
                        .SetSeat(null)
                        .SetDeparture(new JourneySorterAssembly.Locator
                            .Location(trip.Departure.City + "-" + trip.Departure.Country, trip.Departure.City, trip.Departure.Country))
                        .SetDestination(new JourneySorterAssembly.Locator
                            .Location(trip.Destination.City + "-" + trip.Destination.Country, trip.Destination.City, trip.Destination.Country));
                }
                else if (trip.Transport.ToLower() == "train")
                {
                    unorderedBCards.Add(trainBoardingJourneyCardFactory.CreateBoardingJourneyCard());
                    var bJourneyTrain = (TrainBoardingJourneyCard)unorderedBCards[i];

                    bJourneyTrain
                        .SetId(trip.Id)
                        .SetTransport(new Train(trip.TrainNumber))
                        .SetSeat(trip.Seat)
                        .SetDeparture(new JourneySorterAssembly.Locator
                            .Location(trip.Departure.City + "-" + trip.Departure.Country, trip.Departure.City, trip.Departure.Country))
                        .SetDestination(new JourneySorterAssembly.Locator
                            .Location(trip.Destination.City + "-" + trip.Destination.Country, trip.Destination.City, trip.Destination.Country));
                }
            }
            #endregion

            // Establish the ordering Technique following the Technique pattern
            Journey Journey = new Journey(unorderedBCards);
            Journey.SetOrderingTravelTechnique(new TechniqueNoStartNoEnd());

            // Order travel cards
            Journey.SortJourney(unorderedBCards);

            // Show the Journey information
            journeyInfo = Journey.GetMoreInformationFroTravel();
            Console.WriteLine(journeyInfo);

            return journeyInfo;
        }
    }
}
