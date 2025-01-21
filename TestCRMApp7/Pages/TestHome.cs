using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp7.Pages;
using CRMApp7.ECommerce;
using CRMApp7.Northwind;
using CRMApp7.CRMApp;

namespace TestCRMApp7
{
	[Collection("CRMApp7")]
	public class TestHome
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCategoryChartModule),
				typeof(IgbGridModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbChipModule));
			ctx.Services.AddScoped<IECommerceService>(sp => new MockECommerceService());
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			ctx.Services.AddScoped<ICRMAppService>(sp => new MockCRMAppService());
			var componentUnderTest = ctx.RenderComponent<Home>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
