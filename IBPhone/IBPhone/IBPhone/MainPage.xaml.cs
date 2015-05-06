using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using IBPhone;
using System.Collections.ObjectModel;
using System.Windows.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace IBPhone
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private const String serviceURI = "PASTE IN THE URI STRING FOR AZURE CLOUD SERVICE SITE";
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void FodMaps(object sender, RoutedEventArgs e)
        {
            
        }

        private async void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(serviceURI);                             // base URL for API Controller i.e. RESTFul service

                    // add an Accept header for JSON
                    client.DefaultRequestHeaders.
                        Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // GET ../api/badfood
                    // get all badfood listings asynchronously - await the result (i.e. block and return control to caller)
                  
                        HttpResponseMessage response = await client.GetAsync("api/BadFoods");
                    //HttpResponseMessage response = await client.GetAsync("api/stock");
                 
                   

                     
                    if (response.IsSuccessStatusCode)                                                   // 200.299
                    {
                        // read result and display on UI

                        var bFood = await response.Content.ReadAsAsync<IEnumerable<BadFood>>();

                        // set the data source for the priceList long list selector
                       // FoodList.ItemsSource = new ObservableCollection<BadFood>(bFood);
                    }
                    else
                    {
                        //
                    }
                }
            }
            catch (Exception)
            {
                //;
            }
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SecondPage));
        }

        private void HyperlinkButton2_Click(object sender, RoutedEventArgs e)
        {
            Uri targetUri = new Uri(@"http://ibfreeapp.azurewebsites.net/Home/Challenge");
        }


    }
}



