using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Org.Quantintel.Spectrum.Model
{
    public class SingleLongValue
    {
        public long? value { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SingleLongValue {\n");
            sb.Append("  value: ").Append(value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}