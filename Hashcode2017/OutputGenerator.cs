using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashcode2017
{
    public static class OutputGenerator
    {
        /// <summary>
        /// Outputs to a file
        /// </summary>
        /// <param name="fileName">Creates a file in your desktop with this name.</param>
        /// <param name="videosInServer">A list of lists. Each list is the videos in each server. For example for 2 servers, it's two sub lists, each with the videos as elements.</param>
        public static void CreateOutput(string fileName, List<List<int>> videosInServer)
        {
            string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
            if (File.Exists(filepath))
            {
                Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                File.Move(filepath, filepath + unixTimestamp);
            }
            using (var streamWriter = new StreamWriter(filepath))
            {
                var numberOfCacheServers = videosInServer.Count();

                streamWriter.WriteLine(numberOfCacheServers);

                for (int i = 0; i < numberOfCacheServers; i++)
                {
                    streamWriter.Write(i);
                    streamWriter.Write(' ');
                    for (int j = 0; j < videosInServer[i].Count(); j++)
                    {
                        streamWriter.Write(videosInServer[i][j]);
                        streamWriter.Write(' ');
                    }
                    streamWriter.Write('\n');
                }
            }
            return;
        }
    }
}
