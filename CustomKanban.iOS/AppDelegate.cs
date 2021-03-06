﻿using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using Syncfusion.SfKanban.XForms.iOS;
using UIKit;
using Wibci.Xamarin.Forms.Converters;

namespace CustomKanban.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            ImageCircleRenderer.Init();

            //HACK: get iOS to recognize library
            ByteArrayToImageSourceConverter cn = new ByteArrayToImageSourceConverter();

            ImageCircleRenderer.Init();

            global::Xamarin.Forms.Forms.Init();


            LoadApplication(new App());

            new SfKanbanRenderer();

            return base.FinishedLaunching(app, options);
        }
    }
}