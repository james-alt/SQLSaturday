using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace SQLSaturday.Core
{
	public class ConfigurationBootstrap
	{
		public AppConfig LoadConfiguration()
		{
			var assembly = GetType().GetTypeInfo().Assembly;
			var stream =
				assembly.GetManifestResourceStream("SQLSaturday.Core.Configurations.Configuration.json");
			var text = "";

			using (var reader = new StreamReader(stream))
			{
				text = reader.ReadToEnd();
			}

			var config = JsonConvert.DeserializeObject<AppConfig>(text);
			return config;
		}
	}
}
