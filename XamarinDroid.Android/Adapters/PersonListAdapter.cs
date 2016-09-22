using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using XamarinDroid.Core.Model;

namespace XamarinDroid.Android.Adapters
{
    public class PersonListAdapter : BaseAdapter<Person>
    {

        private List<Person> _persons;
        private Activity _context;

        public PersonListAdapter(List<Person> persons, Activity context)
        {
            _persons = persons;
            _context = context;
        }

        public override long GetItemId(int position)
        {
            return _persons[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var person = _persons[position];
            // Create new item view if no resuable view is provided
            if (convertView == null)
            {
                convertView = _context.LayoutInflater.Inflate(global::Android.Resource.Layout.SimpleListItem1, null);
            }

            var firstNameLbl = convertView.FindViewById<TextView>(global::Android.Resource.Id.Text1);
                firstNameLbl.Text = $"{person.Firstname} {person.Lastname}";
            
            
            return convertView;
        }

        public override int Count { get { return _persons.Count; } }

        public override Person this[int position]
        {
            get { return _persons[position]; }
        }
    }
}