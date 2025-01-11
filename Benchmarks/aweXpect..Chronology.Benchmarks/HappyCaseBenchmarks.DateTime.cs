using BenchmarkDotNet.Attributes;

namespace aweXpect.Chronology.Benchmarks;

public partial class HappyCaseBenchmarks
{
	[Benchmark]
	public DateTime DateTime_aweXpect()
		=> 5.July(1964).At(14, 0, 16);

	[Benchmark]
	public DateTime DateTime_DotNet()
		=> new(1964, 7, 5, 14, 0, 16);
}
