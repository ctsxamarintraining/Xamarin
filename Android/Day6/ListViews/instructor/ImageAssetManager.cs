using System.Collections.Generic;
using Android.Graphics.Drawables;
using Android.App;
using Android.Content;

namespace XamarinUniversity
{
	public static class ImageAssetManager
	{
		static Dictionary<string, Drawable> cache = new Dictionary<string, Drawable>();

		public static Drawable Get(Context context, string url)
		{
			//return Drawable.CreateFromStream(context.Assets.Open(url), null);

			//TODO - 1: Cache drawables

			if (!cache.ContainsKey(url))
			{					
				var drawable =Drawable.CreateFromStream(context.Assets.Open(url), null);
				cache.Add(url, drawable);
			}


			return cache[url];

		}
	}
}