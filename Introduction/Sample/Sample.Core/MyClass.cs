using System;
using System.Net;

namespace Sample.Core
{
	public class MyClass
	{
		public int Id {
			get;
			set;
		}
		public MyClass ()
		{
			System.Net.HttpWebRequest request = (HttpWebRequest)WebRequest.Create ("");

			System.Net.Http.HttpClient client = new System.Net.Http.HttpClient ();
		}
	}
}

