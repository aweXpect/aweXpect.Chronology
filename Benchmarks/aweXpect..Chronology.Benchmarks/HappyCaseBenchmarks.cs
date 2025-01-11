using BenchmarkDotNet.Attributes;

namespace aweXpect.Chronology.Benchmarks;

[MarkdownExporterAttribute.GitHub]
[MemoryDiagnoser]
public partial class HappyCaseBenchmarks
{
	private readonly int _day = 5;
	private readonly int _hour = 14;
	private readonly int _minute = 2;
	private readonly int _month = 7;
	private readonly int _second = 16;
	private readonly int _year = 1964;
}
