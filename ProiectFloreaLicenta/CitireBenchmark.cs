using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectFloreaLicenta
{
    public  class CitireBenchmark
    {
        public  int numberOfInstructions;
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

       

        public Instructiune[,] ProcessInstructionsIntoMatrix(List<Instructiune> instructiuni, int IRMaxDePeInterfata)
        {
            numberOfInstructions = instructiuni.Count;
            var instructiuniAduseDinMemorie = new Instructiune[600000, IRMaxDePeInterfata];

            for (int i = 0, row = 0; i < numberOfInstructions; i += IRMaxDePeInterfata, row++)
            {
                for (int col = 0; col < IRMaxDePeInterfata && i + col < numberOfInstructions; col++)
                {
                    instructiuniAduseDinMemorie[row, col] = instructiuni[i + col];
                    if (instructiuni == null) {
                        break;
                    }
                }
                if (instructiuni == null)
                {
                    break;
                }
            }

            return instructiuniAduseDinMemorie;
        }

        

    }
}
