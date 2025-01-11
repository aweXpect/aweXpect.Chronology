using BenchmarkDotNet.Attributes;

namespace aweXpect.Chronology.Benchmarks;

public partial class HappyCaseBenchmarks
{
	private readonly int _milliseconds = 140;

	[Benchmark]
	public TimeSpan TimeSpan_aweXpect()
		=> _milliseconds.Milliseconds();

	[Benchmark]
	public TimeSpan TimeSpan_DotNet()
		=> TimeSpan.FromMilliseconds(_milliseconds);
}
