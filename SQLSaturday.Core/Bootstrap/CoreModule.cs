using System;
using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace SQLSaturday.Core
{
	public class CoreModule
		: Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			base.Load(builder);
			LoadConfiguration(builder);
			RegisterViewModels(builder);
		}

		private void LoadConfiguration(ContainerBuilder builder)
		{
			var configLoader = new ConfigurationBootstrap();
			var config = configLoader.LoadConfiguration();

			builder.RegisterInstance(config).As<IAppConfig>().SingleInstance();
		}

		private void RegisterViewModels(ContainerBuilder builder)
		{
			builder
				.RegisterAssemblyTypes(typeof(ViewModelBase).GetTypeInfo().Assembly)
				.Where(t => t.Name.EndsWith("ViewModel", StringComparison.Ordinal))
			    .AsSelf();
		}
	}
}