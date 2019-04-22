using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3.Entities
{
    class DataContract
    {
        public int Number { get; set; }
        public DateTime DateContract { get; set; }

        public DataContract(int number, DateTime dateContract)
        {
            Number = number;
            DateContract = dateContract;
        }
    }
}
