using System;

namespace aweXpect.Chronology;

/// <summary>
///     Extension methods for creating <see cref="TimeSpan" />.
/// </summary>
/// <example>
///     Instead of <c>new TimeSpan(0, 5, 30)</c><br />
///     you can write <c>5.Minutes(30.Seconds)</c>.
/// </example>
public static class TimeSpanExtensions
{
	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="milliseconds" />.
	/// </summary>
	public static TimeSpan Milliseconds(this int milliseconds)
		=> TimeSpan.FromMilliseconds(milliseconds);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="milliseconds" />.
	/// </summary>
	public static TimeSpan Milliseconds(this double milliseconds)
		=> TimeSpan.FromMilliseconds(milliseconds);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="milliseconds" />
	///     and add the given <paramref name="offset" />.
	/// </summary>
	public static TimeSpan Milliseconds(this int milliseconds, TimeSpan offset)
		=> TimeSpan.FromMilliseconds(milliseconds).Add(offset);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="milliseconds" />
	///     and add the given <paramref name="offset" />.
	/// </summary>
	public static TimeSpan Milliseconds(this double milliseconds, TimeSpan offset)
		=> TimeSpan.FromMilliseconds(milliseconds).Add(offset);


	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="seconds" />.
	/// </summary>
	public static TimeSpan Seconds(this int seconds)
		=> TimeSpan.FromSeconds(seconds);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="seconds" />.
	/// </summary>
	public static TimeSpan Seconds(this double seconds)
		=> TimeSpan.FromSeconds(seconds);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="seconds" />
	///     and add the given <paramref name="offset" />.
	/// </summary>
	public static TimeSpan Seconds(this int seconds, TimeSpan offset)
		=> TimeSpan.FromSeconds(seconds).Add(offset);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="seconds" />
	///     and add the given <paramref name="offset" />.
	/// </summary>
	public static TimeSpan Seconds(this double seconds, TimeSpan offset)
		=> TimeSpan.FromSeconds(seconds).Add(offset);


	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="minutes" />.
	/// </summary>
	public static TimeSpan Minutes(this int minutes)
		=> TimeSpan.FromMinutes(minutes);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="minutes" />.
	/// </summary>
	public static TimeSpan Minutes(this double minutes)
		=> TimeSpan.FromMinutes(minutes);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="minutes" />
	///     and add the given <paramref name="offset" />.
	/// </summary>
	public static TimeSpan Minutes(this int minutes, TimeSpan offset)
		=> TimeSpan.FromMinutes(minutes).Add(offset);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="minutes" />
	///     and add the given <paramref name="offset" />.
	/// </summary>
	public static TimeSpan Minutes(this double minutes, TimeSpan offset)
		=> TimeSpan.FromMinutes(minutes).Add(offset);


	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="hours" />.
	/// </summary>
	public static TimeSpan Hours(this int hours)
		=> TimeSpan.FromHours(hours);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="hours" />.
	/// </summary>
	public static TimeSpan Hours(this double hours)
		=> TimeSpan.FromHours(hours);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="hours" />
	///     and add the given <paramref name="offset" />.
	/// </summary>
	public static TimeSpan Hours(this int hours, TimeSpan offset)
		=> TimeSpan.FromHours(hours).Add(offset);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="hours" />
	///     and add the given <paramref name="offset" />.
	/// </summary>
	public static TimeSpan Hours(this double hours, TimeSpan offset)
		=> TimeSpan.FromHours(hours).Add(offset);


	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="days" />.
	/// </summary>
	public static TimeSpan Days(this int days)
		=> TimeSpan.FromDays(days);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="days" />.
	/// </summary>
	public static TimeSpan Days(this double days)
		=> TimeSpan.FromDays(days);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="days" />
	///     and add the given <paramref name="offset" />.
	/// </summary>
	public static TimeSpan Days(this int days, TimeSpan offset)
		=> TimeSpan.FromDays(days).Add(offset);

	/// <summary>
	///     Creates a <see cref="TimeSpan" /> based on the number of <paramref name="days" />
	///     and add the given <paramref name="offset" />.
	/// </summary>
	public static TimeSpan Days(this double days, TimeSpan offset)
		=> TimeSpan.FromDays(days).Add(offset);
}
