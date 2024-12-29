namespace aweXpect.Chronology.Tests;

public sealed partial class TimeSpanExtensions
{
	public sealed class SecondsTests
	{
		[Theory]
		[AutoData]
		public async Task Seconds_Double_ShouldReturnCorrectTimeSpan(double seconds)
		{
			TimeSpan expected = TimeSpan.FromSeconds(seconds);

			TimeSpan result = seconds.Seconds();

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Seconds_Double_WithOffset_ShouldReturnCorrectTimeSpan(double seconds,
			TimeSpan offset)
		{
			TimeSpan expected = TimeSpan.FromSeconds(seconds) + offset;

			TimeSpan result = seconds.Seconds(offset);

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Seconds_Int_ShouldReturnCorrectTimeSpan(int seconds)
		{
			TimeSpan expected = TimeSpan.FromSeconds(seconds);

			TimeSpan result = seconds.Seconds();

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Seconds_Int_WithOffset_ShouldReturnCorrectTimeSpan(int seconds,
			TimeSpan offset)
		{
			TimeSpan expected = TimeSpan.FromSeconds(seconds) + offset;

			TimeSpan result = seconds.Seconds(offset);

			await That(result).Should().Be(expected);
		}
	}
}
