using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.Services;
using App2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        
		public LoginPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            GolfUserServices service = new GolfUserServices();
            var golfUserlist = await service.GetGolfUsersAsync();
            
            int userId = checkResults(golfUserlist);
            if (userId != 0)
            {
                if (golfUserlist[userId-1].isNewUser)
                {
                    await Navigation.PushModalAsync(new CreateNewPasswordPage(userId, golfUserlist[userId - 1].firstName, golfUserlist[userId - 1].lastName, golfUserlist[userId - 1].userName));
                    ShowMainPage();
                }
                else
                {
                    ShowMainPage();
                }
            }
            else
            {
                errorMessage.Text = "Username or password is incorrect";
            }
            
        }

        private int checkResults(List<GolfUser> golfUserlist)
        {
            int returnValue = 0;
            string possibleUsername = usernameEntry.Text;
            string possiblePassword = passwordEntry.Text;
            foreach (GolfUser golfUser in golfUserlist)
            {
                if (golfUser.userName == possibleUsername && golfUser.password == possiblePassword)
                {
                    Application.Current.Properties["IsLoggedIn"] = Boolean.TrueString;
                    Application.Current.Properties["CurrentFirstName"] = golfUser.firstName;
                    Application.Current.Properties["CurrentLastName"] = golfUser.lastName;
                    Application.Current.SavePropertiesAsync();
                    returnValue = golfUser.Id;
                }
            }
            return returnValue;
        }

        public async void ShowMainPage()
        {
            await Navigation.PushAsync(new MainPage());

        }
    }
}