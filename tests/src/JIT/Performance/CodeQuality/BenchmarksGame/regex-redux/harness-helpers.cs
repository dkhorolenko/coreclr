// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// Helper functionality to locate inputs and find outputs for
// regex-redux benchmark in CoreCLR test harness

using System;
using System.IO;
using System.Text;

namespace BenchmarksGame
{
    class TestHarnessHelpers
    {
        public string InputFile;
        public int ExpectedLength;

        public TestHarnessHelpers(bool bigInput, [System.Runtime.CompilerServices.CallerFilePath] string csFileName = "")
        {
            if (bigInput)
            {
                InputFile = FindInputFile("regexdna-input25000.txt", csFileName);
                ExpectedLength = 136381;
            }
            else
            {
                InputFile = FindInputFile("regexdna-input25.txt", csFileName);
                ExpectedLength = 152;
            }
        }

        public string FindInputFile(string inputFile, string csFileName)
        {
            string CoreRoot = System.Environment.GetEnvironmentVariable("CORE_ROOT");

            if (CoreRoot == null)
            {
                Console.WriteLine("This benchmark requries CORE_ROOT to be set");
                return null;
            }

            // The convention is that the csproj file has the same name as the cs file.
            string projectName = Path.GetFileNameWithoutExtension(csFileName);
            int slashIndex = projectName.LastIndexOfAny(new char[] { '/', '\\' });
            if (slashIndex != -1)
            {
                // csFileName was generated by the C# compiler, which may have run on
                // a different host system with different path separator than the
                // currently executing host, which dictates GetFileNameWithoutExtension's
                // behavior... so hope that the slash here is a cross-host path separator,
                // and chop of what were likely direcotires.
                projectName = projectName.Substring(slashIndex + 1);
            }

            // Normal testing -- input file will end up next to the assembly
            // and CoreRoot points at the test overlay dir
            string[] pathPartsNormal = new string[] {
                   CoreRoot, "..", "..", "JIT", "Performance",
                    "CodeQuality", "BenchmarksGame", "regex-redux", projectName, inputFile
                };

            string inputPathNormal = Path.Combine(pathPartsNormal);

            // Perf testing -- input file will end up next to the assembly
            // and CoreRoot points at this directory
            string[] pathPartsPerf = new string[] { CoreRoot, inputFile };

            string inputPathPerf = Path.Combine(pathPartsPerf);

            string inputPath = null;

            if (File.Exists(inputPathNormal))
            {
                inputPath = inputPathNormal;
            }
            else if (File.Exists(inputPathPerf))
            {
                inputPath = inputPathPerf;
            }

            if (inputPath != null)
            {
                Console.WriteLine("Using input file {0}", inputFile);
            }
            else
            {
                throw new Exception($"Unable to find input file {inputFile}.  Tried {inputPathNormal} and {inputPathPerf}; csFileName was {csFileName}, so projectName was {projectName}.");
            }

            return inputPath;
        }
    }
}