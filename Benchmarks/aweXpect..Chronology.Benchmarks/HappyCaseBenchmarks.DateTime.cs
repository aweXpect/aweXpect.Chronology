using BenchmarkDotNet.Attributes;

namespace aweXpect.Chronology.Benchmarks;

public partial class HappyCaseBenchmarks
{
	[Benchmark]
	public DateTime DateTime_aweXpect()
		=> _day.July(_year).At(_hour, _minute, _second);

	[Benchmark]
	public DateTime DateTime_DotNet()
		=> new(_year, _month, _day, _hour, _minute, _second, DateTimeKind.Unspecified);
}
