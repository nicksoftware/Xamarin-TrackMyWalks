using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackMyWalks.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrackMyWalks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WalksMainPage : ContentPage
    {
        public WalksMainPage()
        {
            InitializeComponent();
        }
        public void InitialiseWalks()
        {
            // Create a collection that will raise an event, 
            // whenever an object is added or removed from 
            // our WalksListModel collection.
            var WalksList = new ObservableCollection<WalkData> {

                 // Populate our collection with some dummy data that will be used 
                 // to populate our ListView
                 new WalkData
                 {
                     Id = 1,
                     Title = "10 Mile Brook Trail, Margaret River",
                     Description = "The 10 Mile Brook Trail starts in the Rotary Park" +
                     "near Old Kate, a preserved steam engine at the northern edge of Margaret River. ",
                     Latitude = -33.9727604,
                     Longitude = 115.0861599,
                     Distance = 7.5,
                     Difficulty = "Medium",
                     ImageUrl = "http://trailswa.com.au/media/cache/media/images/trails/_mid/FullSizeRender1_600_480_c1.jpg"
                 },
                 new WalkData
                 {
                     Id = 2,
                     Title = "Ancient Empire Walk, Valley of the Giants",
                     Description = "The Ancient Empire is a 450 metre walk trail that " +
                     " takes you around and through some of the giant tingle treesincluding" +
                     " the most popular of the gnarled veterans, known as Grandma Tingle.",
                     Latitude = -34.9749188,
                     Longitude = 117.3560796,
                     Distance = 450,
                     Difficulty = "Hard",
                     ImageUrl = "http://trailswa.com.au/media/cache/media/images/trails/_mid/Ancient_Empire_534_480_c1.jpg"
                 }};
            // Populate our ListView with entries from our WalksListModel
            WalkEntriesListView.ItemsSource = WalksList;
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {

            //Navigation.PushAsync(new WalkEntryPage());
        }

        private void WalkEntriesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            // Get the selected item from our ListView
            var item = e.Item as WalkData;
            Navigation.PushAsync(new WalkTrailInfoPage(item));
        }
    }
}