using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackMyWalks.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrackMyWalks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WalkTrailInfoPage : ContentPage
    {
        private WalkData _walkData;
        public WalkTrailInfoPage(WalkData walkData)
        {
            _walkData = walkData;
            InitializeComponent();

            this.BindingContext = _walkData;
        }

        private void BeginTrailWalk_Clicked(object sender, EventArgs e)
        {

            if (_walkData == null)
                return;

            Navigation.PushAsync(new WalkDistancePage());
            Navigation.RemovePage(this);
        }
    }
}