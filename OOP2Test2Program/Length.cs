using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Test2Program
{
    /// <summary>
    /// Represents a length with its unit.
    /// </summary>
    public class Length
    {
        //Changed the access level of the attributes "value" and unit, so they follow the encapsulation concept
        //which protects valuable information that we do not want to be accesible by the end-user.
        //Also added a lower dash to the name of the fields so they are not mistaken by other important keywords
        //Since using a keyword as an identifier is a syntax error

        /// <summary>
        /// Field saving the length. Negative values are not permitted.
        /// </summary>
        private int _value;

        /// <summary>
        /// Field saving the unit. Only use "m" and "ft" as values.
        /// </summary>
        private string _unit;

  /// <inheritdoc/>
        public override string ToString()
        {
            return _value.ToString();
        }
        /// <summary>
        /// gets and sets the value of the field _value. It only accepts values that are positive.
        /// </summary>
        public int Value {
            get { return _value; }
            set { if(_value >0) { _value = value; }
                else {
                    MessageBox.Show("Only positive numbers are allowed");
                        } 
                 }
        }
        /// <summary>
        /// 
        /// gets and sets the value of the field _unit. Only ft and m values are allowed.
        /// </summary>
        public string Unit { 

            get {
                return _unit;
                 }
            set {
                if (_unit.Contains("m") || _unit.Contains("ft")){
                     _unit = value;
                }
                else
                {
                    MessageBox.Show("only m and ft measures are allowed");
                }
  } }
        }
}
