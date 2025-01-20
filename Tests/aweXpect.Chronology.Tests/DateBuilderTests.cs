﻿namespace aweXpect.Chronology.Tests;

public sealed class DateBuilderTests
{
	[Fact]
	public async Task MinusOperator_ShouldSubtractTimeSpan()
	{
		DateBuilder expected = 20.March(2024);
		DateBuilder builder = new(23.March(2024));

		DateTime result = builder - 3.Days();

		await That(result).Is(expected);
	}

	[Fact]
	public async Task PlusOperator_ShouldAddTimeSpan()
	{
		DateBuilder expected = 26.March(2024);
		DateBuilder builder = new(23.March(2024));

		DateTime result = builder + 3.Days();

		await That(result).Is(expected);
	}

	[Fact]
	public async Task ImplicitOperator_ShouldConvertToDateTime()
	{
		DateTime expected = new(2024, 03, 23);
		DateBuilder builder = new(23.March(2024));

		DateTime result = builder;

		await That(result).Is(expected);
	}

#if NET8_0_OR_GREATER
	[Fact]
	public async Task ImplicitOperator_ShouldConvertToDateOnly()
	{
		DateOnly expected = new(2024, 03, 23);
		DateBuilder builder = new(23.March(2024));

		DateOnly result = builder;

		await That(result).Is(expected);
	}
#endif
}
