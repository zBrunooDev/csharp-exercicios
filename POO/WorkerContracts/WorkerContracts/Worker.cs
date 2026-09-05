using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerContracts
{
    internal class Worker
    {
        public string Name { get; private set; }

        public WorkerLevel Level { get; private set; }

        public double BaseSalary { get; private set; }

        public void AddContract(HourContract contract)
        {
            
        }

    }
}
