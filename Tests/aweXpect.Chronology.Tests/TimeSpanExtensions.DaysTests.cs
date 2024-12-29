namespace aweXpect.Chronology.Tests;

public sealed partial class TimeSpanExtensions
{
	public sealed class DaysTests
	{
		[Theory]
		[AutoData]
		public async Task Days_Double_ShouldReturnCorrectTimeSpan(double days)
		{
			TimeSpan expected = TimeSpan.FromDays(days);

			TimeSpan result = days.Days();

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Days_Double_WithOffset_ShouldReturnCorrectTimeSpan(double days,
			TimeSpan offset)
		{
			TimeSpan expected = TimeSpan.FromDays(days) + offset;

			TimeSpan result = days.Days(offset);

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Days_Int_ShouldReturnCorrectTimeSpan(int days)
		{
			TimeSpan expected = days.Days();

			TimeSpan result = days.Days();

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Days_Int_WithOffset_ShouldReturnCorrectTimeSpan(int days, TimeSpan offset)
		{
			TimeSpan expected = days.Days() + offset;

			TimeSpan result = days.Days(offset);

			await That(result).Should().Be(expected);
		}
	}
}
