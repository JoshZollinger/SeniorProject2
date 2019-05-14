using App2.Models;
using App2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateNewPasswordPage : ContentPage
	{
        public int userID { get; set; }
        public string userFirstName{ get; set; }
        public string userLastName{ get; set; }
        public string userUsername{ get; set; }
        
		public CreateNewPasswordPage (int id, string firstName, string lastName, string username)
		{
			InitializeComponent();
            this.userID = id;
            this.userFirstName = firstName;
            this.userLastName = lastName;
            this.userUsername = username;
		}

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            checkPasswordMatch();
        }

        private async void checkPasswordMatch()
        {
            if(newPassword.Text == newPasswordConfirm.Text)
            {
                GolfUser editedUser = new GolfUser(this.userID, this.userFirstName, this.userLastName, this.userUsername, newPassword.Text, false);
                GolfUserServices service = new GolfUserServices();
                await service.EditGolfUserAsync(this.userID, editedUser);
                popCreateNewPasswordPage();
            }
            else
            {
                errorMessage.Text = "The passwords do not match";
            }
        }

        private async void popCreateNewPasswordPage()
        {
            await Navigation.PopModalAsync();
        }

       
    }
}