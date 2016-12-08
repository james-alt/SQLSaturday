using System.Reflection;
using FluentAssertions;
using NUnit.Framework;
using SQLSaturday.Core;

namespace SQLSaturday.Tests
{
	[TestFixture]
	public class ConfigurationBootstrapTests
	{
		[Test]
		public void LoadConfigurationsReturnsAppConfig()
		{	
			var configLoader = new ConfigurationBootstrap();
			var config = configLoader.LoadConfiguration();
			config.Should().NotBeNull("the configuration file was loaded from the assembly");
		}
	}
}