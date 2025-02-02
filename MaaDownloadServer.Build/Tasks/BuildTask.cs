﻿using Cake.Common;
using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Build;
using Cake.Frosting;

namespace MaaDownloadServer.Build.Tasks;

[TaskName("Build")]
[IsDependentOn(typeof(CleanTask))]
public sealed class BuildTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.DotNetBuild("../MaaDownloadServer/MaaDownloadServer.csproj", new DotNetBuildSettings
        {
            Configuration = context.MsBuildConfiguration,
            NoIncremental = context.HasArgument("rebuild"),
            Framework = context.Framework,
            MSBuildSettings = context.BuildSettings
        });
    }
}
