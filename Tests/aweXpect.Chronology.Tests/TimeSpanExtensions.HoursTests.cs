namespace aweXpect.Chronology.Tests;

public sealed partial class TimeSpanExtensions
{
	public sealed class HoursTests
	{
		[Theory]
		[AutoData]
		public async Task Hours_Double_ShouldReturnCorrectTimeSpan(double hours)
		{
			TimeSpan expected = TimeSpan.FromHours(hours);

			TimeSpan result = hours.Hours();

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Hours_Double_WithOffset_ShouldReturnCorrectTimeSpan(double hours,
			TimeSpan offset)
		{
			TimeSpan expected = TimeSpan.FromHours(hours) + offset;

			TimeSpan result = hours.Hours(offset);

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Hours_Int_ShouldReturnCorrectTimeSpan(int hours)
		{
			TimeSpan expected = TimeSpan.FromHours(hours);

			TimeSpan result = hours.Hours();

			await That(result).Should().Be(expected);
		}

		[Theory]
		[AutoData]
		public async Task Hours_Int_WithOffset_ShouldReturnCorrectTimeSpan(int hours, TimeSpan offset)
		{
			TimeSpan expected = TimeSpan.FromHours(hours) + offset;

			TimeSpan result = hours.Hours(offset);

			await That(result).Should().Be(expected);
		}
	}
}
