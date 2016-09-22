using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinDroid.Core.Model;
using XamarinDroid.Core.Repository;

namespace XamarinDroid.Android
{
    [Activity(Label = "Kontaktbog")]
    public class PersonDetailActivity : Activity
    {
        public TextView FirstnameView { get; set; }

        public TextView LastnameView { get; set; }

        public Person SelectedPerson { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PersonDetailView);
            ActionBar.Hide();
            var personRepo = new PersonRepository();
            SelectedPerson = personRepo.GetById(1);

            FindViews();

            FirstnameView.Text = SelectedPerson.Firstname;
            LastnameView.Text = SelectedPerson.Lastname;
           
            
        }

        public override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
            Window.SetTitle($"{SelectedPerson.Firstname} {SelectedPerson.Lastname}");
        }

        private void FindViews()
        {
            FirstnameView = FindViewById<TextView>(Resource.Id.firstName);
            LastnameView = FindViewById<TextView>(Resource.Id.lastName);

        }
    }
}