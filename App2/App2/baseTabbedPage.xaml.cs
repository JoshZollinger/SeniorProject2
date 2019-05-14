using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class baseTabbedPage : TabbedPage
    {
        public baseTabbedPage(bool isLoggedIn)
        {
            InitializeComponent();
            var statsPage = new StatsPage();
            statsPage.Icon = "Golfer.png";
            statsPage.Title = "View";
            if (!isLoggedIn)
            {
                var loginPageAsNavigation = new NavigationPage(new LoginPage());

                loginPageAsNavigation.Icon = "Clipboard.png";
                loginPageAsNavigation.Title = "Entry";
                Children.Add(statsPage);
                Children.Add(loginPageAsNavigation);

            }
            else
            {
                var mainPage = new MainPage();
                mainPage.Icon = "Clipboard.png";
                mainPage.Title = "Entry";
                statsPage.Icon = "Golfer.png";
                statsPage.Title = "View";
                Children.Add(statsPage);
                Children.Add(mainPage);
            }

        }
    }
}