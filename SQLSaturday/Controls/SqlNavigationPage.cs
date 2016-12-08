using Xamarin.Forms;

namespace SQLSaturday
{
	public class SqlNavigationPage 
		: NavigationPage
	{
		public SqlNavigationPage(Page root)
			: base(root)
		{
			Init();
			Title = root.Title;
			Icon = root.Icon;
		}

		public SqlNavigationPage()
		{
			Init();
		}

		private void Init()
		{
			if (Device.OS == TargetPlatform.iOS)
			{
				BarBackgroundColor = Color.FromHex("FAFAFA");
			}
			else
			{
				BarBackgroundColor = (Color)Application.Current.Resources["Primary"];
				BarTextColor = (Color)Application.Current.Resources["NavigationText"];
			}
		}
	}
}