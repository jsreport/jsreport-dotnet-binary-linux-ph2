using jsreport.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;

namespace jsreport.Binary.Linux.Ph2
{
    public class JsReportBinary
    {
        /// <summary>
        /// Get jsreport executable from the assembly manifest stream
        /// </summary>        
        public static IReportingBinary GetBinary()
        {
            var assembly = typeof(JsReportBinary).GetTypeInfo().Assembly;

            return new ReportingBinary("linux-ph2" + assembly.GetName().Version.ToString(),
                () =>
                {
                    var zip = new ZipArchive(assembly.GetManifestResourceStream("jsreport.Binary.Linux.Ph2.jsreport.zip"));
                    return zip.Entries.First().Open();
                });
        }
    }
}
