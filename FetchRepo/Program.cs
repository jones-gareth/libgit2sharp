using System;
using LibGit2Sharp;

namespace FetchRepo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var config = Configuration.BuildFrom(null);
            var httpsProxy = config.GetValueOrDefault<string>("https.proxy") ?? "not set";
            var httpProxy = config.GetValueOrDefault<string>("http.proxy") ?? "not set";
            Console.WriteLine($"Global git proxy settings, https.proxy: {httpsProxy} http.proxy: {httpProxy}");
            var url = "https://github.com/Glysade/DataFxns";
            var root = "C:/tmp/DataFxns";
            Repository.Clone(url, root);
        }
    }
}
