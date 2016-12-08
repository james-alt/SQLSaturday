namespace SQLSaturday.Core
{
	public class HomeViewModel
		: ViewModelBase
	{
		private readonly IAppConfig appConfig;

		public HomeViewModel(IAppConfig appConfig)
		{
			this.appConfig = appConfig;
		}

		public override string Title => "SQL Saturday";

		public string Environment => appConfig.Environment.ToString();
	}
}
