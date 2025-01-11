#if NET8_0_OR_GREATER
using BenchmarkDotNet.Attributes;

namespace aweXpect.Chronology.Benchmarks;

public partial class HappyCaseBenchmarks
{
	[Benchmark]
	public DateOnly DateOnly_aweXpect()
		=> _day.July(_year);

	[Benchmark]
	public DateOnly DateOnly_DotNet()
		=> new(_year, _month, _day);
}
#endif
