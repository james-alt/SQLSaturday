using System;
using Autofac;
using SQLSaturday.Core;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SQLSaturday
{
	public partial class App : Application
	{
		public static App Instance;
		public static IContainer Container { get; set; }
		public static Func<ContainerBuilder> CreateContainerBuilder { get; set; }

		public App()
		{
			Instance = this;
			InitializeComponent();

			InitializeContainer();
			StartApp();
		}

		private void InitializeContainer()
		{
			if (CreateContainerBuilder == null)
			{
				CreateContainerBuilder = () => new ContainerBuilder();
			}

			var builder = CreateContainerBuilder();
			builder.RegisterModule(new CoreModule());
			Container = builder.Build();
		}

		private void StartApp()
		{
			switch (Device.OS)
			{
				case TargetPlatform.Android:
					MainPage = new NavigationPage(new HomePage());
					break;
				case TargetPlatform.iOS:
					MainPage = new NavigationPage(new HomePage());
					break;
				default:
					throw new NotImplementedException();
			}
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
