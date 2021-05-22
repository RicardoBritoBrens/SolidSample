using System;
using System.IO;

namespace ArdalisRating
{
    public class FilePolicySource
    {
        public FilePolicySource()
        {
        }

        public string GetFilePolictyFromSource(string jsonFile)
        {
            return File.ReadAllText(jsonFile);
        }
    }
}
