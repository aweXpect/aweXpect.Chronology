using BenchmarkDotNet.Attributes;

namespace aweXpect.Chronology.Benchmarks;

public partial class HappyCaseBenchmarks
{
	[Benchmark]
	public DateTimeOffset DateTimeOffset_aweXpect()
		=> _day.July(_year).At(_hour, _minute, _second).WithOffset(2.Hours());

	[Benchmark]
	public DateTimeOffset DateTimeOffset_DotNet()
		=> new(_year, _month, _day, _hour, _minute, _second, TimeSpan.FromHours(2));
}
