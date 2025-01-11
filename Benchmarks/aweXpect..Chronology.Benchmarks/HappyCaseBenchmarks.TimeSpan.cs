using BenchmarkDotNet.Attributes;

namespace aweXpect.Chronology.Benchmarks;

public partial class HappyCaseBenchmarks
{
	[Benchmark]
	public TimeSpan TimeSpan_aweXpect()
		=> 140.Milliseconds();

	[Benchmark]
	public TimeSpan TimeSpan_DotNet()
		=> TimeSpan.FromMilliseconds(140);
}
