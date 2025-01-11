#if NET8_0_OR_GREATER
using BenchmarkDotNet.Attributes;

namespace aweXpect.Chronology.Benchmarks;

public partial class HappyCaseBenchmarks
{
	[Benchmark]
	public TimeOnly TimeOnly_aweXpect()
		=> _hour.Hours(_minute.Minutes(_second.Seconds()));

	[Benchmark]
	public TimeOnly TimeOnly_DotNet()
		=> TimeOnly.FromTimeSpan(new TimeSpan(_hour, _minute, _second));
}
#endif
