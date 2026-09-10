using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerContracts
{
    internal class Worker
    {
        public string Name { get; set; }

        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Departament Departament { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel workerLevel, double baseSalary, Departament departament)
        {
            Name = name;
            Level = workerLevel;
            BaseSalary = baseSalary;
            Departament = departament;
        }

    }
}
