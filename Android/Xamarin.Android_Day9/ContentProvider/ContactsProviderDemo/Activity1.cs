using System;

using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Provider;

namespace ContactsProviderDemo
{
    [Activity (Label = "ContactsProviderDemo", MainLauncher = true)]
    public class Activity1 : Activity
    {
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            SetContentView (Resource.Layout.Main);

            var getContactsButton = FindViewById<Button> (Resource.Id.getContactsButton);
            
            getContactsButton.Click += delegate {
                GetContacts (); };
            
           
        }
        
        void GetContacts ()
        {
            var uri = ContactsContract.Contacts.ContentUri;
            
            string[] projection = { 
				ContactsContract.Contacts.InterfaceConsts.Id, ContactsContract.Contacts.InterfaceConsts.DisplayName };
            
			var cursor = ContentResolver.Query(uri, projection, null, null, null);
            
            if (cursor.MoveToFirst ()) {
                do {
                    Console.WriteLine ("Contact ID: {0}, Contact Name: {1}", 
                                       cursor.GetString (cursor.GetColumnIndex (projection [0])),
                                       cursor.GetString (cursor.GetColumnIndex (projection [1])));
                    
                } while (cursor.MoveToNext());
            }
        }
        
     
    }
}


