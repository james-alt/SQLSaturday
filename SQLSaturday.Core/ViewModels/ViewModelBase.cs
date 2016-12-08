namespace SQLSaturday.Core
{
	public class ViewModelBase
		: IViewModel
	{
		public virtual string Title { get; set; }
		public virtual string Icon { get; set; }
		public bool IsBusy { get; set; }
		public bool IsLoaded { get; set; }
	}
}