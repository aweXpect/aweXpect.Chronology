namespace aweXpect.Chronology.Tests;

public sealed partial class TimeSpanExtensions
{
	public sealed class MinutesTests
	{
		[Theory]
		[AutoData]
		public async Task Minutes_Double_ShouldReturnCorrectTimeSpan(double minutes)
		{
			TimeSpan expected = TimeSpan.FromMinutes(minutes);

			TimeSpan result = minutes.Minutes();

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Minutes_Double_WithOffset_ShouldReturnCorrectTimeSpan(double minutes,
			TimeSpan offset)
		{
			TimeSpan expected = TimeSpan.FromMinutes(minutes) + offset;

			TimeSpan result = minutes.Minutes(offset);

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Minutes_Int_ShouldReturnCorrectTimeSpan(int minutes)
		{
			TimeSpan expected = TimeSpan.FromMinutes(minutes);

			TimeSpan result = minutes.Minutes();

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Minutes_Int_WithOffset_ShouldReturnCorrectTimeSpan(int minutes,
			TimeSpan offset)
		{
			TimeSpan expected = TimeSpan.FromMinutes(minutes) + offset;

			TimeSpan result = minutes.Minutes(offset);

			await That(result).Should().Be(expected);
		}
	}
}
