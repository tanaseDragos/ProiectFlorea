using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectFloreaLicenta
{
    public class CitireBenchmark
    {
        public List<Instructiune> parsareFisierTrc(string filePath)
        {
            var instructions = new List<Instructiune>();

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < parts.Length; i += 3)
                {
                    var tip = parts[i];
                    var pc = int.Parse(parts[i + 1]);
                    var target = int.Parse(parts[i + 2]);

                    instructions.Add(new Instructiune(tip, pc, target));
                }
            }

            return instructions;
        }

    }
}
