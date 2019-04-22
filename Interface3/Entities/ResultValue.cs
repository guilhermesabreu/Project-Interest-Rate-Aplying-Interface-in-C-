using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3.Entities
{
    class ResultValue
    {
        public double Value { get; set; }
        public int InstallmentsNumber { get; set; }

        public ResultValue(double value, int installmentsNumber)
        {
            Value = value;
            InstallmentsNumber = installmentsNumber;
        }

    }
}
