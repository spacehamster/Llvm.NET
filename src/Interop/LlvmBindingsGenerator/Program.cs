// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.IO;
using System.Reflection;

using CppSharp;

using LlvmBindingsGenerator.Configuration;
using LlvmBindingsGenerator.Configuration.Yaml;

namespace LlvmBindingsGenerator
{
    internal static class Program
    {
        public static int Main( string[ ] args )
        {
            var diagnostics = new ErrorTrackingDiagnostics( );
            Diagnostics.Implementation = diagnostics;

            if( args.Length < 2 )
            {
                Diagnostics.Error( "USAGE: LlvmBindingsGenerator <llvmRoot> <extensionsRoot> [OutputPath]" );
                return -1;
            }

            string llvmRoot = Path.GetFullPath(args[ 0 ]);
            string extensionsRoot = Path.GetFullPath(args[ 1 ]);
            string outputPath = args.Length > 2 ? Path.GetFullPath(args[ 2 ]) : System.Environment.CurrentDirectory;

            // read in the binding configuration from the YAML file
            // It is hoped, that going forward, the YAML file is the only thing that needs to change
            // but either way, helps keep the declarative part in a more easily understood format.
            string configPath = Path.Combine( Path.GetDirectoryName( Assembly.GetExecutingAssembly().Location ), "BindingsConfig.yml");
            var yamlConfig = YamlConfiguration.ParseFrom( configPath );
            AddStrippedFunctions( yamlConfig, Path.Combine( Path.GetDirectoryName( Assembly.GetExecutingAssembly().Location ), "StrippedSymbols.txt" ) );
            var config = new ReadOnlyConfig( yamlConfig );
            var library = new LibLlvmGeneratorLibrary( config, llvmRoot, extensionsRoot, outputPath );
            Driver.Run( library );
            return diagnostics.ErrorCount;
            /* TODO:
            Auto merge the generated docs XML with the Hand edited API Docs as hand merging is tedious and error prone.
                1) delete entries in APIDocs no longer in generated docs
                2) add entries to APIDocs for elements in generated docs but not in API Docs
                3) Leave everything else in APIDocs, intact
            */
        }

        private static void AddStrippedFunctions(YamlConfiguration config, string path)
        {
            foreach(string line in File.ReadAllLines( path ))
            {
                if(config.FunctionBindings.ContainsKey( line ))
                {
                    var binding = config.FunctionBindings[line];
                    binding.IsExported = false;
                    binding.IsProjected = false;
                }
                else
                {
                    config.FunctionBindings.Add( new YamlFunctionBinding()
                    {
                        Name = line,
                        IsExported = false,
                        IsProjected = false
                    } );
                }
            }
        }
    }
}
