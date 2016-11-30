using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Syncfusion.SfKanban.XForms.iOS;
using UIKit;

namespace GettingStartedKanban.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			new SfKanbanRenderer();

			return base.FinishedLaunching(app, options);

		}
	}
}

