using Interface3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3.Services
{
    class ReciboService
    {
        IJurosSimplesService _jurosSimplesService;

        public ReciboService(IJurosSimplesService jurosSimplesService)
        {
            _jurosSimplesService = jurosSimplesService;
        }

        public double[] JurosValue(ResultValue resultValue)
        {
            double[] TotalValue = new double[resultValue.InstallmentsNumber];
            foreach (var item in _jurosSimplesService.Juros(resultValue))
            {
                TotalValue = _jurosSimplesService.Juros(resultValue);
            }
            return TotalValue;
        }
    }
}
