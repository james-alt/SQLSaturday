using System;
namespace SQLSaturday.Core
{
	public interface IViewModel
	{
		bool IsBusy { get; set; }
		bool IsLoaded { get; set; }
		string Title { get; }
		string Icon { get; }
	}
}
