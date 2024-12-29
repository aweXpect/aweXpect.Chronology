namespace aweXpect.Chronology.Tests;

public class DateTimeExtensionsTests
{
	[Fact]
	public async Task January_ShouldReturnCorrectDateTime()
	{
		DateTime expected = new(2024, 01, 29);

		DateTime result = 29.January(2024);

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task February_ShouldReturnCorrectDateTime()
	{
		DateTime expected = new(2024, 02, 28);

		DateTime result = 28.February(2024);

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task March_ShouldReturnCorrectDateTime()
	{
		DateTime expected = new(2024, 03, 27);

		DateTime result = 27.March(2024);

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task April_ShouldReturnCorrectDateTime()
	{
		DateTime expected = new(2024, 04, 26);

		DateTime result = 26.April(2024);

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task May_ShouldReturnCorrectDateTime()
	{
		DateTime expected = new(2024, 05, 25);

		DateTime result = 25.May(2024);

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task June_ShouldReturnCorrectDateTime()
	{
		DateTime expected = new(2024, 06, 24);

		DateTime result = 24.June(2024);

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task July_ShouldReturnCorrectDateTime()
	{
		DateTime expected = new(2024, 07, 23);

		DateTime result = 23.July(2024);

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task August_ShouldReturnCorrectDateTime()
	{
		DateTime expected = new(2024, 08, 22);

		DateTime result = 22.August(2024);

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task September_ShouldReturnCorrectDateTime()
	{
		DateTime expected = new(2024, 09, 21);

		DateTime result = 21.September(2024);

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task October_ShouldReturnCorrectDateTime()
	{
		DateTime expected = new(2024, 10, 20);

		DateTime result = 20.October(2024);

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task November_ShouldReturnCorrectDateTime()
	{
		DateTime expected = new(2024, 11, 19);

		DateTime result = 19.November(2024);

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task December_ShouldReturnCorrectDateTime()
	{
		DateTime expected = new(2024, 12, 18);

		DateTime result = 18.December(2024);

		await That(result).Should().Be(expected);
	}


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


	[Fact]
	public async Task AsUtc_ShouldSetKindToUtc()
	{
		DateTime result = 24.December(2024).At(18, 30).AsUtc();

		await That(result).Should().HaveKind(DateTimeKind.Utc);
	}

	[Fact]
	public async Task AsLocal_ShouldSetKindToLocal()
	{
		DateTime result = 24.December(2024).At(18, 30).AsLocal();

		await That(result).Should().HaveKind(DateTimeKind.Local);
	}


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
