using BenchmarkDotNet.Attributes;

namespace aweXpect.Chronology.Benchmarks;

public partial class HappyCaseBenchmarks
{
	[Benchmark]
	public TimeSpan TimeSpan_aweXpect()
		=> _second.Seconds();

	[Benchmark]
	public TimeSpan TimeSpan_DotNet()
		=> TimeSpan.FromSeconds(_second);
}
