namespace aweXpect.Chronology.Tests;

public sealed class TimeSpanBuilderTests
{
	[Fact]
	public async Task MinusOperator_ShouldSubtractTimeSpan()
	{
		TimeSpanBuilder expected = 2.Hours();
		TimeSpanBuilder builder = new(3.Hours());

		TimeSpan result = builder - 1.Hours();

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task PlusOperator_ShouldAddTimeSpan()
	{
		TimeSpanBuilder expected = 4.Hours();
		TimeSpanBuilder builder = new(3.Hours());

		TimeSpan result = builder + 1.Hours();

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task UnaryMinusOperator_ShouldReturnNegatedValue()
	{
		TimeSpan expected = TimeSpan.FromHours(-1);
		
		TimeSpan result = -1.Hours();

		await That(result).Should().Be(expected);
	}

	[Fact]
	public async Task ImplicitOperator_ShouldConvertToTimeSpan()
	{
		TimeSpan expected = new(2, 3, 4);
		TimeSpanBuilder builder = new(2.Hours(3.Minutes(4.Seconds())));

		TimeSpan result = builder;

		await That(result).Should().Be(expected);
	}

#if NET8_0_OR_GREATER
	[Fact]
	public async Task ImplicitOperator_ShouldConvertToTimeOnly()
	{
		TimeOnly expected = new(2, 3, 4);
		TimeSpanBuilder builder = new(2.Hours(3.Minutes(4.Seconds())));

		TimeOnly result = builder;

		await That(result).Should().Be(expected);
	}
#endif
}
