using System;
using System.Collections.Generic;
using System.Text;

namespace BankReg
{
    public class Customer
    {

        public string Name { get; set; }
        public int Acc { get; set; }


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Customer))
            {
                return false;
            }
            Customer result = (Customer)obj;
            return result.Name == Name && result.Acc == Acc;
        }

        public static bool operator ==(Customer first, Customer second)
        {
            return first.Equals(second);
        }
        public static bool operator !=(Customer first, Customer second)
        {
            return !first.Equals(second);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }



}
