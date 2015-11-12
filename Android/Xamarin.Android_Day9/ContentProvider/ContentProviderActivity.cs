/*
 * Copyright (C) 2007 The Android Open Source Project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MonoDroid.ContentProviderDemo
{
    [Activity(Label = "MonoDroid.ContentProviderDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class ContentProviderActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

			Button button = FindViewById<Button> (Resource.Id.MyButton);

			button.Text = "Set Content";
			button.Click += delegate {
				InsertValues ();
			};
            
        }

       

        void InsertValues()
        {
            ContentValues values = new ContentValues();

            // Don't set _ID if you want to auto increment it.
            //values.Put(LocationContentProvider._ID, 1); 
            values.Put(LocationContentProvider.NAME, "Brüel & Kjær");
            values.Put(LocationContentProvider.LATITUTDE, 55.816932);
            values.Put(LocationContentProvider.LONGITUDE, 12.532697);
            Android.Net.Uri uri = ContentResolver.Insert(LocationContentProvider.CONTENT_URI, values);
            System.Diagnostics.Debug.WriteLine("Insert: " + uri.ToString());

            values.Clear();

            //values.Put(LocationContentProvider._ID, 2);
            values.Put(LocationContentProvider.NAME, "Technical University of Denmark");
            values.Put(LocationContentProvider.LATITUTDE, 55.786323);
            values.Put(LocationContentProvider.LONGITUDE, 12.524135);
            uri = ContentResolver.Insert(LocationContentProvider.CONTENT_URI, values);
            System.Diagnostics.Debug.WriteLine("Insert: " + uri.ToString());
        }
    }
}

