using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TripSorterClient_Web.Modal;
using Xamarin.Forms;

namespace TripSorterXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnCallAPI_Clicked(object sender, EventArgs e)
        {
            // response the trip information text and then i can write this text on the web page :)
            string journyResponse = await GetJournyAsync();

            for (int i = 0; i < 5; i++)
            {
                journyResponse += "\n";
            }

            Constants.counter++;

            journyResponse += "<p>Developed By : mostafa.monib@gmail.com <br /> <a href='http://bit.ly/LinkMon'>Connect with me on LinkedIn: Mostafa Monib</a></p>";
            journyResponse += "\n";
            journyResponse += $"This service was called { Constants.counter} times!. Good Luck";

            lblTripInformations.Text = journyResponse;
        }

        /// <summary>
        /// Gets the journy asynchronous.
        /// </summary>
        /// <returns></returns>
        private async Task<string> GetJournyAsync()
        {

            TripCard trip1 = new TripCard()
            {
                Id = "004",
                Gate = "22",
                FlightNumber = "SK22",
                BaggageTicketCounter = null,
                Transport = "Airplane",
                Seat = "7B",
                Departure = new Location() { City = "Stockolm", Country = "Sweeden" },
                Destination = new Location() { City = "New York", Country = "Sweeden" },
            };

            TripCard trip2 = new TripCard()
            {
                Id = "001",
                Transport = "Train",
                TrainNumber = "78A",
                Seat = ("45B"),
                Departure = new Location() { City = "Madrid", Country = "Spain" },
                Destination = new Location() { City = "Barcelona", Country = "Spain" }
            };

            TripCard trip3 = new TripCard()
            {
                FlightNumber = "SK455",
                Gate = "45B",
                Transport = "Airplane",
                BaggageTicketCounter = "344",
                Id = "003",
                Seat = "3A",
                Departure = new Location() { City = "Gerona", Country = "Spain" },
                Destination = new Location() { City = "Stockolm", Country = "Sweeden" }
            };

            TripCard trip4 = new TripCard()
            {
                Id = "002",
                Seat = null,
                Transport = "Bus",
                Departure = new Location() { City = "Barcelona", Country = "Spain" },
                Destination = new Location() { City = "Gerona", Country = "Spain" }
            };

            List<TripCard> tripCards = new List<TripCard>() { trip1, trip2, trip3, trip4 };

            // Save And Retrive the API URI in web.config file to can edit it after that easly
            string apiURI = "http://tripsorterapi-001-site1.itempurl.com/";
            // Get client connection with azure mobile service
            var client = new MobileServiceClient(apiURI);

            // Call the azure mobile service that i use
            return await
                client.InvokeApiAsync<List<TripCard>, string>("TripSorter", tripCards, HttpMethod.Post, null);
        }

    }

}
