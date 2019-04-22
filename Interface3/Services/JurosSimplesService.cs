using Interface3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3.Services
{
    class JurosSimplesService : IJurosSimplesService
    {
        public double[] Juros(ResultValue resultValue)
        {
            double installmentsDivision = resultValue.Value / resultValue.InstallmentsNumber;
            int listInstallmentsTotal = resultValue.InstallmentsNumber;
            
            double[] Total = new double[listInstallmentsTotal];
            int Taxa = 1;
            for (int i = 0; i < Total.Length ; i++)
            {
                double installmentsPercent;
                double installmentsPercentTotal;
                installmentsPercent = installmentsDivision + (installmentsDivision * 0.01) * Taxa;     
                installmentsPercentTotal = installmentsPercent + (installmentsPercent * 0.02);
                Total[i] = installmentsPercentTotal;
                Taxa++;
            }
         
            return Total;
            
        }
    }
}
