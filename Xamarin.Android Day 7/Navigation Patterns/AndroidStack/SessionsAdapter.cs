using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Views;
using Android.Widget;
using Evolve.Core;

namespace AndroidStack 
{
	/// <summary>
	/// Demo 5: Add an index
	/// </summary>		
	public class SessionsAdapter: BaseAdapter<Session> 
	{
		private List<Session> data;
		private Activity context;
		
		public SessionsAdapter(Activity activity, IEnumerable<Session> sessions) 
		{
			data = (from s in sessions orderby s.Title select s).ToList ();
			context = activity;
		}


		public override long GetItemId(int position)
		{
			return position;
		}
		
		public override Session this[int position]
		{
			get { return data[position]; }
		}
		
		public override int Count
		{
			get { return data.Count; }
		}

		/// <summary>
		/// CUSTOM ROW STYLE !!
		/// </summary>
		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var view = convertView;
			if (view == null)
			{
				view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
			}
			
			var speaker = data[position];
			

			var speakerNameView = view.FindViewById<TextView>(Android.Resource.Id.Text1);
			speakerNameView.Text = speaker.Title;

			return view;
		}
	}
}

