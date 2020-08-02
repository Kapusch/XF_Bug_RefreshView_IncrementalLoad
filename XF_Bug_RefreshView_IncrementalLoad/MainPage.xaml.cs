using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_Bug_RefreshView_IncrementalLoad
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void CollectionView_RemainingItemsThresholdReached(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("REQUEST : CollectionView_RemainingItemsThresholdReached");
            // NOTE : Comment alerts in order to fully trigger the pull-to-refresh and see diagnostic logs
            DisplayAlert("", "", "LOAD MORE");
        }

        void RefreshView_Refreshing(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("REQUEST : RefreshView_Refreshing");
            // NOTE : Comment alerts in order to fully trigger the pull-to-refresh and see diagnostic logs
            DisplayAlert("", "", "REFRESH LIST");
        }
    }
}
