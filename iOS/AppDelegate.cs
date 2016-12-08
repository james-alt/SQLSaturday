using Foundation;
using UIKit;

namespace SQLSaturday.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			SetupAppearance();
			Initialize();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}

		private void Initialize()
		{
			global::Xamarin.Forms.Forms.Init();
		}

		private void SetupAppearance()
		{
			var tint = UIColor.FromRGB(139, 195, 74);

			UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(250, 250, 250);
			UINavigationBar.Appearance.TintColor = tint;

			UIBarButtonItem.Appearance.TintColor = tint;
			UITabBar.Appearance.TintColor = tint;
			UISwitch.Appearance.OnTintColor = tint;
			UIAlertView.Appearance.TintColor = tint;

			UIView.AppearanceWhenContainedIn(typeof(UIAlertController)).TintColor = tint;
			UIView.AppearanceWhenContainedIn(typeof(UIActivityViewController)).TintColor = tint;
		}
	}
}
