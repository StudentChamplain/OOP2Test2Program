using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Test2Program
{
    /// <summary>
    /// Represents a length with its unit.
    /// </summary>
    public class Length
    {
        /// <summary>
        /// Field saving the length. Negative values are not permitted.
        /// </summary>
        public int value;

        /// <summary>
        /// Field saving the unit. Only use "m" and "ft" as values.
        /// </summary>
        public string unit;

  /// <inheritdoc/>
        public override string ToString()
        {
            return value.ToString();
        }
    }
}
