using System.Threading.Tasks;

namespace aweXpect.Chronology.Api.Tests;

/// <summary>
///     Whenever a test fails, this means that the public API surface changed.
///     If the change was intentional, execute the <see cref="ApiAcceptance.AcceptApiChanges()" /> test to take over the
///     current public API surface. The changes will become part of the pull request and will be reviewed accordingly.
/// </summary>
public sealed class ApiApprovalTests
{
	public static TheoryData<string> TargetFrameworksTheoryData
		=> new(Helper.GetTargetFrameworks());

	[Theory]
	[MemberData(nameof(TargetFrameworksTheoryData))]
	public async Task VerifyPublicApiForAweXpectChronology(string framework)
	{
		const string assemblyName = "aweXpect.Chronology";

		string publicApi = Helper.CreatePublicApi(framework, assemblyName);
		string expectedApi = Helper.GetExpectedApi(framework, assemblyName);

		await Expect.That(publicApi).Should().Be(expectedApi);
	}
}
