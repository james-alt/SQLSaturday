using NUnit.Framework;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using SQLSaturday.Core;
using FluentAssertions;

namespace SQLSaturday.Tests
{
	[TestFixture]
	public class HomeViewModelTests
	{
		private IFixture fixture;
		private HomeViewModel target;

		[SetUp]
		public void SetUp()
		{
			fixture = new Fixture()
				.Customize(new AutoConfiguredMoqCustomization());
		}

		[TearDown]
		public void TearDown()
		{
			fixture = null;
			target = null;
		}

		[Test]
		public void ConstructorCreatesSuccessfully()
		{
			target = CreateTarget();

			target.Should().NotBeNull();
		}

		[Test]
		public void TitleIsSet()
		{
			target = CreateTarget();

			target.Title.Should().Be("SQL Saturday");
		}


		private HomeViewModel CreateTarget()
		{
			return fixture
				.Create<HomeViewModel>();
		}
	}
}
