using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Autofac;
using FluentAssertions;
using FluentAssertions.Autofac;
using NUnit.Framework;
using SQLSaturday.Core;

namespace SQLSaturday.Tests
{
	[TestFixture]
	public class CoreModuleTests
	{
		private ContainerBuilder builder;

		[SetUp]
		public void SetUp()
		{
			builder = new ContainerBuilder();
		}

		[TearDown]
		public void TearDown()
		{
			builder = null;
		}

		[Test]
		public void ConstructorRegistersViewModels()
		{
			builder.RegisterModule(new CoreModule());
			var container = builder.Build();

			var expectedType = typeof(ViewModelBase);
			var found = 0;

			var assembly = Assembly.Load("SQLSaturday.Core");
			var types = assembly
				.GetTypes()
				.Where(
					t => expectedType.IsAssignableFrom(t)
						&& t.IsClass
						&& t != expectedType);

			foreach (var type in types)
			{
				Debug.WriteLine($"{type}");
				container.Should().Have().Registered(type);
				found++;
			}

			found.Should().NotBe(0);
		}

		[Test]
		public void ConstructorRegistersAppConfig()
		{
			builder.RegisterModule(new CoreModule());
			var container = builder.Build();

			var config = container.Resolve<IAppConfig>();
			config.Should().NotBeNull();
		}
	}
}
