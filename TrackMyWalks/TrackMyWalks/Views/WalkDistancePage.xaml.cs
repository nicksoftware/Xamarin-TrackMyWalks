using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackMyWalks.Models;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace TrackMyWalks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WalkDistancePage : ContentPage
    {
        private  WalkData _walkData;

        public WalkDistancePage(WalkData walkData)
        {
            InitializeComponent();
            _walkData = walkData;
            // Update the page title for our Distance Travelled Page
            Title = "Distance Travelled Information";

            // Place a pin on the map for the chosen walk type
            MyCustomTrailMap.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Position = new Position(
                            _walkData.Latitude,
                            _walkData.Longitude),
                Label = _walkData.Title,
                Address = "Difficulty: " +_walkData.Difficulty
                + "Total Distance: " + _walkData.Distance,
                Id = _walkData.Title});

            // Create a region around the map within a one-kilometer radius
            MyCustomTrailMap.MoveToRegion(MapSpan.FromCenterAndRadius(new
            Position(_walkData.Latitude,
            _walkData.Longitude), Distance.FromKilometers(1.0)));

        }


        // that ends the current trail and returns back to the main screen.
        private void EndThisTrail_Clicked(object sender, EventArgs e)
        {
            _walkData = null;
            Navigation.PopToRootAsync(true);
        }
    }
}