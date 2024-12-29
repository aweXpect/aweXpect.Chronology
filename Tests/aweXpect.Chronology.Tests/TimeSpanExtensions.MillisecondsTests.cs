namespace aweXpect.Chronology.Tests;

public sealed partial class TimeSpanExtensions
{
	public sealed class MillisecondsTests
	{
		[Theory]
		[AutoData]
		public async Task Milliseconds_Double_ShouldReturnCorrectTimeSpan(double milliseconds)
		{
			TimeSpan expected = TimeSpan.FromMilliseconds(milliseconds);

			TimeSpan result = milliseconds.Milliseconds();

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Milliseconds_Double_WithOffset_ShouldReturnCorrectTimeSpan(
			double milliseconds, TimeSpan offset)
		{
			TimeSpan expected = TimeSpan.FromMilliseconds(milliseconds) + offset;

			TimeSpan result = milliseconds.Milliseconds(offset);

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Milliseconds_Int_ShouldReturnCorrectTimeSpan(int milliseconds)
		{
			TimeSpan expected = TimeSpan.FromMilliseconds(milliseconds);

			TimeSpan result = milliseconds.Milliseconds();

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Milliseconds_Int_WithOffset_ShouldReturnCorrectTimeSpan(int milliseconds,
			TimeSpan offset)
		{
			TimeSpan expected = TimeSpan.FromMilliseconds(milliseconds) + offset;

			TimeSpan result = milliseconds.Milliseconds(offset);

			await That(result).Should().Be(expected);
		}
	}
}
