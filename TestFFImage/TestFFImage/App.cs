using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FFImageLoading.Forms;
using Xamarin.Forms;

namespace TestFFImage
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                         new CachedImage() {
                             Source = ImageSource.FromUri(new Uri("https://casamentojoelfilipa.blob.core.windows.net/images/groomsmenbridesmaid.png"))
                         }
                     }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
