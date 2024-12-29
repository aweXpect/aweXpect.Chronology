namespace aweXpect.Chronology.Tests;

public sealed partial class DateTimeExtensions
{
	public sealed class BeforeAfterTests
	{
		[Fact]
		public async Task Before_ShouldSubtractTimeSpanFromDateTime()
		{
			DateTime expected = new(2024, 12, 24, 21, 0, 0);

			DateTime result = 3.Hours().Before(25.December(2024));

			await That(result).Should().Be(expected);
		}

		[Fact]
		public async Task After_ShouldAddTimeSpanToDateTime()
		{
			DateTime expected = new(2024, 12, 24, 21, 0, 0);

			DateTime result = 2.Days(12.Hours()).After(22.December(2024).At(9, 0));

			await That(result).Should().Be(expected);
		}
	}
}
