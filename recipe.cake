#load nuget:?package=Cake.Recipe&version=3.1.1

//*************************************************************************************************
// Settings
//*************************************************************************************************

Environment.SetVariableNames();

BuildParameters.SetParameters(
    context: Context,
    buildSystem: BuildSystem,
    sourceDirectoryPath: "./src",
    title: "Cake.Issues.DocFx",
    repositoryOwner: "cake-contrib",
    repositoryName: "Cake.Issues.DocFx",
    appVeyorAccountName: "cakecontrib",
    shouldRunCoveralls: false, // Disabled because it's currently failing
    shouldPostToGitter: false, // Disabled because it's currently failing
    shouldGenerateDocumentation: false);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(
    context: Context,
    testCoverageFilter: "+[*]* -[xunit.*]* -[Cake.Core]* -[Cake.Testing]* -[*.Tests]* -[Cake.Issues]* -[Cake.Issues.Testing]* -[Shouldly]* -[DiffEngine]* -[EmptyFiles]*",
    testCoverageExcludeByAttribute: "*.ExcludeFromCodeCoverage*",
    testCoverageExcludeByFile: "*/*Designer.cs;*/*.g.cs;*/*.g.i.cs");

//*************************************************************************************************
// Execution
//*************************************************************************************************

Build.RunDotNetCore();