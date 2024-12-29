namespace aweXpect.Chronology.Tests;

public class TimeSpanExtensionsTests
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
