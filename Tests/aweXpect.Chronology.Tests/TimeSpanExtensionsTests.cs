using aweXpect.Extensions;

namespace aweXpect.Chronology.Tests;

public class TimeSpanExtensionsTests
{
	[Theory]
	[AutoData]
	public async Task Double_Days_ShouldReturnCorrectTimeSpan(double days)
	{
		TimeSpan expected = TimeSpan.FromDays(days);

		TimeSpan result = ChronologyExtensions.Days(days);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Double_Days_WithOffset_ShouldReturnCorrectTimeSpan(double days,
		TimeSpan offset)
	{
		TimeSpan expected = TimeSpan.FromDays(days) + offset;

		TimeSpan result = ChronologyExtensions.Days(days, offset);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Double_Hours_ShouldReturnCorrectTimeSpan(double hours)
	{
		TimeSpan expected = TimeSpan.FromHours(hours);

		TimeSpan result = ChronologyExtensions.Hours(hours);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Double_Hours_WithOffset_ShouldReturnCorrectTimeSpan(double hours,
		TimeSpan offset)
	{
		TimeSpan expected = TimeSpan.FromHours(hours) + offset;

		TimeSpan result = ChronologyExtensions.Hours(hours, offset);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Double_Milliseconds_ShouldReturnCorrectTimeSpan(double milliseconds)
	{
		TimeSpan expected = TimeSpan.FromMilliseconds(milliseconds);

		TimeSpan result = ChronologyExtensions.Milliseconds(milliseconds);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Double_Milliseconds_WithOffset_ShouldReturnCorrectTimeSpan(
		double milliseconds, TimeSpan offset)
	{
		TimeSpan expected = TimeSpan.FromMilliseconds(milliseconds) + offset;

		TimeSpan result = ChronologyExtensions.Milliseconds(milliseconds, offset);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Double_Minutes_ShouldReturnCorrectTimeSpan(double minutes)
	{
		TimeSpan expected = TimeSpan.FromMinutes(minutes);

		TimeSpan result = ChronologyExtensions.Minutes(minutes);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Double_Minutes_WithOffset_ShouldReturnCorrectTimeSpan(double minutes,
		TimeSpan offset)
	{
		TimeSpan expected = TimeSpan.FromMinutes(minutes) + offset;

		TimeSpan result = ChronologyExtensions.Minutes(minutes, offset);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Double_Seconds_ShouldReturnCorrectTimeSpan(double seconds)
	{
		TimeSpan expected = TimeSpan.FromSeconds(seconds);

		TimeSpan result = ChronologyExtensions.Seconds(seconds);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Double_Seconds_WithOffset_ShouldReturnCorrectTimeSpan(double seconds,
		TimeSpan offset)
	{
		TimeSpan expected = TimeSpan.FromSeconds(seconds) + offset;

		TimeSpan result = ChronologyExtensions.Seconds(seconds, offset);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Int_Days_ShouldReturnCorrectTimeSpan(int days)
	{
		TimeSpan expected = TimeSpan.FromDays(days);

		TimeSpan result = ChronologyExtensions.Days(days);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Int_Days_WithOffset_ShouldReturnCorrectTimeSpan(int days, TimeSpan offset)
	{
		TimeSpan expected = TimeSpan.FromDays(days) + offset;

		TimeSpan result = ChronologyExtensions.Days(days, offset);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Int_Hours_ShouldReturnCorrectTimeSpan(int hours)
	{
		TimeSpan expected = TimeSpan.FromHours(hours);

		TimeSpan result = ChronologyExtensions.Hours(hours);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Int_Hours_WithOffset_ShouldReturnCorrectTimeSpan(int hours, TimeSpan offset)
	{
		TimeSpan expected = TimeSpan.FromHours(hours) + offset;

		TimeSpan result = ChronologyExtensions.Hours(hours, offset);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Int_Milliseconds_ShouldReturnCorrectTimeSpan(int milliseconds)
	{
		TimeSpan expected = TimeSpan.FromMilliseconds(milliseconds);

		TimeSpan result = ChronologyExtensions.Milliseconds(milliseconds);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Int_Milliseconds_WithOffset_ShouldReturnCorrectTimeSpan(int milliseconds,
		TimeSpan offset)
	{
		TimeSpan expected = TimeSpan.FromMilliseconds(milliseconds) + offset;

		TimeSpan result = ChronologyExtensions.Milliseconds(milliseconds, offset);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Int_Minutes_ShouldReturnCorrectTimeSpan(int minutes)
	{
		TimeSpan expected = TimeSpan.FromMinutes(minutes);

		TimeSpan result = ChronologyExtensions.Minutes(minutes);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Int_Minutes_WithOffset_ShouldReturnCorrectTimeSpan(int minutes,
		TimeSpan offset)
	{
		TimeSpan expected = TimeSpan.FromMinutes(minutes) + offset;

		TimeSpan result = ChronologyExtensions.Minutes(minutes, offset);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Int_Seconds_ShouldReturnCorrectTimeSpan(int seconds)
	{
		TimeSpan expected = TimeSpan.FromSeconds(seconds);

		TimeSpan result = ChronologyExtensions.Seconds(seconds);

		await That(result).Should().Be(expected);
	}

	[Theory]
	[AutoData]
	public async Task Int_Seconds_WithOffset_ShouldReturnCorrectTimeSpan(int seconds,
		TimeSpan offset)
	{
		TimeSpan expected = TimeSpan.FromSeconds(seconds) + offset;

		TimeSpan result = ChronologyExtensions.Seconds(seconds, offset);

		await That(result).Should().Be(expected);
	}
}
