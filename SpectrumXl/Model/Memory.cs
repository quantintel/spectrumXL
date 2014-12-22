using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Org.Quantintel.Spectrum.Model
{
    public class Memory
    {
        public long? allocated { get; set; }

        public long? max { get; set; }

        public long? free { get; set; }

        public long? used { get; set; }

        public double? percentUsed { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Memory {\n");
            sb.Append("  allocated: ").Append(allocated).Append("\n");
            sb.Append("  max: ").Append(max).Append("\n");
            sb.Append("  free: ").Append(free).Append("\n");
            sb.Append("  used: ").Append(used).Append("\n");
            sb.Append("  percentUsed: ").Append(percentUsed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}

