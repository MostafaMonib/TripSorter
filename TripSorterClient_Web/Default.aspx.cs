using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using TripSorterClient_Web.Modal;

namespace TripSorterClient_Web
{
    /// <summary>
    /// Call trip sorter from client web
    /// Also you can call this service 
    /// from any device and app like chrome extention, windows app, IOS, Andriod 
    /// 
    /// Developed By : mostafa.monib@gmail.com mostafa monib
    /// </summary>
    /// <seealso cref="System.Web.UI.Page" />
    public partial class Default : System.Web.UI.Page
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected async void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            Response.ClearHeaders();


            string journyResponse = "<p>";

            // response the trip information text and then i can write this text on the web page :)
            journyResponse = await GetJournyAsync();

            journyResponse = Server.HtmlEncode(journyResponse).Replace("\n", "<br />");

            for (int i = 0; i < 5; i++)
            {
                journyResponse += "<br />";
            }
            journyResponse += "</p>";

            Constants.counter++;

            journyResponse += "<p>Developed By : mostafa.monib@gmail.com <br /> <a href='http://bit.ly/LinkMon'>Connect with me on LinkedIn: Mostafa Monib</a></p>";
            journyResponse += "<br />";
            journyResponse += "<p>";
            journyResponse += $"This service was called { Constants.counter} times!. Good Luck";
            journyResponse += "</p>";
            Response.Write(journyResponse);


            Response.End();
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
            string apiURI = ConfigurationManager.AppSettings["TripSorterAPI_URI"];
            // Get client connection with azure mobile service
            var client = new MobileServiceClient(apiURI);

            // Call the azure mobile service that i use
            return await
                client.InvokeApiAsync<List<TripCard>, string>("TripSorter", tripCards, HttpMethod.Post, null);
        }
    }
}