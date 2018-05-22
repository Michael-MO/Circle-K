using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using AddOns.Images.Implementation;
using AddOns.Images.Interfaces;
using Client.ViewModel.App;
using Client.Views.Domain;
using Extensions.AddOns.Implementation;
using Client.Model.Domain;
using Client.Model.App;
//using Client.ViewModel.App; //uncomment when Nav-view is inplementet
//using Client.View.App; // uncomment when Nav-view is inplementet

namespace Client.Configeration.App
{
    public class AppConfig
    {
        public static String ServerURL = "http://localhost:55985"; // insert url for server here

        public static void Setup(Page mainPage, Frame appFrame)
        {
            SetupAppImages("..\\..\\..\\Assets\\App\\");
            SetupDomainImages("..\\..\\..\\Assets\\Images\\");
            appFrame.Navigate(typeof(MainMenu));
            ((AppViewModel)mainPage.DataContext).MainAppFrame = appFrame;

            DomainModel.Instance.Employees.LoadAsync();
        }

        public static void SetupAppImages(string prefix)
        {
            ServiceProvider.Images.SetAppImageSource(AppImageType.NotFound, prefix + "NotSet.jpg");
            ServiceProvider.Images.SetAppImageSource(AppImageType.Logo, prefix + "Logo120x60.jpg");
        }

        private static void SetupDomainImages(string preface)
        {
            List<IImage> imageList = new List<IImage>();

            //Tilføj billede fra domæne klasser. Se Pers eksempel

            ServiceProvider.Images.SetImages(imageList);
        }
    }
}
