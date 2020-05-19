using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrackMyWalks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WalkEntryPage : ContentPage
    {
        public WalkEntryPage()
        {
            InitializeComponent();
        }

        private void SaveWalkItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync(true);
        }
    }
}