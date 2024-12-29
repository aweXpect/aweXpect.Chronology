namespace aweXpect.Chronology.Tests;

public sealed partial class DateTimeExtensions
{
	public sealed class AtTests
	{
		[Fact]
		public async Task At_WithTimeSpan_ShouldAddTime()
		{
			DateTime expected = new(2024, 12, 24, 18, 30, 15);

			DateTime result = 24.December(2024).At(18.Hours(30.Minutes(15.Seconds())));

			await That(result).Should().Be(expected);
		}

		[Fact]
		public async Task At_WithHourAndMinutes_ShouldAddTime()
		{
			DateTime expected = new(2024, 12, 24, 18, 30, 00);

			DateTime result = 24.December(2024).At(18, 30);

			await That(result).Should().Be(expected);
		}

		[Fact]
		public async Task At_WithHourMinutesAndSeconds_ShouldAddTime()
		{
			DateTime expected = new(2024, 12, 24, 18, 30, 59);

			DateTime result = 24.December(2024).At(18, 30, 59);

			await That(result).Should().Be(expected);
		}

		[Fact]
		public async Task At_WithHourMinutesSecondsAndMilliseconds_ShouldAddTime()
		{
			DateTime expected = new(2024, 12, 24, 18, 30, 0, 150, DateTimeKind.Unspecified);

			DateTime result = 24.December(2024).At(18, 30, 0, 150);

			await That(result).Should().Be(expected);
		}
	}
}
