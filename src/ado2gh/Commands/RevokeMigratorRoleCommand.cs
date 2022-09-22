using System;
using System.CommandLine.NamingConventionBinder;
using OctoshiftCLI.Commands;
using OctoshiftCLI.Contracts;
using OctoshiftCLI.Extensions;

namespace OctoshiftCLI.AdoToGithub.Commands;

public sealed class RevokeMigratorRoleCommand : RevokeMigratorRoleCommandBase
{
    public RevokeMigratorRoleCommand(OctoLogger log, ITargetGithubApiFactory githubApiFactory) : base(log, githubApiFactory)
    {
        Description += Environment.NewLine;
        Description += $"Note: Expects GH_PAT env variable or --{GithubPat.GetLogFriendlyName()} option to be set.";

        AddOptions();
        Handler = CommandHandler.Create<RevokeMigratorRoleArgs>(Handle);
    }
}
