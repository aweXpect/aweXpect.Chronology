using BenchmarkDotNet.Attributes;

namespace aweXpect.Chronology.Benchmarks;

public partial class HappyCaseBenchmarks
{
	[Benchmark]
	public static TimeSpan TimeSpan_aweXpect()
		=> 140.Milliseconds();

	[Benchmark]
	public static TimeSpan TimeSpan_DotNet()
		=> TimeSpan.FromMilliseconds(140);
}
