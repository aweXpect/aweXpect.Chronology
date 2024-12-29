using System;

namespace aweXpect.Chronology;

#if NET8_0_OR_GREATER
/// <summary>
///     A builder that allows implicit cast to <see cref="TimeSpan" /> and <see cref="TimeOnly" />.
/// </summary>
#else
/// <summary>
///     A builder that allows implicit cast to <see cref="TimeSpan" />.
/// </summary>
#endif
public readonly struct TimeSpanBuilder(TimeSpan value)
{
	private readonly TimeSpan _value = value;

	/// <summary>
	///     Implicitly casts the <see cref="TimeSpanBuilder" /> to a <see cref="TimeSpan" />.
	/// </summary>
	public static implicit operator TimeSpan(TimeSpanBuilder builder)
		=> builder._value;

	/// <summary>
	///     Returns a new <see cref="TimeSpanBuilder" /> whose value is the negated value of this <paramref name="instance" />.
	/// </summary>
	public static TimeSpanBuilder operator -(TimeSpanBuilder instance)
		=> new(instance._value.Negate());

#if NET8_0_OR_GREATER
	/// <summary>
	///     Implicitly casts the <see cref="TimeSpanBuilder" /> to a <see cref="TimeOnly" />.
	/// </summary>
	public static implicit operator TimeOnly(TimeSpanBuilder builder)
		=> TimeOnly.FromTimeSpan(builder._value);
#endif

	/// <summary>
	///     Adds a <see cref="TimeSpan" /> to the <see cref="TimeSpan" />.
	/// </summary>
	public static TimeSpanBuilder operator +(TimeSpanBuilder builder, TimeSpan time)
		=> new(builder._value + time);

	/// <summary>
	///     Subtracts a <see cref="TimeSpan" /> from the <see cref="TimeSpan" />.
	/// </summary>
	public static TimeSpanBuilder operator -(TimeSpanBuilder builder, TimeSpan time)
		=> new(builder._value - time);
}
