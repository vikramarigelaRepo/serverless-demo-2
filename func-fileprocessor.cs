using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FileProcessor.Function
{
    public static class func_fileprocessor
    {
        [FunctionName("func_fileprocessor")]
        public static void Run([BlobTrigger("samples-workitems/{name}", Connection = "DestinationStorage")] Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes \n CurrTime: {System.DateTime.Now}");
            // write code to validate headers and content.
        }
    }
}
