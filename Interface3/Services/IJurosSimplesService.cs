using Interface3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3.Services
{
    interface IJurosSimplesService
    {
        double[] Juros(ResultValue resultValue);
    }
}