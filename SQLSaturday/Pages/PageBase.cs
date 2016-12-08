using Autofac;
using SQLSaturday.Core;
using Xamarin.Forms;

namespace SQLSaturday
{
	public abstract class PageBase<T> 
		: ContentPage
		where T : IViewModel
	{
		private readonly T viewModel;
		public T ViewModel => viewModel;
		protected string PageName { get; }

		public PageBase()
		{
			using (var scope = App.Container.BeginLifetimeScope())
			{
				viewModel = App.Container.Resolve<T>();
				BindingContext = viewModel;
			}
			PageName = ViewModel.Title;
		}
	}
}