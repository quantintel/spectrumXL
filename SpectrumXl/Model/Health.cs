using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Org.Quantintel.Spectrum.Model
{
    public class Health
    {
        public int? liveThreadCount { get; set; }

        public int? peakThreadCount { get; set; }

        public long? startedThreadCount { get; set; }

        public int? daemonThreadCount { get; set; }

        public Memory memory { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Health {\n");
            sb.Append("  liveThreadCount: ").Append(liveThreadCount).Append("\n");
            sb.Append("  peakThreadCount: ").Append(peakThreadCount).Append("\n");
            sb.Append("  startedThreadCount: ").Append(startedThreadCount).Append("\n");
            sb.Append("  daemonThreadCount: ").Append(daemonThreadCount).Append("\n");
            sb.Append("  memory: ").Append(memory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}

