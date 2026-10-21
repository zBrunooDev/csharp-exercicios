using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExHashCode.Entities
{
    internal class LogReader
    {
        public string Name { get; set; }
        public DateTime Instant { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is LogReader))
            {
                throw new ArgumentException("The object does not match the expected type.");
            }
            LogReader other = obj as LogReader;
            return other.Name.Equals(Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

    }
}
