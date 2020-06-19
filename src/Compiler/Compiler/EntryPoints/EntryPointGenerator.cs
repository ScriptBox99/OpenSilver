﻿using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.IO;

namespace DotNetForHtml5.Compiler
{
    //[LoadInSeparateAppDomain]
    //[Serializable]
    public class EntryPointGenerator : Task // AppDomainIsolatedTask
    {
        [Required]
        public string OutputFile { get; set; }

        public override bool Execute()
        {
            ILogger logger = new LoggerThatUsesTaskOutput(this);
            string operationName = "C#/XAML for HTML5: EntryPointGenerator";
            try
            {
                // Validate input strings:
                if (string.IsNullOrEmpty(OutputFile))
                    throw new Exception(operationName + " failed because the output file argument is invalid.");

                //------- DISPLAY THE PROGRESS -------
                logger.WriteMessage(operationName + " started.");

                // Generate attributes:
                string generatedCode = string.Format(@"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by ""C#/XAML for HTML5""
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSHTML5.Generated
{{
    static class CSHTML5_Entry_Point
    {{
        public static void Main()
        {{
            new App();
        }}
    }}
}}

");

                // Create output directory:
                Directory.CreateDirectory(Path.GetDirectoryName(OutputFile));

                // Save output:
                using (StreamWriter outfile = new StreamWriter(OutputFile))
                {
                    outfile.Write(generatedCode);
                }

                //------- DISPLAY THE PROGRESS -------
                logger.WriteMessage(operationName + " completed.");

                return true;
            }
            catch (Exception ex)
            {
                logger.WriteError(operationName + " failed: " + ex.ToString());
                return false;
            }
        }
    }
}