using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp7.Pages;

namespace TestCRMApp7
{
	[Collection("CRMApp7")]
	public class TestAccount_Sample
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbTabsModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbAccordionModule),
				typeof(IgbExpansionPanelModule),
				typeof(IgbAvatarModule),
				typeof(IgbCheckboxModule),
				typeof(IgbListModule),
				typeof(IgbChipModule));
			var componentUnderTest = ctx.RenderComponent<Account_Sample>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
