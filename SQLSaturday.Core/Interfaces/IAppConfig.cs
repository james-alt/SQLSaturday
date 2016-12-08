using System;
namespace SQLSaturday.Core
{
	public interface IAppConfig
	{
		AppEnvironment Environment { get; }
	}
}
