using System;

namespace Sample.Shared
{
	public class MyClass
	{
		public MyClass ()
		{
			string platform = string.Empty;

			#if Droid
			platform = "Android";
			#else
			platform = "iOS";
			#endif
		}
	}
}

