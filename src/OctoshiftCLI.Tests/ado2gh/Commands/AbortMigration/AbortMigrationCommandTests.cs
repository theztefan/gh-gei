using FluentAssertions;
using OctoshiftCLI.AdoToGithub.Commands.AbortMigration;
using Xunit;

namespace OctoshiftCLI.Tests.AdoToGithub.Commands.AbortMigration;

public class AbortMigrationCommandTests
{
    [Fact]
    public void Should_Have_Options()
    {
        var command = new AbortMigrationCommand();
        command.Should().NotBeNull();
        command.Name.Should().Be("abort-migration");
        command.Options.Count.Should().Be(3);

        TestHelpers.VerifyCommandOption(command.Options, "migration-id", true);
        TestHelpers.VerifyCommandOption(command.Options, "github-pat", false);
        TestHelpers.VerifyCommandOption(command.Options, "verbose", false);
    }
}
