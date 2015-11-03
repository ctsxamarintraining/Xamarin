using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;
using XamarinUniversity;

namespace instructor
{
	public class InstructorAdapter: BaseAdapter<Instructor>, ISectionIndexer
	{
		readonly Activity context;
		Java.Lang.Object[] headers = null;		 
		readonly List<Instructor> instructors;
		Dictionary<int, int> sectionItemMap = new Dictionary<int, int>();
		Dictionary<int, int> itemSectionMap = new Dictionary<int,int>();

		public InstructorAdapter (Activity context, List<Instructor> instructors)
		{
			this.instructors = instructors;
			this.instructors.Sort (new InstructorComparer());
			this.context = context;

			//TODO - 4 : Section Headers
			//Section Headers - Starts

			string[] sectionHeaders;

			sectionHeaders = new string[instructors.Count];
			int sectionIndex = 0;
			int listIndex = 0;

			foreach (var instructor in this.instructors) {
				if (!sectionHeaders.Contains (instructor.Specialty.ToUpper ())) {					
					sectionHeaders [sectionIndex] = instructor.Specialty [0].ToString().ToUpper();
					sectionItemMap.Add (sectionIndex, listIndex);
					sectionIndex++;
				}

				itemSectionMap.Add (listIndex, sectionIndex);

				listIndex++;
			}

			headers = new Java.Lang.Object[sectionHeaders.Length];
			for(int idx = 0 ; idx < sectionHeaders.Length; idx++) {
				headers [idx] = sectionHeaders[idx];
			}

		}

		#region implemented abstract members of BaseAdapter

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View view = convertView;

			ImageView photo = null;
			TextView name = null, speciality = null;


			//TODO - 2 view reuse

			/*view = context.LayoutInflater.Inflate (Resource.Layout.InstructorRow, parent, false);

			photo = view.FindViewById<ImageView> (Resource.Id.photoImageView);
			name = view.FindViewById<TextView> (Resource.Id.nameTextView);
			speciality = view.FindViewById<TextView> (Resource.Id.specialtyTextView);
*/



			if (view == null) {
				view = context.LayoutInflater.Inflate (Resource.Layout.InstructorRow, parent, false);
			}
			if (view.Tag == null) {
				photo = view.FindViewById<ImageView> (Resource.Id.photoImageView);
				name = view.FindViewById<TextView> (Resource.Id.nameTextView);
				speciality = view.FindViewById<TextView> (Resource.Id.specialtyTextView);

				view.Tag = new ViewHolder{ Name = name, Photo = photo, Specialty = speciality };
			} else {
				photo = ((ViewHolder)view.Tag).Photo;
				name = ((ViewHolder)view.Tag).Name;
				speciality = ((ViewHolder)view.Tag).Specialty;
			}


			Drawable drawable = ImageAssetManager.Get (context, instructors [position].ImageUrl);
			photo.SetImageDrawable (drawable);
			name.Text = instructors [position].Name;
			speciality.Text = instructors [position].Specialty;

			return view;
		}

		public override int Count {
			get {
				return instructors.Count;
			}
		}

		#endregion

		#region implemented abstract members of BaseAdapter

		public override Instructor this [int index] {
			get {
				return this.instructors [index];
			}
		}

		#endregion

		public int GetPositionForSection (int sectionIndex)
		{
			return sectionItemMap [sectionIndex];
		}

		public int GetSectionForPosition (int position)
		{
			return itemSectionMap [position];
		}

		public Java.Lang.Object[] GetSections ()
		{			
			return headers;
		}
	}

	public class InstructorComparer : IComparer<Instructor>{
		#region IComparer implementation

		public int Compare (Instructor x, Instructor y)
		{
			return x.Specialty.ToUpper().CompareTo (y.Specialty.ToUpper());
		}

		#endregion
	}
}

