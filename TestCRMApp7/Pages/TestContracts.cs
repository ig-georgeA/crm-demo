using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp7.Pages;

namespace TestCRMApp7
{
	[Collection("CRMApp7")]
	public class TestContracts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Contracts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
