using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using static Android.Widget.Toast;

namespace PokemonMobileClient
{
    [Activity(Label = "About")]
    public class ContactActivity : Activity
    {
        private EditText emailAddressTextField;
        private EditText messageTextField;
        private Button submitFeedbackButton;
        
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Contact);

            FindViews();
            HandleEvents();
            SetColors(emailAddressTextField);
            SetColors(messageTextField);
            //emailAddressTextField.
            // Create your application here
        }

        private void SetColors(EditText editText)
        {
            editText.SetBackgroundColor(Color.FloralWhite);
            editText.SetTextColor(Color.Black);
            editText.SetHintTextColor(Color.Gray);
        }

        private void HandleEvents()
        {
            submitFeedbackButton.Click += SubmitFeedbackButton_Click;
        }

        private void SubmitFeedbackButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(emailAddressTextField.Text) && !string.IsNullOrEmpty(messageTextField.Text))
            {
                //submit feedback to SERVER

                Toast toast = Toast.MakeText(this, "Submitted! Thanks", ToastLength.Short);
                toast.SetGravity(GravityFlags.Center, 0, 0);
                toast.Show();
            }
        }

        private void FindViews()
        {
            emailAddressTextField = FindViewById<EditText>(Resource.Id.contactEmailAddressTextField);
            messageTextField = FindViewById<EditText>(Resource.Id.contactMessageTextField);
            submitFeedbackButton = FindViewById<Button>(Resource.Id.contactSendFeedback);

        }
    }
}