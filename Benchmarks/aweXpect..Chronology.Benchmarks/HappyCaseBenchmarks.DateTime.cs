using BenchmarkDotNet.Attributes;

namespace aweXpect.Chronology.Benchmarks;

public partial class HappyCaseBenchmarks
{
	private readonly int _day = 5;
	private readonly int _hour = 14;
	private readonly int _minute = 2;
	private readonly int _month = 7;
	private readonly int _second = 16;
	private readonly int _year = 1964;

	[Benchmark]
	public DateTime DateTime_aweXpect()
		=> _day.July(_year).At(_hour, _minute, _second);

	[Benchmark]
	public DateTime DateTime_DotNet()
		=> new(_year, _month, _day, _hour, _minute, _second, DateTimeKind.Unspecified);
}
