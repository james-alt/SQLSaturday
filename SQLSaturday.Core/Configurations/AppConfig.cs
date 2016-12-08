using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SQLSaturday.Core
{
	public class AppConfig
		: IAppConfig
	{
		[JsonConverter(typeof(StringEnumConverter))]
		public AppEnvironment Environment { get; set; }
	}
}
