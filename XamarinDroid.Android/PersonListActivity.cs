using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using XamarinDroid.Android.Adapters;
using XamarinDroid.Core.Model;
using XamarinDroid.Core.Repository;

namespace XamarinDroid.Android
{
    [Activity(Label = "PersonListActivity", MainLauncher = true)]
    public class PersonListActivity : Activity
    {
        private PersonRepository _personRepo;
        private ListView _listView;
        private List<Person> _personList;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PersonListView);

            _listView = FindViewById<ListView>(Resource.Id.personListView);
            _personRepo = new PersonRepository();
            _personList = _personRepo.Get().ToList();

           

            _listView.Adapter = new PersonListAdapter(_personList, this);
        }
    }
}