using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashcode2017
{
    class ΙΟ
    {
        public void Read(string f, List<Video> videos)
        {
            var lines = File.ReadAllLines(f);

            var header = lines[0].Split(' ');
            var videoCount = int.Parse(header[0]);
            var endpointCount = int.Parse(header[1]);
            var requestCount = int.Parse(header[2]);
            var cacheCount = int.Parse(header[3]);
            var capacity = int.Parse(header[4]);

            var v = lines[1].Split(' ').Select(int.Parse).Select(x => new Video(x));
            videos.AddRange(v);

            var endpoints = new List<Endpoint>();
            var lineIdx = 2;
            for(var i = 0; i < endpointCount; i++)
            {
                var e = new Endpoint(cacheCount);
                var line = lines[lineIdx].Split(' ');

                var dataLatency = int.Parse(line[0]);
                e.DataCenterLatency = dataLatency;

                var connectedCaches = int.Parse(line[1]);
                for(var j = 0; i < connectedCaches; j++)
                {
                    lineIdx++;
                    var subLine = lines[lineIdx].Split(' ');
                    var cacheId = int.Parse(subLine[0]);
                    var cacheLatency = int.Parse(subLine[1]);
                    e.CacheLatencies[cacheId] = cacheLatency;
                }
            }
        }
    }
}
