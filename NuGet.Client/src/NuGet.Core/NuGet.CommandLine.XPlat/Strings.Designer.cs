﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.CommandLine.XPlat {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Strings() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.CommandLine.XPlat.Strings", typeof(Strings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The API key for the server..
        /// </summary>
        public static string ApiKey_Description {
            get {
                return ResourceManager.GetString("ApiKey_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to NuGet Command Line.
        /// </summary>
        public static string App_FullName {
            get {
                return ResourceManager.GetString("App_FullName", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The base path of the files defined in the nuspec file..
        /// </summary>
        public static string BasePath_Description {
            get {
                return ResourceManager.GetString("BasePath_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Determines if the project should be built before building the package..
        /// </summary>
        public static string Build_Description {
            get {
                return ResourceManager.GetString("Build_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to WARNING: {0}.
        /// </summary>
        public static string CommandLine_Warning {
            get {
                return ResourceManager.GetString("CommandLine_Warning", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0} (y/N) .
        /// </summary>
        public static string ConsoleConfirmMessage {
            get {
                return ResourceManager.GetString("ConsoleConfirmMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to y.
        /// </summary>
        public static string ConsoleConfirmMessageAccept {
            get {
                return ResourceManager.GetString("ConsoleConfirmMessageAccept", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Deletes a package from the server..
        /// </summary>
        public static string Delete_Description {
            get {
                return ResourceManager.GetString("Delete_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Please provide arguments for package id and package version..
        /// </summary>
        public static string Delete_MissingArguments {
            get {
                return ResourceManager.GetString("Delete_MissingArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The Package Id and version..
        /// </summary>
        public static string Delete_PackageIdAndVersion_Description {
            get {
                return ResourceManager.GetString("Delete_PackageIdAndVersion_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Disable buffering when pushing to an HTTP(S) server to decrease memory usage..
        /// </summary>
        public static string DisableBuffering_Description {
            get {
                return ResourceManager.GetString("DisableBuffering_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Source parameter was not specified..
        /// </summary>
        public static string Error_MissingSourceParameter {
            get {
                return ResourceManager.GetString("Error_MissingSourceParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Specifies one or more wildcard patterns to exclude when creating a package..
        /// </summary>
        public static string Exclude_Description {
            get {
                return ResourceManager.GetString("Exclude_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Prevent inclusion of empty directories when building the package..
        /// </summary>
        public static string ExcludeEmptyDirectories_Description {
            get {
                return ResourceManager.GetString("ExcludeEmptyDirectories_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Forces the application to run using an invariant, English-based culture..
        /// </summary>
        public static string ForceEnglishOutput_Description {
            get {
                return ResourceManager.GetString("ForceEnglishOutput_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Include referenced projects either as dependencies or as part of the package..
        /// </summary>
        public static string IncludeReferencedProjects_Description {
            get {
                return ResourceManager.GetString("IncludeReferencedProjects_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Specify the location of the nuspec or project file to create a package..
        /// </summary>
        public static string InputFile_Description {
            get {
                return ResourceManager.GetString("InputFile_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Committing restore....
        /// </summary>
        public static string Log_Committing {
            get {
                return ResourceManager.GetString("Log_Committing", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Found project root directory: {0}..
        /// </summary>
        public static string Log_FoundProjectRoot {
            get {
                return ResourceManager.GetString("Log_FoundProjectRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Loaded project {0} from {1}..
        /// </summary>
        public static string Log_LoadedProject {
            get {
                return ResourceManager.GetString("Log_LoadedProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Reading project file {0}..
        /// </summary>
        public static string Log_ReadingProject {
            get {
                return ResourceManager.GetString("Log_ReadingProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Restore completed in {0}ms..
        /// </summary>
        public static string Log_RestoreComplete {
            get {
                return ResourceManager.GetString("Log_RestoreComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Restore failed in {0}ms..
        /// </summary>
        public static string Log_RestoreFailed {
            get {
                return ResourceManager.GetString("Log_RestoreFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Running non-parallel restore..
        /// </summary>
        public static string Log_RunningNonParallelRestore {
            get {
                return ResourceManager.GetString("Log_RunningNonParallelRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Running restore with {0} concurrent jobs..
        /// </summary>
        public static string Log_RunningParallelRestore {
            get {
                return ResourceManager.GetString("Log_RunningParallelRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Using packages directory: {0}..
        /// </summary>
        public static string Log_UsingPackagesDirectory {
            get {
                return ResourceManager.GetString("Log_UsingPackagesDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Set the minClientVersion attribute for the created package..
        /// </summary>
        public static string MinClientVersion_Description {
            get {
                return ResourceManager.GetString("MinClientVersion_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Specifies the version of MSBuild to be used with this command. Supported values are 4, 12, 14. By default the MSBuild in your path is picked, otherwise it defaults to the highest installed version of MSBuild..
        /// </summary>
        public static string MsBuildVersion_Description {
            get {
                return ResourceManager.GetString("MsBuildVersion_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to No API Key was provided and no API Key could be found for {0}. To save an API Key for a source use the &apos;setApiKey&apos; command..
        /// </summary>
        public static string NoApiKeyFound {
            get {
                return ResourceManager.GetString("NoApiKeyFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Prevent default exclusion of NuGet package files and files and folders starting with a dot e.g. .svn..
        /// </summary>
        public static string NoDefaultExcludes_Description {
            get {
                return ResourceManager.GetString("NoDefaultExcludes_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Do not prompt for user input or confirmations..
        /// </summary>
        public static string NonInteractive_Description {
            get {
                return ResourceManager.GetString("NonInteractive_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Specify if the command should not run package analysis after building the package..
        /// </summary>
        public static string NoPackageAnalysis_Description {
            get {
                return ResourceManager.GetString("NoPackageAnalysis_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to If a symbols package exists, it will not be pushed to a symbols server..
        /// </summary>
        public static string NoSymbols_Description {
            get {
                return ResourceManager.GetString("NoSymbols_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to http://docs.nuget.org/.
        /// </summary>
        public static string NuGetDocs {
            get {
                return ResourceManager.GetString("NuGetDocs", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Specifies the directory for the created NuGet package file. If not specified, uses the current directory.
        /// </summary>
        public static string OutputDirectory_Description {
            get {
                return ResourceManager.GetString("OutputDirectory_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0} Version: {1}.
        /// </summary>
        public static string OutputNuGetVersion {
            get {
                return ResourceManager.GetString("OutputNuGetVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Attempting to build package from &apos;{0}&apos;..
        /// </summary>
        public static string PackageCommandAttemptingToBuildPackage {
            get {
                return ResourceManager.GetString("PackageCommandAttemptingToBuildPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The value of MinClientVersion argument is not a valid version..
        /// </summary>
        public static string PackageCommandInvalidMinClientVersion {
            get {
                return ResourceManager.GetString("PackageCommandInvalidMinClientVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Version string specified &apos;{0}&apos; is invalid..
        /// </summary>
        public static string PackageVersionInvalid {
            get {
                return ResourceManager.GetString("PackageVersionInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Creates a NuGet package based on the specified nuspec or project file.
        /// </summary>
        public static string PackCommand_Description {
            get {
                return ResourceManager.GetString("PackCommand_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Pushes a package to the server and publishes it..
        /// </summary>
        public static string Push_Description {
            get {
                return ResourceManager.GetString("Push_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid timeout parameter value..
        /// </summary>
        public static string Push_InvalidTimeout {
            get {
                return ResourceManager.GetString("Push_InvalidTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Please specify the path to the package..
        /// </summary>
        public static string Push_MissingArguments {
            get {
                return ResourceManager.GetString("Push_MissingArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Specify the path to the package and your API key to push the package to the server..
        /// </summary>
        public static string Push_Package_ApiKey_Description {
            get {
                return ResourceManager.GetString("Push_Package_ApiKey_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Specifies the timeout for pushing to a server in seconds. Defaults to 300 seconds (5 minutes)..
        /// </summary>
        public static string Push_Timeout_Description {
            get {
                return ResourceManager.GetString("Push_Timeout_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Pushing took too long. You can change the default timeout of 300 seconds by using the --timeout &lt;seconds&gt; option with the push command..
        /// </summary>
        public static string Push_Timeout_Error {
            get {
                return ResourceManager.GetString("Push_Timeout_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to List of projects and project folders to restore. Each value can be: a path to a project.json or global.json file, or a folder to recursively search for project.json files..
        /// </summary>
        public static string Restore_Arg_ProjectName_Description {
            get {
                return ResourceManager.GetString("Restore_Arg_ProjectName_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Restores packages for a project and writes a lock file..
        /// </summary>
        public static string Restore_Description {
            get {
                return ResourceManager.GetString("Restore_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The NuGet configuration file to use..
        /// </summary>
        public static string Restore_Switch_ConfigFile_Description {
            get {
                return ResourceManager.GetString("Restore_Switch_ConfigFile_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Disables restoring multiple projects in parallel..
        /// </summary>
        public static string Restore_Switch_DisableParallel_Description {
            get {
                return ResourceManager.GetString("Restore_Switch_DisableParallel_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to A list of packages sources to use as a fallback..
        /// </summary>
        public static string Restore_Switch_Fallback_Description {
            get {
                return ResourceManager.GetString("Restore_Switch_Fallback_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Only warning failed sources if there are packages meeting version requirement.
        /// </summary>
        public static string Restore_Switch_IgnoreFailedSource_Description {
            get {
                return ResourceManager.GetString("Restore_Switch_IgnoreFailedSource_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Do not cache packages and http requests..
        /// </summary>
        public static string Restore_Switch_NoCache_Description {
            get {
                return ResourceManager.GetString("Restore_Switch_NoCache_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Directory to install packages in..
        /// </summary>
        public static string Restore_Switch_Packages_Description {
            get {
                return ResourceManager.GetString("Restore_Switch_Packages_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Specifies a NuGet package source to use during the restore..
        /// </summary>
        public static string Restore_Switch_Source_Description {
            get {
                return ResourceManager.GetString("Restore_Switch_Source_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Specifies the server URL.
        /// </summary>
        public static string Source_Description {
            get {
                return ResourceManager.GetString("Source_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Appends a pre-release suffix to the internally generated version number..
        /// </summary>
        public static string Suffix_Description {
            get {
                return ResourceManager.GetString("Suffix_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The verbosity of logging to use. Allowed values: Debug, Verbose, Information, Minimal, Warning, Error..
        /// </summary>
        public static string Switch_Verbosity {
            get {
                return ResourceManager.GetString("Switch_Verbosity", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Determines if a package containing sources and symbols should be created. When specified with a nuspec, creates a regular NuGet package file and the corresponding symbols package..
        /// </summary>
        public static string Symbols_Description {
            get {
                return ResourceManager.GetString("Symbols_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Determines if the output files of the project should be in the tool folder..
        /// </summary>
        public static string Tool_Description {
            get {
                return ResourceManager.GetString("Tool_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Overrides the version number from the nuspec file..
        /// </summary>
        public static string Version_Description {
            get {
                return ResourceManager.GetString("Version_Description", resourceCulture);
            }
        }
    }
}